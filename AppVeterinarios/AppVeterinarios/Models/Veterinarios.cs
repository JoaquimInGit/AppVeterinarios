﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppVeterinarios.Models{
    public class Veterinarios{

        public Veterinarios(){
            ListaConsulta = new HashSet<Consultas>();
        }

        [Key]
        public int ID { get; set; }

        public string Nome{ get; set; }

        public string NumCedulaProf{ get; set; }

        public string Fotografia { get; set; }

        //"querys"
        public ICollection<Consultas> ListaConsulta { get; set; }


    }
}
