using FinancasPessoaisLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoaisLib.Repositorios
{
    public interface ITransacaoRepository
    {
        void AdicionarTransacao(Transacao transacao);
        void AtualizarTransacao(Transacao transacao);
        void RemoverTransacao(int transacaoId);
        IEnumerable<Transacao> ObterTransacoesPorCategoria(int categoriaId);
        Transacao ObterTransacaoPorId(int transacaoId);
        IEnumerable<Transacao> ObterTodasTransacoes();
    }
}
