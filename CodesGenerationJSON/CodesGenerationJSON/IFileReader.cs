using System;

namespace CodesGenerationJSON
{
    interface IFileReader
    {
        /// <summary>
        /// Read a file in memory passing his path on system explorer
        /// </summary>
        /// <param name="filePath"></param>
        void readFile(String filePath);
        
        /// <summary>
        /// Using the class Json_generator, create a json file from the file readed
        /// </summary>
        /// <returns></returns>
        Object generateJsonFromFileRead(Db2CodeStyle style);
    }
}
