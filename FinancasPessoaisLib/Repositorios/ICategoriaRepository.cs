using FinancasPessoaisLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoaisLib.Repositorios
{
    public interface ICategoriaRepository
    {
        void AdicionarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
        void RemoverCategoria(int categoriaId);
        IEnumerable<Categoria> ObterTodasCategorias();
    }
}
