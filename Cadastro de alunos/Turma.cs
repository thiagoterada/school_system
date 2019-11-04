using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_alunos
{
    class Turma
    {
        public int id { get; set; }
        public int idEscola { get; set; }
        public string nome { get; set; }
        public int ano { get; set; }
        public string periodo { get; set; }
        public string dtAlt { get; set; }
        public int ativo { get; set; }
    }
}
