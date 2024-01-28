using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasPessoaisLib.Models
{
    public class Transacao
    {
        public int TransacaoId { get; set; }
        public string Descricao { get; set; }
        public DateTime Data {  get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
