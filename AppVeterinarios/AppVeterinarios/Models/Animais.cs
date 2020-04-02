using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppVeterinarios.Models{
    public class Animais{

        public Animais(){
            ListaConsultas = new HashSet<Consultas>();
        }
        
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public double Peso { get; set; }

        public string Foto { get; set; }


        //adição de FK

        [ForeignKey("Dono")] //anotação vai associar o atributo 'DonoFK' ao atributo 'Dono' com a caracteristica de FK
        public int DonoFK { get; set; } //DonoFK int

        public Donos Dono { get; set; } //reference Donos(ID)

        //"querys"
        public ICollection<Consultas> ListaConsultas { get; set; }

    }
}
