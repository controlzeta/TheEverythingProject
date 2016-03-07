using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheEverythingProject.Models
{
    public class PacientesModels
    {
        public LittleDatabaseEntities DB = new LittleDatabaseEntities();
        
        [Required]
        [StringLength(50, MinimumLength = 2)] 
        [DisplayName ("Nombre del Paciente")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)] 
        [DisplayName("Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [DisplayName("Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please provide the phone number area code first in the format (000) 000-0000")]
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [Required]
        [DisplayName("Genero")]
        public char Sexo { get; set; }

        public bool CreatePaciente(Paciente paciente)
        {
            LittleDatabaseEntities DB = new LittleDatabaseEntities();
            TheEverythingProject.Paciente p = new TheEverythingProject.Paciente();
            p.Nombre = paciente.Nombre;
            p.ApellidoPaterno = paciente.ApellidoPaterno;
            p.ApellidoMaterno = paciente.ApellidoMaterno;
            p.Sexo = paciente.Sexo.ToString();
            p.Telefono = paciente.Telefono;
            DB.Pacientes.Add(p);
            DB.SaveChanges();
            return true;
        }

        public static IQueryable<PacientesModels.Paciente> GetPacientes(int idPaciente)
        {
            LittleDatabaseEntities DB = new LittleDatabaseEntities();
            
            if (idPaciente == 0)
            {
                var x = (IQueryable<PacientesModels.Paciente>)from r in DB.Pacientes select r;
                return x;
            }
            var y = (IQueryable < PacientesModels.Paciente >) from r in DB.Pacientes where r.Id == idPaciente select r;
            return y;
        }

        public class Paciente
        {
            public string Nombre { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public string Telefono { get; set; }
            public char Sexo { get; set; }

            public bool CreatePaciente(Paciente paciente)
            {
                LittleDatabaseEntities DB = new LittleDatabaseEntities();
                TheEverythingProject.Paciente p = new TheEverythingProject.Paciente();
                p.Nombre = paciente.Nombre;
                p.ApellidoPaterno = paciente.ApellidoPaterno;
                p.ApellidoMaterno = paciente.ApellidoMaterno;
                p.Sexo = paciente.Sexo.ToString();
                p.Telefono = paciente.Telefono;
                DB.Pacientes.Add(p);
                DB.SaveChanges();
                return true;
            }
        }

        //public List<TheEverythingProject.Paciente> GetPacientes(int id)
        //{
            
        //    TheEverythingProject.Paciente p = new TheEverythingProject.Paciente();
        //    p = DB.Pacientes.SingleOrDefault(x => x.Id.Equals(id)); 
        //    return new List<TheEverythingProject.Paciente>();
        //}

        //public bool CreatePaciente(Paciente paciente)
        //{
        //    TheEverythingProject.Paciente p = new TheEverythingProject.Paciente();
        //    p.Nombre = paciente.Nombre;
        //    p.ApellidoPaterno = paciente.ApellidoPaterno;
        //    p.ApellidoMaterno = paciente.ApellidoMaterno;
        //    p.Sexo = paciente.Sexo.ToString();
        //    p.Telefono = paciente.Telefono;
        //    DB.Pacientes.Add(p);
        //    DB.SaveChanges();
        //    return true;
        //}
    }
}