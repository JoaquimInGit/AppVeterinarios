using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppVeterinarios.Models{
    public class Donos{
        
        public Donos(){
            ListaAnimais = new HashSet<Animais>();//coloca dados na lista dos animais de cada dono
        }

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string NIF { get; set; }


        //select * 
        //from Animais a Donos d
        //Where a.DonoFK = d.ID
        public ICollection<Animais> ListaAnimais { get; set; }
    }
}
