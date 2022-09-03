using System;
namespace HospiEnCasa.App.Dominio{
    public class SignoVital{
      
      public int Id {get;set;}
      public DateTime FechaHora {get;set;}
      public signo Signo {get;set;}  
    }
}