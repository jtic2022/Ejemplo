using System;
namespace HospiEnCasa.App.Dominio{
    public class Paciente{
        
        public int Id{get;set;}
        public string Direccion {get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad {get;set;}
        public DateTime FechaNacimiento{get;set;}

        
    }
}