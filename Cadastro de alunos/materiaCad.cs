using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_alunos
{
    public partial class materiaCad : Form
    {
        public materiaCad()
        {
            InitializeComponent();
        }
        List<Materia> materias = new List<Materia>();

        private bool ValidarCampoString(string campoValidar, string nomeCampo)
        {
            if (campoValidar == "")
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Etec de Taboão da Serra");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarCampoNum(string campoValidar, string nomeCampo)
        {
            try
            {
                int.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Etec de Taboão da Serra");
                return false;
            }
        }

        private void Cadastrar()
        {
            Materia materia = new Materia();
            materia.id = dgvMaterias.RowCount;
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            materia.nm = txtNome.Text;
            if (ValidarCampoString(txtPeriodo.Text, "Período") == false)
            {
                txtPeriodo.Clear();
                txtPeriodo.Focus();
                return;
            }
            materia.perio = txtPeriodo.Text;
            materia.dtAlt = "0";
            if (ValidarCampoString(txtProfessor.Text, "Professor") == false)
            {
                txtProfessor.Clear();
                txtProfessor.Focus();
                return;
            }
            materia.prof = txtProfessor.Text;
            materia.ativo = 1;
            materias.Add(materia);
            dgvMaterias.DataSource = materias.ToList();
            if (Directory.Exists(@"C:\Cadastros") == false)
            {
                Directory.CreateDirectory(@"C:\Cadastros");
            }
            using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cadastros\Materias.txt", true))
            {
                arquivoTexto.WriteLine("-- Iniciando Log -- ");
                arquivoTexto.WriteLine("Nome da Matéria: " + txtNome.Text);
                arquivoTexto.WriteLine("Período: " + txtPeriodo.Text);
                arquivoTexto.WriteLine("Professor: " + txtProfessor.Text);
                arquivoTexto.WriteLine("-- Término Log --");
                arquivoTexto.WriteLine(" ");
            }
            LimparCampos();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPeriodo.Clear();
            txtProfessor.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void materiaCad_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            try
            {
                richTextBox1.LoadFile("materias.dat");
                for(int i = 0; i < richTextBox1.Lines.Length; i++)
                {
                    string[] linha = richTextBox1.Lines[i].Split('|');
                    Materia materia = new Materia();
                    materia.id = int.Parse(linha[0]);
                    materia.nm = linha[1];
                    materia.perio = linha[2];
                    materia.prof = linha[3];
                    materia.dtAlt = linha[4];
                    materia.ativo = int.Parse(linha[5]);
                    materias.Add(materia);
                    dgvMaterias.DataSource = materias.ToList();
                }
                
            }
            catch
            {

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cont = dgvMaterias.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvMaterias.Rows[i].Cells.Count; a++)
                {
                    if (dgvMaterias.Rows[i].Selected == true || dgvMaterias.Rows[i].Cells[a].Selected == true)
                    {
                        string id = dgvMaterias.Rows[i].Cells[0].Value.ToString();
                        for (int b = 0; b < dgvMaterias.Rows[i].Cells.Count; b++)
                        {
                            dgvMaterias.Rows[i].Cells[b].Value = null;
                        }
                        dgvMaterias.Rows[i].Cells[0].Value = int.Parse(id);
                    }

                }

            }
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            int cont = dgvMaterias.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvMaterias.Rows[i].Cells.Count; a++)
                {
                    if (dgvMaterias.Rows[i].Selected == true || dgvMaterias.Rows[i].Cells[a].Selected == true)
                    {
                        dgvMaterias.Rows[i].Cells[5].Value = 0;
                    }

                }

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            int cont = dgvMaterias.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvMaterias.Rows[i].Cells.Count; a++)
                {
                    if (dgvMaterias.Rows[i].Selected == true || dgvMaterias.Rows[i].Cells[a].Selected == true)
                    {
                        if (ValidarCampoString(txtNome.Text, "Nome") == false)
                        {
                            txtNome.Clear();
                            txtNome.Focus();
                            return;
                        }
                        dgvMaterias.Rows[i].Cells[1].Value = txtNome.Text;
                        if (ValidarCampoString(txtPeriodo.Text, "Período") == false)
                        {
                            txtPeriodo.Clear();
                            txtPeriodo.Focus();
                            return;
                        }
                        dgvMaterias.Rows[i].Cells[2].Value = txtPeriodo.Text;
                        if (ValidarCampoString(txtProfessor.Text, "Professor") == false)
                        {
                            txtProfessor.Clear();
                            txtProfessor.Focus();
                            return;
                        }
                        dgvMaterias.Rows[i].Cells[3].Value = txtProfessor.Text;
                        dgvMaterias.Rows[i].Cells[4].Value = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                    }

                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SaveFile("materias.dat");
        }

        private void materiaCad_Leave(object sender, EventArgs e)
        {

        }

        private void materiaCad_FormClosed(object sender, FormClosedEventArgs e)
        {
            int cont = dgvMaterias.RowCount;
            richTextBox1.Clear();
            for (int i = 0; i < cont; i++)
            {

                if (richTextBox1.Lines.Length == 0)
                {
                    string linha = dgvMaterias.Rows[i].Cells[0].Value.ToString() + "|" + dgvMaterias.Rows[i].Cells[1].Value.ToString() + "|" +
                         dgvMaterias.Rows[i].Cells[2].Value.ToString() + "|" + dgvMaterias.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvMaterias.Rows[i].Cells[4].Value.ToString() + "|" + dgvMaterias.Rows[i].Cells[5].Value.ToString();
                    richTextBox1.AppendText(linha);
                }
                else
                {
                    string linha = "\n" + dgvMaterias.Rows[i].Cells[0].Value.ToString() + "|" + dgvMaterias.Rows[i].Cells[1].Value.ToString() + "|"
                        + dgvMaterias.Rows[i].Cells[2].Value.ToString() + "|" + dgvMaterias.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvMaterias.Rows[i].Cells[4].Value.ToString() + "|" + dgvMaterias.Rows[i].Cells[5].Value.ToString();
                    richTextBox1.AppendText(linha);
                }
            }
            richTextBox1.SaveFile("materias.dat");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvMaterias.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvMaterias.Rows[i].Cells.Count; a++)
                {
                    if (dgvMaterias.Rows[i].Selected == true || dgvMaterias.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvMaterias.Rows[i].Cells[1].Value.ToString();
                        txtPeriodo.Text = dgvMaterias.Rows[i].Cells[2].Value.ToString();
                        txtProfessor.Text = dgvMaterias.Rows[i].Cells[3].Value.ToString();
                    }

                }
            }
        }
    }
}
