using FinancasPessoaisLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoaisLib.Intercaces
{
    internal interface ICategoriaService
    {
        IEnumerable<Categoria> ObterTodasCategorias();
        Categoria ObterCategoriaPorId(int id);
        void AdicionarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
        void RemoverCategoria(int id);
    }
}
