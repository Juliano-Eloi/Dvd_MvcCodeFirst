using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dvd_MvcCodeFirst.Models
{
    public class Aluno
    {
        [Key]
        public int IDAluno { get; set; }

        [DisplayName("Professor")]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MaxLength(50), MinLength(5)]
        public string NomeAluno { get; set; }

        [Required(ErrorMessage = "Digite o email.")]
        [StringLength(250)]
        public string Email { get; set; }

        [Range(1980, 2020, ErrorMessage = "O ano deverá ser entre 1980 e 2020.")]
        public int Ano { get; set; }

        public bool Aprovado { get; set; }

        public DateTime Inscricao { get; set; }

        //lazy loading = add virtual
        public virtual Professor Professor { get; set; }
    }
}
