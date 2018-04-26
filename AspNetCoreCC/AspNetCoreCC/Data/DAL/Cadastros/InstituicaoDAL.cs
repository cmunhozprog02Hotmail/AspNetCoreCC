using Modelo.Cadastros;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreCC.Data.DAL.Cadastros
{
    public class InstituicaoDAL
    {
        private IESContext _context;

        public InstituicaoDAL(IESContext context)
        {
            _context = context;
        }

        public IQueryable<Instituicao> ObterInstituicoesClassificadasPorNome()
        {
            return _context.Instituicoes.OrderBy(b => b.Nome);
        }

        public async Task<Instituicao> ObterInstituicaoPorId(long id)
        {
            return await _context.Instituicoes.Include(d => d.Departamentos)
                .SingleOrDefaultAsync(m => m.InstituicaoId == id);
        }

        public async Task<Instituicao> GravarInstituicao(Instituicao instituicao)
        {
            if (instituicao.InstituicaoId == null)
            {
                _context.Instituicoes.Add(instituicao);
            }
            else
            {
                _context.Update(instituicao);
            }
            await _context.SaveChangesAsync();
            return instituicao;
        }

        public async Task<Instituicao> EliminarInstituicaoPorId(long id)
        {
            Instituicao instituicao = await ObterInstituicaoPorId(id);
            _context.Instituicoes.Remove(instituicao);
            await _context.SaveChangesAsync();
            return instituicao;
        }

    }
}
