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

        // lista de anotadores possíveis
        /// <summary>
        /// Nome do Dono
        /// </summary>
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="O nome é de preenchimento obrigatório")]
        [StringLength(40, ErrorMessage = "=O {0} não pode ter mais de {1} caracter")]
        [RegularExpression("[A-ZÂÓÍÉ][a-záéíóúàèìòùäëïöüçñ]+(( | d[oa](s)? | (d)?e |-|'| d')[A-ZÂÓÍÉ][a-záéíóúàèìòùäëïöüçñ]+){1,3}", 
            ErrorMessage = "Só são aceites letras.<br />A primeira letra é uma Maiúscula seguida de minúsculas.<br />Deve escrever 2 a 4 nomes.")]
        public string Nome { get; set; }


        /// <summary>
        /// Sexo do(a) Dono(a)
        /// </summary>
        [Required(ErrorMessage = "O {0} é se preencimento obrigatorio")]
        [StringLength(1)]
        [RegularExpression("[mfMF]")]
        public string Sexo { get; set; }

        /// <summary>
        /// Numero de Identificação Fiscal, do Dono
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter exatamente {1} caracteres.")]
        [RegularExpression("[1356][0-9]{8}", ErrorMessage = "Só são aceites 9 algarismos, começando por 1,3,5 ou 6.")] //
        public string NIF { get; set; }



        //select * 
        //from Animais a Donos d
        //Where a.DonoFK = d.ID
        /// <summary>
        /// Lista dos Animais Associados a um Dono
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }
    }
}
