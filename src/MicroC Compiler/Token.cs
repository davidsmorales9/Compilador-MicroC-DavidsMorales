using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MicroC_Compiler.tokenType;

namespace MicroC_Compiler
{
    internal class Token
    {
        //Getters y Setters 
        public int TokenCode { get; set; }
        public string Value { get; set; }
        public int Line { get; set; }

        public Token(int tokenCode, string value, int line)
        {
            TokenCode = tokenCode;
            Value = value;
            Line = line;
        }

        // Método para representar el token como una cadena legible
        public override string ToString()
        {
            if (Value.StartsWith("ERROR"))
                return $"{Value} (Línea {Line})";

            return $"Línea: {Line} | Lexema: {Value} | Token: {TokenCode}";
        }
    }
}
