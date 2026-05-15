using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroC_Compiler
{
    internal class UnidadesLexicas
    {
        /* Diccionarios para almacenar las palabras reservadas y los símbolos 
         con identificador de token*/
        public Dictionary<string, int> Palabra =
            new Dictionary<string, int>();

        public Dictionary<string, int> Simbolo =
            new Dictionary<string, int>();

        public UnidadesLexicas()
        {
            // PALABRAS RESERVADAS
            Palabra.Add("if", 16);
            Palabra.Add("int", 17);
            Palabra.Add("while", 18);
            Palabra.Add("return", 19);
            Palabra.Add("float", 20);
            Palabra.Add("double", 21);
            Palabra.Add("for", 22);
            Palabra.Add("char", 23);
            Palabra.Add("else", 24);

            // OPERADORES
            Simbolo.Add("+", 70);
            Simbolo.Add("-", 71);
            Simbolo.Add("*", 72);
            Simbolo.Add("/", 73);
            Simbolo.Add("=", 74);
            Simbolo.Add("!", 85);
            Simbolo.Add("&&", 86);
            Simbolo.Add("||", 87);
           

            // RELACIONALES
            Simbolo.Add("<", 75);
            Simbolo.Add(">", 76);
            Simbolo.Add("<=", 77);
            Simbolo.Add(">=", 78);
            Simbolo.Add("==", 79);
            Simbolo.Add("!=", 80);

            // DELIMITADORES
            Simbolo.Add("(", 81);
            Simbolo.Add(")", 82);
            Simbolo.Add("{", 83);
            Simbolo.Add("}", 84);
            Simbolo.Add(";", 92);
        }

        // Método para obtener el token de una palabra reservada, si no se encuentra devuelve 500
        public int GetTokenPalabra(string lexema)
        {
            if (Palabra.ContainsKey(lexema))
                return Palabra[lexema];

            return 500; // ID 
        }

        // Método para obtener el token de un símbolo, si no se encuentra devuelve 600
        public int GetTokenSimbolo(string lexema)
        {
            if (Simbolo.ContainsKey(lexema))
                return Simbolo[lexema];

            return 600; //Token desconocido
        }
    }

}
