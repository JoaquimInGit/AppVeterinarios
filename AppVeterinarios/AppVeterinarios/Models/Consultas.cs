using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppVeterinarios.Models{
    public class Consultas{

        public int ID { get; set; }
        public DateTime Data { get; set; }

        public string Observacoes { get; set; }

        //FKs

        [ForeignKey(nameof(Veterinario))] //nameof() devolve a designação do objeto que é colocado como parmetro
        public int VeterinarioFK { get; set; }

        public Veterinarios Veterinario{ get; set; }


        [ForeignKey(nameof(Animal))]
        public int AnimalFK { get; set; }

        public Animais Animal { get; set; }

    }
}
