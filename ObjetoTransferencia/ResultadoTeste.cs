using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   // CONTAGEM DOS ACERTOS
    public class ResultadoTeste {

       private static int acertos;

       public static void Resultado()
       {
        acertos += 1;
       }
       public static int RetornarResultado()
       { 
           return acertos; 
       }
   }
}
