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
    public partial class periodoCad : Form
    {
        public periodoCad()
        {
            InitializeComponent();
        }
        List<Periodo> periodos = new List<Periodo>();

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

        private bool ValidarCampoData(string campoValidar, string nomeCampo)
        {
            try
            {
                DateTime.Parse(campoValidar);
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
            Periodo periodo = new Periodo();
            periodo.id = dgvPeriodos.RowCount;
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            periodo.nome = txtNome.Text;
            if (ValidarCampoData(txtHrIni.Text, "Hora(Início)") == false)
            {
                txtHrIni.Clear();
                txtHrIni.Focus();
                return;
            }
            periodo.hri = txtHrIni.Text;
            if (ValidarCampoData(txtHrTer.Text, "Hora(Término)") == false)
            {
                txtHrTer.Clear();
                txtHrTer.Focus();
                return;
            }
            periodo.hrt = txtHrTer.Text;
            periodo.dtAlt = "0";
            periodo.ativo = 1;
            periodos.Add(periodo);
            dgvPeriodos.DataSource = periodos.ToList();
            if (Directory.Exists(@"C:\Cadastros") == false)
            {
                Directory.CreateDirectory(@"C:\Cadastros");
            }
            using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cadastros\Periodos.txt", true))
            {
                arquivoTexto.WriteLine("-- Iniciando Log -- ");
                arquivoTexto.WriteLine("Nome do Período: " + txtNome.Text);
                arquivoTexto.WriteLine("Hora(Início): " + txtHrIni.Text);
                arquivoTexto.WriteLine("Hora(Término): " + txtHrTer.Text);
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
            txtHrIni.Clear();
            txtHrTer.Clear();
            txtNome.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void periodoCad_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            try
            {
                richTextBox1.LoadFile("periodos.dat");
                for (int i = 0; i < richTextBox1.Lines.Length; i++)
                {
                    string[] linha = richTextBox1.Lines[i].Split('|');
                    Periodo periodo = new Periodo();
                    periodo.id = int.Parse(linha[0]);
                    periodo.nome = linha[1];
                    periodo.hri = linha[2];
                    periodo.hrt = linha[3];
                    periodo.dtAlt = linha[4];
                    periodo.ativo = int.Parse(linha[5]);
                    periodos.Add(periodo);
                    dgvPeriodos.DataSource = periodos.ToList();
                }

            }
            catch
            {

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cont = dgvPeriodos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvPeriodos.Rows[i].Cells.Count; a++)
                {
                    if (dgvPeriodos.Rows[i].Selected == true || dgvPeriodos.Rows[i].Cells[a].Selected == true)
                    {
                        string id = dgvPeriodos.Rows[i].Cells[0].Value.ToString();
                        for (int b = 0; b < dgvPeriodos.Rows[i].Cells.Count; b++)
                        {
                            dgvPeriodos.Rows[i].Cells[b].Value = null;
                        }
                        dgvPeriodos.Rows[i].Cells[0].Value = int.Parse(id);
                    }

                }

            }
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            int cont = dgvPeriodos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvPeriodos.Rows[i].Cells.Count; a++)
                {
                    if (dgvPeriodos.Rows[i].Selected == true || dgvPeriodos.Rows[i].Cells[a].Selected == true)
                    {
                        dgvPeriodos.Rows[i].Cells[5].Value = 0;
                    }

                }

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            int cont = dgvPeriodos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvPeriodos.Rows[i].Cells.Count; a++)
                {
                    if (dgvPeriodos.Rows[i].Selected == true || dgvPeriodos.Rows[i].Cells[a].Selected == true)
                    {
                        if (ValidarCampoString(txtNome.Text, "Nome") == false)
                        {
                            txtNome.Clear();
                            txtNome.Focus();
                            return;
                        }
                        dgvPeriodos.Rows[i].Cells[1].Value = txtNome.Text;
                        if (ValidarCampoData(txtHrIni.Text, "Hora(Início)") == false)
                        {
                            txtHrIni.Clear();
                            txtHrIni.Focus();
                            return;
                        }
                        dgvPeriodos.Rows[i].Cells[2].Value = txtHrIni.Text;
                        if (ValidarCampoData(txtHrTer.Text, "Hora(Término)") == false)
                        {
                            txtHrTer.Clear();
                            txtHrTer.Focus();
                            return;
                        }
                        dgvPeriodos.Rows[i].Cells[3].Value = txtHrTer.Text;
                        dgvPeriodos.Rows[i].Cells[4].Value = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                    }

                }
            }
        }

        private void periodoCad_FormClosed(object sender, FormClosedEventArgs e)
        {
            int cont = dgvPeriodos.RowCount;
            richTextBox1.Clear();
            for (int i = 0; i < cont; i++)
            {

                if (richTextBox1.Lines.Length == 0)
                {
                    string linha = dgvPeriodos.Rows[i].Cells[0].Value.ToString() + "|" + dgvPeriodos.Rows[i].Cells[1].Value.ToString() + "|" +
                         dgvPeriodos.Rows[i].Cells[2].Value.ToString() + "|" + dgvPeriodos.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvPeriodos.Rows[i].Cells[4].Value.ToString() + "|" + dgvPeriodos.Rows[i].Cells[5].Value.ToString();
                    richTextBox1.AppendText(linha);
                }
                else
                {
                    string linha = "\n" + dgvPeriodos.Rows[i].Cells[0].Value.ToString() + "|" + dgvPeriodos.Rows[i].Cells[1].Value.ToString() + "|"
                        + dgvPeriodos.Rows[i].Cells[2].Value.ToString() + "|" + dgvPeriodos.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvPeriodos.Rows[i].Cells[4].Value.ToString() + "|" + dgvPeriodos.Rows[i].Cells[5].Value.ToString();
                    richTextBox1.AppendText(linha);
                }
            }
            richTextBox1.SaveFile("periodos.dat");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvPeriodos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvPeriodos.Rows[i].Cells.Count; a++)
                {
                    if (dgvPeriodos.Rows[i].Selected == true || dgvPeriodos.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvPeriodos.Rows[i].Cells[1].Value.ToString();
                        txtHrIni.Text = dgvPeriodos.Rows[i].Cells[2].Value.ToString();
                        txtHrTer.Text = dgvPeriodos.Rows[i].Cells[3].Value.ToString();
                    }

                }
            }
        }
    }
}
