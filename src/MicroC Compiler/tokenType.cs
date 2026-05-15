using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroC_Compiler
{
       // Para representar los tipos de tokens que el analizador léxico puede identificar
        public enum tokenType
        {
        COMMENT,
        KW,       
        ID,
        NUM,
        OP,
        DELIM
    }
    
}
