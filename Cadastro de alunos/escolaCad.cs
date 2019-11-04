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
    public partial class escolaCad : Form
    {
        public escolaCad()
        {
            InitializeComponent();
        }
        List<Escola> escolas = new List<Escola>();

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
            if (cont == 0)
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
            Escola escola = new Escola();
            escola.id = dgvEscolas.RowCount;
            if(ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            escola.nome = txtNome.Text;
            if (ValidarCampoString(txtCnpj.Text, "CNPJ") == false)
            {
                txtCnpj.Clear();
                txtCnpj.Focus();
                return;
            }
            escola.cnpj = txtCnpj.Text;
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
            escola.tl = txtTel.Text;
            if (txtTel2.Text != "")
            {
                if (ValidarCampoString(txtTel2.Text, "Telefone(2)") == false)
                {
                    txtTel2.Clear();
                    txtTel2.Focus();
                    return;
                }
                if (ValidarCampoTel(txtTel2.Text, "Telefone(2)") == false)
                {
                    txtTel2.Clear();
                    txtTel2.Focus();
                    return;
                }
                escola.tl2 = txtTel2.Text;
            }
            else
            {
                escola.tl2 = "null";
            }
            if (ValidarCampoString(cboEst.Text, "Estado") == false)
            {
                cboEst.Focus();
                return;
            }
            escola.est = cboEst.Text;
            if (ValidarCampoString(txtCid.Text, "Cidade") == false)
            {
                txtCid.Clear();
                txtCid.Focus();
                return;
            }
            escola.cid = txtCid.Text;
            if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
            {
                txtBairro.Clear();
                txtBairro.Focus();
                return;
            }
            escola.bairro = txtBairro.Text;
            if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
            {
                txtLogra.Clear();
                txtLogra.Focus();
                return;
            }
            escola.logra = txtLogra.Text;
            if (ValidarCampoNum(txtNum.Text, "Número") == false)
            {
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            escola.num = int.Parse(txtNum.Text);
            if (ValidarCampoString(txtCep.Text, "CEP") == false)
            {
                txtCep.Clear();
                txtCep.Focus();
                return;
            }
            escola.cep = txtCep.Text;
            if (txtCompl.Text != "")
            {
                escola.comp = txtCompl.Text;
            }
            else
            {
                escola.comp = "null";
            }
            escola.dtAlt = "0";
            escola.ativo = 1;
            escolas.Add(escola);
            dgvEscolas.DataSource = escolas.ToList();
            if (Directory.Exists(@"C:\Cadastros") == false)
            {
                Directory.CreateDirectory(@"C:\Cadastros");
            }
            using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cadastros\Escolas.txt", true))
            {
                arquivoTexto.WriteLine("-- Iniciando Log -- ");
                arquivoTexto.WriteLine("Nome da Escola: " + txtNome.Text);
                arquivoTexto.WriteLine("CNPJ: " + txtCnpj.Text);
                arquivoTexto.WriteLine("Telefone: " + txtTel.Text);
                arquivoTexto.WriteLine("Telefone: " + txtTel2.Text);
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

        private void btnCad_Click(object sender, EventArgs e) //btnCadastrar
        {

            Cadastrar();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCnpj.Clear();
            txtTel.Clear();
            txtTel2.Clear();
            txtCid.Clear();
            txtBairro.Clear();
            txtLogra.Clear();
            txtNum.Clear();
            txtCep.Clear();
            txtCompl.Clear();
            cboEst.ResetText();
        }

        private void btnLimpar_Click(object sender, EventArgs e) //btnLimpar
        {
            LimparCampos();
        }

        private void escolaCad_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            try
            {
                richTextBox1.LoadFile("escolas.dat");
                for (int i = 0; i < richTextBox1.Lines.Length; i++)
                {
                    string[] linha = richTextBox1.Lines[i].Split('|');
                    Escola escola = new Escola();
                    escola.id = int.Parse(linha[0]);
                    escola.nome = linha[1];
                    escola.cnpj = linha[2];
                    escola.tl = linha[3];
                    escola.tl2 = linha[4];
                    escola.est = linha[5];
                    escola.cid = linha[6];
                    escola.bairro = linha[7];
                    escola.logra = linha[8];
                    escola.num = int.Parse(linha[9]);
                    escola.cep = linha[10];
                    escola.comp = linha[11];
                    escola.dtAlt = linha[12];
                    escola.ativo = int.Parse(linha[13]);
                    escolas.Add(escola);
                    dgvEscolas.DataSource = escolas.ToList();
                }

            }
            catch
            {

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cont = dgvEscolas.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvEscolas.Rows[i].Cells.Count; a++)
                {
                    if (dgvEscolas.Rows[i].Selected == true || dgvEscolas.Rows[i].Cells[a].Selected == true)
                    {
                        string id = dgvEscolas.Rows[i].Cells[0].Value.ToString();
                        for (int b = 0; b < dgvEscolas.Rows[i].Cells.Count; b++)
                        {
                            dgvEscolas.Rows[i].Cells[b].Value = null;
                        }
                        dgvEscolas.Rows[i].Cells[0].Value = int.Parse(id);
                    }

                }

            }
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            int cont = dgvEscolas.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvEscolas.Rows[i].Cells.Count; a++)
                {
                    if (dgvEscolas.Rows[i].Selected == true || dgvEscolas.Rows[i].Cells[a].Selected == true)
                    {
                        dgvEscolas.Rows[i].Cells[13].Value = 0;
                    }

                }

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            int cont = dgvEscolas.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvEscolas.Rows[i].Cells.Count; a++)
                {
                    if (dgvEscolas.Rows[i].Selected == true || dgvEscolas.Rows[i].Cells[a].Selected == true)
                    {
                        if (ValidarCampoString(txtNome.Text, "Nome") == false)
                        {
                            txtNome.Clear();
                            txtNome.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[1].Value = txtNome.Text;
                        if (ValidarCampoString(txtCnpj.Text, "CNPJ") == false)
                        {
                            txtCnpj.Clear();
                            txtCnpj.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[2].Value = txtCnpj.Text;
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
                        dgvEscolas.Rows[i].Cells[3].Value = txtTel.Text;
                        if (txtTel2.Text != "")
                        {
                            if (ValidarCampoString(txtTel2.Text, "Telefone(2)") == false)
                            {
                                txtTel2.Clear();
                                txtTel2.Focus();
                                return;
                            }
                            if (ValidarCampoTel(txtTel2.Text, "Telefone(2)") == false)
                            {
                                txtTel2.Clear();
                                txtTel2.Focus();
                                return;
                            }
                            dgvEscolas.Rows[i].Cells[4].Value = txtTel2.Text;
                        }
                        else
                        {
                            dgvEscolas.Rows[i].Cells[4].Value = "null";
                        }
                        if (ValidarCampoString(cboEst.Text, "Estado") == false)
                        {
                            cboEst.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[5].Value = cboEst.Text;
                        if (ValidarCampoString(txtCid.Text, "Cidade") == false)
                        {
                            txtCid.Clear();
                            txtCid.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[6].Value = txtCid.Text;
                        if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
                        {
                            txtBairro.Clear();
                            txtBairro.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[7].Value = txtBairro.Text;
                        if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
                        {
                            txtLogra.Clear();
                            txtLogra.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[8].Value = txtLogra.Text;
                        if (ValidarCampoNum(txtNum.Text, "Número") == false)
                        {
                            txtNum.Clear();
                            txtNum.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[9].Value = int.Parse(txtNum.Text);
                        if (ValidarCampoString(txtCep.Text, "CEP") == false)
                        {
                            txtCep.Clear();
                            txtCep.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[10].Value = txtCep.Text;
                        if (txtCompl.Text != "")
                        {
                            dgvEscolas.Rows[i].Cells[11].Value = txtCompl.Text;
                        }
                        else
                        {
                            dgvEscolas.Rows[i].Cells[11].Value = "null";
                        }
                        dgvEscolas.Rows[i].Cells[12].Value = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                    }

                }
            }
        }

        private void escolaCad_FormClosed(object sender, FormClosedEventArgs e)
        {
            int cont = dgvEscolas.RowCount;
            richTextBox1.Clear();
            for (int i = 0; i < cont; i++)
            {

                if (richTextBox1.Lines.Length == 0)
                {
                    string linha = dgvEscolas.Rows[i].Cells[0].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[1].Value.ToString() + "|" +
                         dgvEscolas.Rows[i].Cells[2].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvEscolas.Rows[i].Cells[4].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[5].Value.ToString() + "|" +
                        dgvEscolas.Rows[i].Cells[6].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[7].Value.ToString() + "|" +
                         dgvEscolas.Rows[i].Cells[8].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[9].Value.ToString() + "|" +
                        dgvEscolas.Rows[i].Cells[10].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[11].Value.ToString() + "|" +
                         dgvEscolas.Rows[i].Cells[12].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[13].Value.ToString();
                    richTextBox1.AppendText(linha);
                }
                else
                {
                    string linha = "\n" + dgvEscolas.Rows[i].Cells[0].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[1].Value.ToString() + "|" +
                         dgvEscolas.Rows[i].Cells[2].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvEscolas.Rows[i].Cells[4].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[5].Value.ToString() + "|" +
                        dgvEscolas.Rows[i].Cells[6].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[7].Value.ToString() + "|" +
                         dgvEscolas.Rows[i].Cells[8].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[9].Value.ToString() + "|" +
                        dgvEscolas.Rows[i].Cells[10].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[11].Value.ToString() + "|" +
                         dgvEscolas.Rows[i].Cells[12].Value.ToString() + "|" + dgvEscolas.Rows[i].Cells[13].Value.ToString();
                    richTextBox1.AppendText(linha);
                }
            }
            richTextBox1.SaveFile("escolas.dat");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvEscolas.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvEscolas.Rows[i].Cells.Count; a++)
                {
                    if (dgvEscolas.Rows[i].Selected == true || dgvEscolas.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvEscolas.Rows[i].Cells[1].Value.ToString();
                        txtCnpj.Text = dgvEscolas.Rows[i].Cells[2].Value.ToString();
                        txtTel.Text = dgvEscolas.Rows[i].Cells[3].Value.ToString();
                        txtTel2.Text = dgvEscolas.Rows[i].Cells[4].Value.ToString();
                        cboEst.Text = dgvEscolas.Rows[i].Cells[5].Value.ToString();
                        txtCid.Text = dgvEscolas.Rows[i].Cells[6].Value.ToString();
                        txtBairro.Text = dgvEscolas.Rows[i].Cells[7].Value.ToString();
                        txtLogra.Text = dgvEscolas.Rows[i].Cells[8].Value.ToString();
                        txtNum.Text = dgvEscolas.Rows[i].Cells[9].Value.ToString();
                        txtCep.Text = dgvEscolas.Rows[i].Cells[10].Value.ToString();
                        txtCompl.Text = dgvEscolas.Rows[i].Cells[11].Value.ToString();

                    }

                }
            }
        }
    }
}
