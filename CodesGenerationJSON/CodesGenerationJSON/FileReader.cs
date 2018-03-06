using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodesGenerationJSON
{
    class FileReader : IFileReader
    {

        object IFileReader.generateJsonFromFileRead(Db2CodeStyle style)
        {
            throw new NotImplementedException();
        }

        public void readFile(string filePath)
        {
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            BufferedStream buffer = new BufferedStream(stream);
            StreamReader reader = new StreamReader(buffer);

            string line;
            Error errorObj = new Error();
            List<Error> errorList = new List<Error>();

            while ((line = reader.ReadLine()) != null)
            {
                if (errorObj.Code == null || errorObj.Description == null || errorObj.Explanation == null
                     || errorObj.Programmer_response == null || errorObj.Sql_state == null)
                {
                    this.setValueOf(errorObj, this.findReferentAttribute(line, errorObj));
                }
                else
                {
                    errorList.Add(errorObj);
                    errorObj = new Error();
                }
            }
        }

        private void setValueOf(Error item, Dictionary<string, string> hash)
        {
            foreach (KeyValuePair<string, string> key in hash)
            {
                switch (key.Value)
                {
                    case KeyWord.CODE:
                        item.Code = key.Value;
                        break;
                    case KeyWord.DESCRIPTION:
                        item.Description = key.Value;
                        break;
                    case KeyWord.EXPLANATION:
                        item.Explanation = key.Value;
                        break;
                    case KeyWord.SYSTEM_ACTION:
                        item.System_action = key.Value;
                        break;
                    case KeyWord.PROGRAMER_RESPONSE:
                        item.Programmer_response = key.Value;
                        break;
                    case KeyWord.SQL_ERRO:
                        item.Sql_state = key.Value;
                        break;
                }
            }
        }

        /// <summary>
        /// Find in a string if it represents a attribute of the object, if is, return the string 
        /// part as value and the attribute as key
        /// </summary>
        /// <param name="line"></param>
        private Dictionary<string, string> findReferentAttribute(string line, Error err)
        {
            Dictionary<string, string> item = new Dictionary<string, string>();
            string[] words = line.Split(' ');
            StringBuilder stringAux = new StringBuilder();
            string actualItem = null; // represent witch item the foreach is getting the string

            foreach (string word in words)
            {
                string lineAux = this.checkPaginationLine(words); // verify first line (maybe page rummary)
                line = lineAux == null ? line : lineAux;
                
                if (line.Substring(0, 1).Equals("+") || line.Substring(0, 1).Equals("-") || line != null 
                    && stringAux.ToString() == null) //Check just code
                {
                    item.Add(KeyWord.CODE, line);
                    return item;
                }
                else if (word.Equals(KeyWord.EXPLANATION) && actualItem.Equals(KeyWord.EXPLANATION))
                {
                    stringAux.Append(this.concatWithoutFirstWord(words));
                    actualItem = KeyWord.EXPLANATION;
                }
                else if(!word.Equals(KeyWord.DESCRIPTION) && !word.Equals(KeyWord.DESTINATION) && !word.Equals(KeyWord.EXPLANATION) &&
                    !word.Equals(KeyWord.NOTE) && !word.Equals(KeyWord.PROGRAMER_RESPONSE) && !word.Equals(KeyWord.SQL_ERRO) &&
                    !word.Equals(KeyWord.SYSTEM_ACTION) && actualItem == null)
                {
                    stringAux.Append(this.concatWithoutFirstWord(words));
                    actualItem = KeyWord.DESCRIPTION;
                }
                else if (word.Equals(KeyWord.DESTINATION))
                {
                    item.Add(KeyWord.DESTINATION, this.concatWithoutFirstWord(words));
                    return item;
                }
            }
            return item;
        }

        /// <summary>
        /// Removes the first element of array and return the rest with a string
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private string concatWithoutFirstWord(string[] line)
        {
            StringBuilder stringReturn = new StringBuilder();
            if (line.Length > 0)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    stringReturn.Append(line[i]);
                }
            }
            return stringReturn.ToString();
        }
        /// <summary>
        /// Check if is a pagination line. If is, return the code that refer to the next description
        /// Else if, the method return null
        /// </summary>
        /// <param name="line"> line splited by ' '</param>
        /// <returns></returns>
        private String checkPaginationLine(string[] words)
        {
            int numberObj = int.MinValue;
            foreach (string word in words)
            {
                if (numberObj != int.MinValue)
                {
                    return word;
                }
                Int32.TryParse(word, out numberObj);
            }
            return null;
        }
    }
}
