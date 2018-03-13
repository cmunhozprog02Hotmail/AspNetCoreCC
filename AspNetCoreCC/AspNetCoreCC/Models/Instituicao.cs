using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCC.Models
{
    public class Instituicao
    {
        public long? InstituicaoId { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }
    }
}
