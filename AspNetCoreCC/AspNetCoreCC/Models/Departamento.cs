using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCC.Models
{
    [Table("Departamento")]
    public class Departamento
    {
        public long? DepartamentoId { get; set; }

        [Required]
        [Display(Name = "Departamento*")]
        [MaxLength(200, ErrorMessage ="O campo {0} pode conter até {1} caracteres")]
        public string Nome { get; set; }

        public long? InstituicaoId { get; set; }
        public Instituicao Instituicao { get; set; }


    }
}
