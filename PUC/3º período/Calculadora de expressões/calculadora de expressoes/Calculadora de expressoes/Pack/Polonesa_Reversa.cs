using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculadora_de_expressoes.Pack
{
    static class Polonesa_Reversa
    {
        private static List<string> calclog = new List<string>();
        /// <summary>
        /// Calcula uma o valor de uma expressão passada por parâmetro
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static string ExpressionCalculate(string exp)
        {
            return CalcExpression(BuildExpression(exp));
        }
        /// <summary>
        /// Retorna uma string com a expressão separando cada elemento por '.' 
        /// </summary>
        /// <param name="msg">Expressão informada</param>
        /// <param name="pil">Pilha para as operações serem inseridas</param>
        /// <returns></returns>
        public static string BuildExpression(string msg)
        {
            if (Regex.IsMatch(msg, @"^[a-zA-Z]+$")) return ""; //verifica se há letras
            Pilha pil = new Pilha();
            string result = "";
            int last = 0;
            for (int i = 0; i < msg.Length; i++)
            {
                string ch = msg.Substring(i, 1);
                try
                {
                    int aux = Convert.ToInt32(ch);
                    result += aux;
                    for (int i1 = i + 1; i1 < msg.Length; i1++) // Usado para quando o número for maior q 9
                    {
                        string nextchar = msg.Substring(i1, 1);
                        try
                        {
                            aux = Convert.ToInt32(nextchar);
                            result += aux;
                            i++;
                        }
                        catch
                        {
                            if (nextchar == ",")
                            {
                                result += nextchar;
                                i++;
                            }
                            else
                            {
                                result += ".";
                                break;
                            }
                        }
                    }
                    if (i - 1 != -1) if (result.Substring(result.Length - 1, 1) != ".") result += ".";
                }
                catch
                {
                    if (ch == "+" || ch == "-" || ch == "/" || ch == "*" || ch == "^" || ch == ")" || ch == "(" || ch == "√")
                    {
                        if (CalcWeight(ch) > last || CalcWeight(ch) == 0) pil.push(ch);
                        else if (ch == ")") //Desempilhamento das operações para quando uma expressão em parênteses for fechada
                        {
                            string aux = "";
                            while ((aux = pil.pop()) != "(" && aux != null) result += aux + ".";
                            string oldval = pil.pop();
                            if (i + 1 < msg.Length)
                            {
                                if (CalcWeight(oldval) >= CalcWeight(msg.Substring(i + 1, 1))) result += oldval + ".";
                                else pil.push(oldval);
                            }
                            else pil.push(oldval);
                        }
                        else //Desempilha enquanto as operações forem menores da que foi informada
                        {
                            string getval = "";
                            while (CalcWeight(getval = pil.pop()) >= CalcWeight(ch)) result += getval + ".";
                            pil.push(ch);
                        }
                        last = CalcWeight(ch);
                    }
                }
            }
            while (pil.fundo != pil.topo) result += pil.pop() + ".";
            result = result.Replace(")", null);
            result = result.Replace("(", null);
            string resultaux = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (i + 1 < result.Length)
                {
                    if (result.Substring(i, 1) == result.Substring(i + 1, 1))
                    {
                        int count = 1;
                        while (i + count < result.Length && result.Substring(i + count, 1) == ".") count++;
                        if (i + count < result.Length) resultaux += result.Substring(i + count, 1);
                    }
                    else resultaux += result.Substring(i, 1);
                }
            }
            if (!String.IsNullOrEmpty(resultaux)) return resultaux;
            else return result;
        }
        private static List<string> CalcLog()
        {
            return calclog;
        }
        /// <summary>
        /// Retorna o grau de importância de uma operação. Quanto maior o valor, maior o grau
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private static int CalcWeight(string val)
        {
            if (val == "(") return 0;
            else if (val == ")") return 1;
            else if (val == "-" || val == "+") return 2;
            else if (val == "*" || val == "/") return 3;
            else if (val == "^" || val == "√") return 4;
            else return -1;
        }
        private static string CalcExpression(string aux)
        {
            if (aux == "") return "0";
            double sum = 0, val1 = 0, val2 = 0;
            string[] spt = aux.Split('.');
            if (spt.Length == 1) return aux.ToString();
            Pilha old = new Pilha();
            foreach (string str in spt)
            {
                try
                {
                    double convertaux;
                    convertaux = Convert.ToDouble(str);
                    if (val1 != 0 && val2 != 0) old.push(val1.ToString());
                    val1 = val2;
                    val2 = convertaux;
                }
                catch
                {
                    if (str == "+") sum = val2 + val1;
                    else if (str == "-") sum = val1 - val2;
                    else if (str == "/") sum = val1 / val2;
                    else if (str == "*") sum = val1 * val2;
                    else if (str == "^") sum = Math.Pow(val1, val2);
                    else if (str == "√") sum = Math.Sqrt(val2);
                    else return val2.ToString();
                    //checar casas decimais
                    val2 = sum;
                    val1 = Convert.ToDouble(old.pop());
                }
            }
            return sum.ToString();
        }
        /// <summary>
        /// Retorna a expressão sem o '.'
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static string GetExpressionFormated(string exp)
        {
            if (String.IsNullOrEmpty(exp)) return "";
            string toreturn = BuildExpression(exp);
            string[] spt = toreturn.Split('.');
            toreturn = "";
            foreach (string e in spt) toreturn += e;
            return toreturn;
        }
    }
}
