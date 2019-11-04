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
    public partial class alunoCad : Form
    {
        public alunoCad()
        {
            InitializeComponent();
        }
        List<Aluno> alunos = new List<Aluno>();

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

        private bool ValidarCampoTel(string campoValidar, string nomeCampo)
        {
            int cont = 0;
            for (int i = 0; i < campoValidar.Length; i++)
            {
                if (campoValidar[i] == '1' || campoValidar[i] == '2' || campoValidar[i] == '3'
                    || campoValidar[i] == '4' || campoValidar[i] == '5' || campoValidar[i] == '6'
                    || campoValidar[i] == '7' || campoValidar[i] == '8' || campoValidar[i] == '9'
                    || campoValidar[i] == '(' || campoValidar[i] == ')' || campoValidar[i] == '-')
                {
                }
                else
                {
                    cont = 1;
                }
            }
            if(cont == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Etec de Taboão da Serra");
                return false;
            }
        }

        private void Cadastrar()
        {
            Aluno aluno = new Aluno();

            aluno.id = dgvAlunos.RowCount;
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            aluno.nome = txtNome.Text;
            if (ValidarCampoString(cboSexo.Text, "Sexo") == false)
            {
                cboSexo.Focus();
                return;
            }
            aluno.sexo = cboSexo.Text;
            if (ValidarCampoString(txtCpf.Text, "CPF") == false)
            {
                txtCpf.Clear();
                txtCpf.Focus();
                return;
            }
            aluno.cpf = txtCpf.Text;
            if (ValidarCampoData(txtDn.Text, "Data de Nascimento") == false)
            {
                txtDn.Clear();
                txtDn.Focus();
                return;
            }
            aluno.dn = txtDn.Text;
            if (ValidarCampoString(txtTel.Text, "Telefone") == false)
            {
                txtTel.Clear();
                txtTel.Focus();
                return;
            }
            if (ValidarCampoTel(txtTel.Text, "Telefone") == false)
            {
                txtTel.Clear();
                txtTel.Focus();
                return;
            }
            aluno.tl = txtTel.Text;
            if (ValidarCampoString(txtCel.Text, "Celular") == false)
            {
                txtCel.Clear();
                txtCel.Focus();
                return;
            }
            if (ValidarCampoTel(txtCel.Text, "Celular") == false)
            {
                txtCel.Clear();
                txtCel.Focus();
                return;
            }
            aluno.cel = txtCel.Text;
            if (ValidarCampoString(cboEst.Text, "Estado") == false)
            {
                cboEst.Focus();
                return;
            }
            aluno.est = cboEst.Text;
            if (ValidarCampoString(txtCid.Text, "Cidade") == false)
            {
                txtCid.Clear();
                txtCid.Focus();
                return;
            }
            aluno.cid = txtCid.Text;
            if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
            {
                txtBairro.Clear();
                txtBairro.Focus();
                return;
            }
            aluno.bairro = txtBairro.Text;
            if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
            {
                txtLogra.Clear();
                txtLogra.Focus();
                return;
            }
            aluno.logra = txtLogra.Text;
            if (ValidarCampoNum(txtNum.Text, "Número") == false)
            {
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            aluno.num = int.Parse(txtNum.Text);
            if (ValidarCampoString(txtCep.Text, "CEP") == false)
            {
                txtCep.Clear();
                txtCep.Focus();
                return;
            }
            aluno.cep = txtCep.Text;
            if(txtCompl.Text != "")
            {
                aluno.comp = txtCompl.Text;
            }
            else
            {
                aluno.comp = "null";
            }
            aluno.dtAlt = "0";
            aluno.ativo = 1;
            alunos.Add(aluno);
            dgvAlunos.DataSource = alunos.ToList();
            if (Directory.Exists(@"C:\Cadastros") == false)
            {
                Directory.CreateDirectory(@"C:\Cadastros");
            }
            using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cadastros\Alunos.txt", true))
            {
                arquivoTexto.WriteLine("-- Iniciando Log -- ");
                arquivoTexto.WriteLine("Nome do Cliente: " + txtNome.Text);
                arquivoTexto.WriteLine("Sexo: " + cboSexo.Text);
                arquivoTexto.WriteLine("CPF: " + txtCpf.Text);
                arquivoTexto.WriteLine("Data de Nascimento: " + txtDn.Text);
                arquivoTexto.WriteLine("Telefone: " + txtTel.Text);
                arquivoTexto.WriteLine("Celular: " + txtCel.Text);
                arquivoTexto.WriteLine("Estado: " + cboEst.Text);
                arquivoTexto.WriteLine("Cidade: " + txtCid.Text);
                arquivoTexto.WriteLine("Bairro: " + txtBairro.Text);
                arquivoTexto.WriteLine("Logradouro: " + txtLogra.Text);
                arquivoTexto.WriteLine("Número: " + txtNum.Text);
                arquivoTexto.WriteLine("CEP: " + txtCep.Text);
                arquivoTexto.WriteLine("Complemento: " + txtCompl.Text);
                arquivoTexto.WriteLine("-- Término Log --");
                arquivoTexto.WriteLine(" ");
            }
            LimparCampos();

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtDn.Clear();
            txtTel.Clear();
            txtCel.Clear();
            txtCid.Clear();
            txtBairro.Clear();
            txtLogra.Clear();
            txtNum.Clear();
            txtCep.Clear();
            txtCompl.Clear();
            cboEst.ResetText();
            cboSexo.ResetText();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void alunoCad_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            try
            {
                richTextBox1.LoadFile("alunos.dat");
                for (int i = 0; i < richTextBox1.Lines.Length; i++)
                {
                    string[] linha = richTextBox1.Lines[i].Split('|');
                    Aluno aluno = new Aluno();
                    aluno.id = int.Parse(linha[0]);
                    aluno.nome = linha[1];
                    aluno.sexo = linha[2];
                    aluno.cpf = linha[3];
                    aluno.dn = linha[4];
                    aluno.tl = linha[5];
                    aluno.cel = linha[6];
                    aluno.est = linha[7];
                    aluno.cid = linha[8];
                    aluno.bairro = linha[9];
                    aluno.logra = linha[10];
                    aluno.num = int.Parse(linha[11]);
                    aluno.cep = linha[12];
                    aluno.comp = linha[13];
                    aluno.dtAlt = linha[14];
                    aluno.ativo = int.Parse(linha[15]);
                    alunos.Add(aluno);
                    dgvAlunos.DataSource = alunos.ToList();
                }

            }
            catch
            {

            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cont = dgvAlunos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvAlunos.Rows[i].Cells.Count; a++)
                {
                    if (dgvAlunos.Rows[i].Selected == true || dgvAlunos.Rows[i].Cells[a].Selected == true)
                    {
                        string id = dgvAlunos.Rows[i].Cells[0].Value.ToString();
                        for (int b = 0; b < dgvAlunos.Rows[i].Cells.Count; b++)
                        {
                            dgvAlunos.Rows[i].Cells[b].Value = null;
                        }
                        dgvAlunos.Rows[i].Cells[0].Value = int.Parse(id);
                    }

                }

            }
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            int cont = dgvAlunos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvAlunos.Rows[i].Cells.Count; a++)
                {
                    if (dgvAlunos.Rows[i].Selected == true || dgvAlunos.Rows[i].Cells[a].Selected == true)
                    {
                        dgvAlunos.Rows[i].Cells[15].Value = 0;
                    }

                }

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            int cont = dgvAlunos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvAlunos.Rows[i].Cells.Count; a++)
                {
                    if (dgvAlunos.Rows[i].Selected == true || dgvAlunos.Rows[i].Cells[a].Selected == true)
                    {
                        if (ValidarCampoString(txtNome.Text, "Nome") == false)
                        {
                            txtNome.Clear();
                            txtNome.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[1].Value = txtNome.Text;
                        if (ValidarCampoString(cboSexo.Text, "Sexo") == false)
                        {
                            cboSexo.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[2].Value = cboSexo.Text;
                        if (ValidarCampoString(txtCpf.Text, "CPF") == false)
                        {
                            txtCpf.Clear();
                            txtCpf.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[3].Value = txtCpf.Text;
                        if (ValidarCampoData(txtDn.Text, "Data de Nascimento") == false)
                        {
                            txtDn.Clear();
                            txtDn.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[4].Value = txtDn.Text;
                        if (ValidarCampoString(txtTel.Text, "Telefone") == false)
                        {
                            txtTel.Clear();
                            txtTel.Focus();
                            return;
                        }
                        if (ValidarCampoTel(txtTel.Text, "Telefone") == false)
                        {
                            txtTel.Clear();
                            txtTel.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[5].Value = txtTel.Text;
                        if (ValidarCampoString(txtCel.Text, "Celular") == false)
                        {
                            txtCel.Clear();
                            txtCel.Focus();
                            return;
                        }
                        if (ValidarCampoTel(txtCel.Text, "Celular") == false)
                        {
                            txtCel.Clear();
                            txtCel.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[6].Value = txtCel.Text;
                        if (ValidarCampoString(cboEst.Text, "Estado") == false)
                        {
                            cboEst.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[7].Value = cboEst.Text;
                        if (ValidarCampoString(txtCid.Text, "Cidade") == false)
                        {
                            txtCid.Clear();
                            txtCid.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[8].Value = txtCid.Text;
                        if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
                        {
                            txtBairro.Clear();
                            txtBairro.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[9].Value = txtBairro.Text;
                        if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
                        {
                            txtLogra.Clear();
                            txtLogra.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[10].Value = txtLogra.Text;
                        if (ValidarCampoNum(txtNum.Text, "Número") == false)
                        {
                            txtNum.Clear();
                            txtNum.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[11].Value = int.Parse(txtNum.Text);
                        if (ValidarCampoString(txtCep.Text, "CEP") == false)
                        {
                            txtCep.Clear();
                            txtCep.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[12].Value = txtCep.Text;
                        if (txtCompl.Text != "")
                        {
                            dgvAlunos.Rows[i].Cells[13].Value = txtCompl.Text;
                        }
                        else
                        {
                            dgvAlunos.Rows[i].Cells[13].Value = "null";
                        }
                        
                        dgvAlunos.Rows[i].Cells[14].Value = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                    }

                }
            }
        }

        private void alunoCad_FormClosed(object sender, FormClosedEventArgs e)
        {
            int cont = dgvAlunos.RowCount;
            richTextBox1.Clear();
            for (int i = 0; i < cont; i++)
            {

                if (richTextBox1.Lines.Length == 0)
                {
                    string linha = dgvAlunos.Rows[i].Cells[0].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[1].Value.ToString() + "|" +
                         dgvAlunos.Rows[i].Cells[2].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[4].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[5].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[6].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[7].Value.ToString() + "|" +
                         dgvAlunos.Rows[i].Cells[8].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[9].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[10].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[11].Value.ToString() + "|" +
                         dgvAlunos.Rows[i].Cells[12].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[13].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[14].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[15].Value.ToString();
                    richTextBox1.AppendText(linha);
                }
                else
                {
                    string linha = "\n" + dgvAlunos.Rows[i].Cells[0].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[1].Value.ToString() + "|" +
                         dgvAlunos.Rows[i].Cells[2].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[4].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[5].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[6].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[7].Value.ToString() + "|" +
                         dgvAlunos.Rows[i].Cells[8].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[9].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[10].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[11].Value.ToString() + "|" +
                         dgvAlunos.Rows[i].Cells[12].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[13].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[14].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[15].Value.ToString();
                    richTextBox1.AppendText(linha);
                }
            }
            richTextBox1.SaveFile("alunos.dat");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvAlunos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvAlunos.Rows[i].Cells.Count; a++)
                {
                    if (dgvAlunos.Rows[i].Selected == true || dgvAlunos.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvAlunos.Rows[i].Cells[1].Value.ToString();
                        cboSexo.Text = dgvAlunos.Rows[i].Cells[2].Value.ToString();
                        txtCpf.Text = dgvAlunos.Rows[i].Cells[3].Value.ToString();
                        txtDn.Text = dgvAlunos.Rows[i].Cells[4].Value.ToString();
                        txtTel.Text = dgvAlunos.Rows[i].Cells[5].Value.ToString();
                        txtCel.Text = dgvAlunos.Rows[i].Cells[6].Value.ToString();
                        cboEst.Text = dgvAlunos.Rows[i].Cells[7].Value.ToString();
                        txtCid.Text = dgvAlunos.Rows[i].Cells[8].Value.ToString();
                        txtBairro.Text = dgvAlunos.Rows[i].Cells[9].Value.ToString();
                        txtLogra.Text = dgvAlunos.Rows[i].Cells[10].Value.ToString();
                        txtNum.Text = dgvAlunos.Rows[i].Cells[11].Value.ToString();
                        txtCep.Text = dgvAlunos.Rows[i].Cells[12].Value.ToString();
                        txtCompl.Text = dgvAlunos.Rows[i].Cells[13].Value.ToString();
                    }

                }
            }
        }
    }
}
