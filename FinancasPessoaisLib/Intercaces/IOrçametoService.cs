using FinancasPessoaisLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoaisLib.Intercaces
{
    public interface IOrçametoService
    {
        IEnumerable<Orcamento> ObterTodosOrcamentos();
        Orcamento ObterOrcamentoPorId(int id);
        void AdicionarOrcamento(Orcamento orcamento);
        void AtualizarOrcamento(Orcamento orcamento);
        void RemoverOrcamento(int id);  
    }
}
