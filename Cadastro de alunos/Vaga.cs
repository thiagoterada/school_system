using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_alunos
{
    class Vaga
    {
        public int id { get; set; }
        public int idTurma { get; set; }
        public int idAluno { get; set; }
        public string aluno { get; set; }
        public int ano { get; set; }
        public string dtAlt { get; set; }
        public int ativo { get; set; }
    }
}
