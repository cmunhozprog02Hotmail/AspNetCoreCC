using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{

    public class Departamento
    {
        private string _nome;
        public long? DepartamentoId { get; set; }

        [Required]
        [Display(Name = "Departamento*")]
        [MaxLength(200, ErrorMessage = "O campo {0} pode conter até {1} caracteres")]
        public string Nome {
            get { return _nome; }
            set { _nome = value.ToUpper();}
        }

        public long? InstituicaoId { get; set; }
        public Instituicao Instituicao { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }


    }
}
