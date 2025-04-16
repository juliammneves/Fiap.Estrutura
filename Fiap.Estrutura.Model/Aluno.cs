using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Estrutura.Model
{
    public class Aluno : Pessoa
    {
        public int rm { get; set; }
        public decimal vlMensalidade { get; set; }
    }
}
