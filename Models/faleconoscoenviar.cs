using System.Collections.Generic;
  using System;
namespace atvIII.Models
{
      public class AssuntoRegistro
    {
     public List<RegistroDoassunto> listaFaleConosco = new List<RegistroDoassunto>();
    public List<RegistroDoassunto> Listar()
   { 
   return listaFaleConosco;
   }
   public void Adicionar(RegistroDoassunto registrodoassunto)
        {
            listaFaleConosco.Add(registrodoassunto);
        }
    }
}