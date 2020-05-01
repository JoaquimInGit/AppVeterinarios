using System;
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

        [Display(Name ="Nº Cédula Profissional")]
        [RegularExpression("vet-[0-9]{5}",
            ErrorMessage = "O {0} deve ser escrito em minusculas. <br /> Começar por 'vet-', seguido de 5 algarismos.")]
        [Required(ErrorMessage ="O {0} é de preenchimento obrigatorio")]
        [StringLength(9)]
        public string NumCedulaProf{ get; set; }

        public string Fotografia { get; set; }

        //"querys"
        public ICollection<Consultas> ListaConsulta { get; set; }


    }
}
