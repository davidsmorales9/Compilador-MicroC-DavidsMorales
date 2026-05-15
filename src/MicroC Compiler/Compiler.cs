using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroC_Compiler
{
    internal class Compiler
    {
        public string Compile(string code)
        {
            AnalizadorLexico lexer = new AnalizadorLexico();
            var tokens = lexer.AnalisisLexico(code);

            string result = "";
            int errorCount = 0; //Contador de errores

            foreach (var token in tokens)
            {
                result += token.ToString() + Environment.NewLine;

                // Detectacción de errores
                if (token.Value.StartsWith("ERROR"))
                {
                    errorCount++;
                }
            }

            // Bloqueao de compilación si hay errores
            if (errorCount > 0)
            {
                result += Environment.NewLine;
                result += $"Se encontraron {errorCount} errores léxicos." + Environment.NewLine;
                result += "❌ Compilación detenida.";
            }

            return result;
        }
    }
}
