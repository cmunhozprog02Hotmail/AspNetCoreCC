using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCC.Models
{
    [Table("Instituicao")]
    public class Instituicao
    {
        public long? InstituicaoId { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }
    }
}
