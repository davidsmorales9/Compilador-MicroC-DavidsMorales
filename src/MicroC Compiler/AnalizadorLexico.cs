using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;//Librería para las expresiones regulares
using System.Threading.Tasks;


namespace MicroC_Compiler
{

    internal class AnalizadorLexico
    {
        public List<string> Lista = new List<string>();
        public int cont = 0;
        public int Linea = 1;
        UnidadesLexicas UL = new UnidadesLexicas();


        private static readonly string patternID = @"^[a-zA-Z][a-zA-Z0-9]*"; // Identificadores: empiezan con letra, seguidos de letras o números
        private static readonly string patternInvalidID = @"^\d+[a-zA-Z][a-zA-Z0-9]*";
        private static readonly string patternInvalidSymbol = @"^[^a-zA-Z0-9\s+\-*/=<>();{}]";
        private static readonly string patternNUM = @"^\d+"; // Solo números enteros
        private static readonly string patternOP = @"^(==|!=|<=|>=|=|<|>|\+|\-|\*|/)"; //Iperadores
        private static readonly string patternDELIM = @"^[()\{\};]"; // Agrega más delimitadores según sea necesario
        private static readonly string patternKW = @"^(if|while|return|int|float|double)\b"; // Plabras clave identificadas
        private static readonly string patternCommentLine = @"^//.*"; // Comentarios de línea: empiezan con "//" hasta el final de la línea
        private static readonly string patternCommentBlock = @"^/\*.*?\*/"; // Comentarios de bloque: empiezan con "/*" y terminan con "*/", abarcaN varias líneas

        public List<Token> AnalisisLexico(string input)// Método para analizar el código fuente y generar una lista de tokens
        {
            // Lista que almacena los tokens encontrados
            List<Token> tokens = new List<Token>();

            int lineNumber = 1;
            int index = 0;

            // Recorre el código fuente carácter por carácter
            while (index < input.Length) 
            {
                string remaining = input.Substring(index);

                //Salto de línea
                if (remaining.StartsWith("\n"))
                {
                    lineNumber++;
                    index++;
                    continue;
                }

                // Para espacios
                if (char.IsWhiteSpace(remaining[0]))
                {
                    index++;
                    continue;
                }

                Match match;

                //Comentarios de línea
                match = Regex.Match(remaining, patternCommentLine);
                if (match.Success)
                {
                    tokens.Add(new Token(502, match.Value, lineNumber));
                    index += match.Length;
                    continue;
                }

                //Comentarios de bloque
                match = Regex.Match(remaining, patternCommentBlock, RegexOptions.Singleline);
                if (match.Success)
                {
                    tokens.Add(new Token(502, match.Value, lineNumber));
                    index += match.Length;
                    continue;
                }

                //Keyword
                match = Regex.Match(remaining, patternKW);
                if (match.Success)
                {
                    tokens.Add(new Token(UL.GetTokenPalabra(match.Value), match.Value, lineNumber));
                    index += match.Length;
                    continue;
                }

                // **** ERRORES LÉXICOS ******

                

                //IDENTIFIER
                match = Regex.Match(remaining, patternID);
                if (match.Success)
                {
                    tokens.Add(new Token(500, match.Value, lineNumber));
                    index += match.Length;
                    continue;
                }

                //NUM
                match = Regex.Match(remaining, patternNUM); // Solo números enteros
                if (match.Success)
                {
                    tokens.Add(new Token(501, match.Value, lineNumber));
                    index += match.Length;
                    continue;
                }

                //OPERATION
                match = Regex.Match(remaining, patternOP); 
                if (match.Success)
                {
                    tokens.Add(new Token(UL.GetTokenSimbolo(match.Value), match.Value, lineNumber));
                    index += match.Length;
                    continue;
                }

                //DELIM
                match = Regex.Match(remaining, patternDELIM);
                if (match.Success)
                {
                    tokens.Add(new Token(UL.GetTokenSimbolo(match.Value), match.Value, lineNumber));
                    index += match.Length;
                    continue;
                }

                index++;

                
            }

            return tokens;
        }
        
        // MÉTODOS UML

        public int GetAlfabetoAlfanumerico(char c)
        {
            if (char.IsLetterOrDigit(c))
                return 1;

            return 0;
        }

        public int GetAlfabetoNumero(char c)
        {
            if (char.IsDigit(c))
                return 1;

            return 0;
        }

        public int GetAlfabetoSimbolo(char c)
        {
            string simbolos = "+-*/=<>();{}";

            if (simbolos.Contains(c))
                return 1;

            return 0;
        }

        public void IdentificadorPalabraReservada(string archivo)
        {
            Match match = Regex.Match(archivo, patternKW);

            if (match.Success)
            {
                Lista.Add("Palabra reservada encontrada: " + match.Value);
            }
        }

        public void EnteroReal(string archivo)
        {
            Match match = Regex.Match(archivo, patternNUM);

            if (match.Success)
            {
                Lista.Add("Número encontrado: " + match.Value);
            }
        }

        public void AutomataComentario(string archivo)
        {
            Match matchLine = Regex.Match(archivo, patternCommentLine);

            if (matchLine.Success)
            {
                Lista.Add("Comentario de línea encontrado");
            }

            Match matchBlock = Regex.Match(archivo, patternCommentBlock, RegexOptions.Singleline);

            if (matchBlock.Success)
            {
                Lista.Add("Comentario de bloque encontrado");
            }
        }
    }

}












    
