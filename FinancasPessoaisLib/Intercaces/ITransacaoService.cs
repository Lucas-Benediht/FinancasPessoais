using System.Collections.Generic;
using FinancasPessoaisLib.Models;

namespace FinancasPessoaisLib.Interfaces  
{
    public interface ITransacaoService
    {
        void AdicionarTransacao(Transacao transacao);
        void AtualizarTransacao(Transacao transacao);
        void RemoverTransacao(int transacaoId);
        IEnumerable<Transacao> ObterTransacoesPorCategoria(int categoriaId);
        Transacao ObterTransacaoPorId(int transacaoId);
        IEnumerable<Transacao> ObterTodasTransacoes();
    }
}
