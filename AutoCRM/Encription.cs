using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace AutoCRM
{
    public static class Encription
    {
        private static string[] Line = new string[191]; // vetor contendo todas as linhas da Key
        public static string Encryption(string msg) // Encriptação "DEMOREI PRA CARAI"
        {
            string Enc = " ";
            int i = 0, x = 0, y = 0;
            string character, msgENC = "";

            while (x != msg.Length)
            { // enquanto não pegar todos os caracteres da mensagem

                Enc = msg.Substring(y, 1); // variável Enc recebera o 1 caracter da mensagem
                y++;
                i = 0;
                do
                {
                    character = Line[i].Substring(0, 4); // no arquivo Key, character recebe o primeiro valor unicode para comparar ao caracter da mensagem
                    int code = int.Parse(character, System.Globalization.NumberStyles.HexNumber); // converte o valor unicode para Hex
                    character = char.ConvertFromUtf32(code); // converte o valor hex para UTF-32 e character recebe esse valor

                    if (Enc == character) // 
                    {
                        msgENC += Line[i].Substring(5, Line[i].Length - 5);
                    }
                    i++;

                } while (Enc != character);

                x++;
            }
            return msgENC;
        }
        public static void LerChave()
        {
            StreamReader File = new StreamReader("KeyFileCodes");

            for (int i = 0; i < 191; i++)
            {
                Line[i] = File.ReadLine();
            }
            File.Close();
        }
        public static string Decription(string line)
        {
            int test = 5;
            string Converted = "", resp = "";
            while (line != "")
            {
                int i = 0;

                string get = line.Substring(0, test);

                while (get != Line[i].Substring(5, get.Length))
                {
                    i++;
                }
                if (get == Line[i].Substring(5, get.Length))
                {
                    Converted = Line[i].Substring(0, 4);
                    int code = int.Parse(Converted, System.Globalization.NumberStyles.HexNumber);
                    Converted = char.ConvertFromUtf32(code);
                    resp += Converted;

                    string size = Line[i].Substring(5, Line[i].Length - 5);
                    line = line.Substring(size.Length, line.Length - size.Length);

                }
            }
            return resp;
        }
    }
}
