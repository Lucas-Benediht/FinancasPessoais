using FinancasPessoaisLib.Intercaces;
using FinancasPessoaisLib.Interfaces;
using FinancasPessoaisLib.Models;
using FinancasPessoaisLib.Repositorios;
using System.Collections.Generic;

namespace FinancasPessoaisLib.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _transacaoRepository;

        public TransacaoService(ITransacaoRepository transacaoRepository)
        {
            _transacaoRepository = transacaoRepository;
        }

        public void AdicionarTransacao(Transacao transacao)
        {
            _transacaoRepository.AdicionarTransacao(transacao);
        }

        public void AtualizarTransacao(Transacao transacao)
        {
            _transacaoRepository.AtualizarTransacao(transacao);
        }

        public void RemoverTransacao(int transacaoId)
        {
            _transacaoRepository.RemoverTransacao(transacaoId);
        }

        public IEnumerable<Transacao> ObterTransacoesPorCategoria(int categoriaId)
        {
            return _transacaoRepository.ObterTransacoesPorCategoria(categoriaId);
        }

        public Transacao ObterTransacaoPorId(int transacaoId)
        {
            return _transacaoRepository.ObterTransacaoPorId(transacaoId);
        }

        public IEnumerable<Transacao> ObterTodasTransacoes()
        {
            return _transacaoRepository.ObterTodasTransacoes();
        }
    }
}
