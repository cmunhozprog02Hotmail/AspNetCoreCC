using System.Collections.Generic;

namespace Modelo.Cadastros
{

    public class Instituicao
    {
        public long? InstituicaoId { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}
