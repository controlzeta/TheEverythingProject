using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheEverythingProject.Models
{
    public class PacientesModels
    {
        public LittleDatabaseEntities DB = new LittleDatabaseEntities();

        public class Paciente
        {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Telefono { get; set; }
        public char Sexo { get; set; }
        }

        public List<TheEverythingProject.Paciente> GetPacientes(int id)
        {
            
            TheEverythingProject.Paciente p = new TheEverythingProject.Paciente();
            p = DB.Pacientes.SingleOrDefault(x => x.Id.Equals(id)); 
            return new List<TheEverythingProject.Paciente>();
        }

        public bool CreatePaciente()
        {
            TheEverythingProject.Paciente p = new TheEverythingProject.Paciente();
            p.Nombre = "Francisco";
            p.ApellidoPaterno = "Arroyo";
            p.ApellidoMaterno = "Ortega";
            p.Sexo = "M";
            p.Telefono = "2225276400";
            DB.Pacientes.Add(p);
            DB.SaveChanges();
            return true;
        }
    }
}