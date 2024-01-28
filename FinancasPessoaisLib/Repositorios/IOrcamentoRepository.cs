using FinancasPessoaisLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoaisLib.Repositorios
{
    public interface IOrcamentoRepository
    {
        void AdicionarOrcamento(Orcamento orcamento);
        void AtualizarOrcamento(Orcamento orcamento);
        void RemoverOrcamento(int orcamentoId);
        IEnumerable<Orcamento> ObterTodosOrcamentos();
    }
}
