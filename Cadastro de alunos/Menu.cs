using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_alunos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuCadastro_Aluno_Click(object sender, EventArgs e)
        {
            alunoCad aluno = new alunoCad();
            aluno.MdiParent = this;
            aluno.Show();
        }

        private void menuCadastro_Escola_Click(object sender, EventArgs e)
        {
            escolaCad escola = new escolaCad();
            escola.MdiParent = this;
            escola.Show();
        }

        private void menuCadastro_Materia_Click(object sender, EventArgs e)
        {
            materiaCad materia = new materiaCad();
            materia.MdiParent = this;
            materia.Show();
        }

        private void menuCadastro_Periodo_Click(object sender, EventArgs e)
        {
            periodoCad periodo = new periodoCad();
            periodo.MdiParent = this;
            periodo.Show();
        }

        private void menuCadastro_Professor_Click(object sender, EventArgs e)
        {
            profCad prof = new profCad();
            prof.MdiParent = this;
            prof.Show();
        }

        private void menuAjuda_ResetCad_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("materias.dat");
                richTextBox1.Clear();
                richTextBox1.SaveFile("materias.dat");
            }
            catch
            {

            }
            try
            {
                richTextBox1.LoadFile("alunos.dat");
                richTextBox1.Clear();
                richTextBox1.SaveFile("alunos.dat");
            }
            catch
            {

            }
            try
            {
                richTextBox1.LoadFile("professores.dat");
                richTextBox1.Clear();
                richTextBox1.SaveFile("professores.dat");
            }
            catch
            {

            }
            try
            {
                richTextBox1.LoadFile("periodos.dat");
                richTextBox1.Clear();
                richTextBox1.SaveFile("periodos.dat");
            }
            catch
            {

            }
            try
            {
                richTextBox1.LoadFile("escolas.dat");
                richTextBox1.Clear();
                richTextBox1.SaveFile("escolas.dat");
            }
            catch
            {

            }
            try
            {
                richTextBox1.LoadFile("turmas.dat");
                richTextBox1.Clear();
                richTextBox1.SaveFile("turmas.dat");
            }
            catch
            {

            }
            try
            {
                richTextBox1.LoadFile("vagas.dat");
                richTextBox1.Clear();
                richTextBox1.SaveFile("vagas.dat");
            }
            catch
            {

            }
            try
            {
                richTextBox1.LoadFile("aulas.dat");
                richTextBox1.Clear();
                richTextBox1.SaveFile("aulas.dat");
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo(a)!", "Etec de Taboão");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarTurma turma = new registrarTurma();
            turma.MdiParent = this;
            turma.Show();
        }
    }
}
