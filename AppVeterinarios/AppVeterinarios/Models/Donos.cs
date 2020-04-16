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

        [Required(ErrorMessage ="O nome é de preenchimento obrigatório")]
        [StringLength(40, ErrorMessage = "=O {0} não pode ter mais de {1} caracter")]
        [RegularExpression("[A-Z,a-z]*",ErrorMessage = "Apenas são aceites letras")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter exatamente {1} caracteres.")]
        [RegularExpression("[1356][0-9]{8}", ErrorMessage = "Só são aceites 9 algarismos, começando por 1,3,5 ou 6.")] //
        public string NIF { get; set; }


        //select * 
        //from Animais a Donos d
        //Where a.DonoFK = d.ID
        public ICollection<Animais> ListaAnimais { get; set; }
    }
}
