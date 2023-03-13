using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atvIII.Models
{
    public class Dados
    {
      public static RegistroDoassunto FaleConoscoDados { get; set;}
   static Dados()
   {
       FaleConoscoDados = new RegistroDoassunto();
   }
}
}