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
    public partial class registrarTurma : Form
    {
        public registrarTurma()
        {
            InitializeComponent();
        }
        List<Turma> turmas = new List<Turma>();
        List<Aula> aulas = new List<Aula>();
        List<Vaga> vagas = new List<Vaga>();
        float idTurma;

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

        private void carregarRich()
        {
            try
            {
                rtxtAlunos.LoadFile("alunos.dat");
            }
            catch
            {

            }
            try
            {
                rtxtPeriodos.LoadFile("periodos.dat");
            }
            catch
            {

            }
            try
            {
                rtxtMaterias.LoadFile("materias.dat");
            }
            catch
            {

            }
            try
            {
                rtxtEscolas.LoadFile("escolas.dat");
            }
            catch
            {

            }
            try
            {
                rtxtProfessores.LoadFile("professores.dat");
            }
            catch
            {

            }
            try
            {
                rtxtTurmas.LoadFile("turmas.dat");
            }
            catch
            {

            }
            try
            {
                rtxtAulas.LoadFile("aulas.dat");
            }
            catch
            {

            }
            try
            {
                rtxtVagas.LoadFile("vagas.dat");
            }
            catch
            {

            }
        }

        private void registrarTurma_Load(object sender, EventArgs e)
        {
            carregarRich();
            cboPeriodo.Items.Clear();
            string[] linhas = rtxtPeriodos.Lines;
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] campo = linhas[i].Split('|');
                cboPeriodo.Items.Add(campo[1]);
            }
            cboMateria.Items.Clear();
            string[] linhas1 = rtxtMaterias.Lines;
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] campo = linhas1[i].Split('|');
                cboMateria.Items.Add(campo[1]);
            }
            try
            {
                rtxtTurmas.LoadFile("turmas.dat");
                for (int i = 0; i < rtxtTurmas.Lines.Length; i++)
                {
                    string[] linha = rtxtTurmas.Lines[i].Split('|');
                    Turma turma = new Turma();
                    turma.id = int.Parse(linha[0]);
                    turma.idEscola = int.Parse(linha[1]);
                    turma.nome = linha[2];
                    turma.ano = int.Parse(linha[3]);
                    turma.periodo = linha[4];
                    turma.dtAlt = linha[5];
                    turma.ativo = int.Parse(linha[6]);
                    turmas.Add(turma);
                    dgvAlunos.DataSource = turmas.ToList();
                }

            }
            catch
            {

            }
        }

        private void txtIdAluno_TextChanged(object sender, EventArgs e)
        {
            cboAluno.Items.Clear();
            string[] linhas = rtxtAlunos.Lines;
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] campo = linhas[i].Split('|');
                if (txtIdAluno.Text == campo[0])
                {
                    cboAluno.Items.Add(campo[1]);
                }
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();

            turma.id = dgvAlunos.RowCount;
            string[] linhas = rtxtEscolas.Lines;
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] campo = linhas[i].Split('|');
                if(txtIdEscola.Text == campo[0] && cboEscola.Text == campo[1])
                {
                    turma.idEscola = int.Parse(txtIdEscola.Text);
                }
            }
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            turma.nome = txtNome.Text;
            if (ValidarCampoNum(txtAno.Text, "Ano") == false)
            {
                txtAno.Clear();
                txtAno.Focus();
                return;
            }
            turma.ano = int.Parse(txtAno.Text);
            if (ValidarCampoString(cboPeriodo.Text, "Período") == false)
            {
                cboPeriodo.Focus();
                return;
            }
            turma.periodo = cboPeriodo.Text ;
            turma.dtAlt = "0";
            turma.ativo = 1;
            turmas.Add(turma);
            dgvAlunos.DataSource = turmas.ToList();
            //Salvando no Banco (Rich)
            int cont = dgvAlunos.RowCount;
            rtxtTurmas.Clear();
            for (int i = 0; i < cont; i++)
            {

                if (rtxtTurmas.Lines.Length == 0)
                {
                    string linha = dgvAlunos.Rows[i].Cells[0].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[1].Value.ToString() + "|" +
                         dgvAlunos.Rows[i].Cells[2].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[4].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[5].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[6].Value.ToString();
                    rtxtTurmas.AppendText(linha);
                }
                else
                {
                    string linha = "\n" + dgvAlunos.Rows[i].Cells[0].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[1].Value.ToString() + "|" +
                         dgvAlunos.Rows[i].Cells[2].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[3].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[4].Value.ToString() + "|" + dgvAlunos.Rows[i].Cells[5].Value.ToString() + "|" +
                        dgvAlunos.Rows[i].Cells[6].Value.ToString();
                    rtxtTurmas.AppendText(linha);
                }
            }
            rtxtTurmas.SaveFile("turmas.dat");
            //Salvo no Banco!
            //Salvar Aulas no Banco(Rich)
            if (dataGridView1 != null)
            {
                int cont1 = dataGridView1.RowCount;
                for (int i = 0; i < cont1; i++)
                {

                    if (rtxtAulas.Lines.Length == 0)
                    {
                        string linha = rtxtAulas.Lines.Length + "|" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "|" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "|" +
                             dataGridView1.Rows[i].Cells[2].Value.ToString() + "|" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "|" +
                            dataGridView1.Rows[i].Cells[4].Value.ToString() + "|" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "|" +
                            dataGridView1.Rows[i].Cells[6].Value.ToString() + "|" + dataGridView1.Rows[i].Cells[7].Value.ToString();
                        rtxtAulas.AppendText(linha);
                    }
                    else
                    {
                        string linha = "\n" + rtxtAulas.Lines.Length + "|" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "|" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "|" +
                             dataGridView1.Rows[i].Cells[2].Value.ToString() + "|" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "|" +
                            dataGridView1.Rows[i].Cells[4].Value.ToString() + "|" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "|" +
                            dataGridView1.Rows[i].Cells[6].Value.ToString() + "|" + dataGridView1.Rows[i].Cells[7].Value.ToString();
                        rtxtAulas.AppendText(linha);
                    }
                }
                rtxtAulas.SaveFile("aulas.dat");
            }
            //Salvo no Banco!
            //Salvar Vagas no Banco(Rich)
            if(dataGridView2 != null)
            {
                int cont2 = dataGridView2.RowCount;
                for (int i = 0; i < cont2; i++)
                {

                    if (rtxtVagas.Lines.Length == 0)
                    {
                        string linha = rtxtVagas.Lines.Length + "|" + dataGridView2.Rows[i].Cells[0].Value.ToString() + "|" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "|" +
                             dataGridView2.Rows[i].Cells[2].Value.ToString() + "|" + dataGridView2.Rows[i].Cells[3].Value.ToString() + "|" +
                            dataGridView2.Rows[i].Cells[4].Value.ToString() + "|" + dataGridView2.Rows[i].Cells[5].Value.ToString() + "|" +
                            dataGridView2.Rows[i].Cells[6].Value.ToString();
                        rtxtVagas.AppendText(linha);
                    }
                    else
                    {
                        string linha = "\n" + rtxtVagas.Lines.Length + "|" + dataGridView2.Rows[i].Cells[0].Value.ToString() + "|" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "|" +
                             dataGridView2.Rows[i].Cells[2].Value.ToString() + "|" + dataGridView2.Rows[i].Cells[3].Value.ToString() + "|" +
                            dataGridView2.Rows[i].Cells[4].Value.ToString() + "|" + dataGridView2.Rows[i].Cells[5].Value.ToString() + "|" +
                            dataGridView2.Rows[i].Cells[6].Value.ToString();
                        rtxtVagas.AppendText(linha);
                    }
                }
                rtxtVagas.SaveFile("vagas.dat");
            }
        }

        private void btnAddProf_Click(object sender, EventArgs e)
        {
            Aula aula = new Aula();
            aula.id = dataGridView1.RowCount;
            aula.idTurma = dgvAlunos.RowCount;
            if (ValidarCampoNum(txtIdProf.Text, "Id do Professor") == false)
            {
                txtIdProf.Clear();
                txtIdProf.Focus();
                return;
            }
            aula.idProf = int.Parse(txtIdProf.Text);
            if (ValidarCampoString(cboProf.Text, "Professor") == false)
            {
                cboProf.Focus();
                return;
            }
            aula.professor = cboProf.Text;
            if (ValidarCampoString(cboMateria.Text, "Matéria") == false)
            {
                cboMateria.Focus();
                return;
            }
            aula.materia = cboMateria.Text;
            if (ValidarCampoNum(txtAno.Text, "Ano") == false)
            {
                txtAno.Clear();
                txtAno.Focus();
                return;
            }
            aula.ano = int.Parse(txtAno.Text);
            aula.dtAlt = "0";
            aula.ativo = 1;
            aulas.Add(aula);
            dataGridView1.DataSource = aulas.ToList();
        }

        private void txtIdEscola_TextChanged(object sender, EventArgs e)
        {
            cboEscola.Items.Clear();
            string[] linhas = rtxtEscolas.Lines;
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] campo = linhas[i].Split('|');
                if (txtIdEscola.Text == campo[0])
                {
                    cboEscola.Items.Add(campo[1]);
                }
            }
        }

        private void txtIdProf_TextChanged(object sender, EventArgs e)
        {
            cboProf.Items.Clear();
            string[] linhas = rtxtProfessores.Lines;
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] campo = linhas[i].Split('|');
                if (txtIdProf.Text == campo[0])
                {
                    cboProf.Items.Add(campo[1]);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            Vaga vaga = new Vaga();
            vaga.id = dataGridView2.RowCount;
            vaga.idTurma = dgvAlunos.RowCount;
            if (ValidarCampoNum(txtIdAluno.Text, "Id do Aluno") == false)
            {
                txtIdAluno.Clear();
                txtIdAluno.Focus();
                return;
            }
            vaga.idAluno = int.Parse(txtIdAluno.Text);
            if (ValidarCampoString(cboAluno.Text, "Id do Aluno") == false)
            {
                cboAluno.ResetText();
                cboAluno.Focus();
                return;
            }
            vaga.aluno = cboAluno.Text;
            if (ValidarCampoNum(txtAno.Text, "Ano") == false)
            {
                txtAno.Clear();
                txtAno.Focus();
                return;
            }
            vaga.ano = int.Parse(txtAno.Text);
            vaga.dtAlt = "0";
            vaga.ativo = 1;
            vagas.Add(vaga);
            dataGridView2.DataSource = vagas.ToList();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            vagas.Clear();
            aulas.Clear();
            idTurma = 0.3f;
            int cont = dgvAlunos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvAlunos.Rows[i].Cells.Count; a++)
                {
                    if (dgvAlunos.Rows[i].Selected == true || dgvAlunos.Rows[i].Cells[a].Selected == true)
                    {
                        idTurma = int.Parse(dgvAlunos.Rows[i].Cells[0].Value.ToString());
                        txtIdEscola.Text = dgvAlunos.Rows[i].Cells[1].Value.ToString();
                        for(int l = 0; l < rtxtEscolas.Lines.Length; l++)
                        {
                            string[] linhas = rtxtEscolas.Lines[l].Split('|');
                            if(linhas[0] == dgvAlunos.Rows[i].Cells[1].Value.ToString())
                            {
                                cboEscola.Text = linhas[1].ToString();
                            }
                        }
                        txtNome.Text = dgvAlunos.Rows[i].Cells[2].Value.ToString();
                        txtAno.Text = dgvAlunos.Rows[i].Cells[3].Value.ToString();
                        cboPeriodo.Text = dgvAlunos.Rows[i].Cells[4].Value.ToString();
                    }

                }
            }
            for(int i = 0; i < rtxtAulas.Lines.Length; i++)
            {
                string[] linha = rtxtAulas.Lines[i].Split('|');
                if(int.Parse(linha[2]) == idTurma)
                {
                    Aula aula = new Aula();
                    aula.id = int.Parse(linha[1]);
                    aula.idTurma = int.Parse(linha[2]);
                    aula.idProf = int.Parse(linha[3]);
                    aula.professor = linha[4];
                    aula.materia = linha[5];
                    aula.ano = int.Parse(linha[6]);
                    aula.dtAlt = linha[7];
                    aula.ativo = int.Parse(linha[8]);
                    aulas.Add(aula);
                    dataGridView1.DataSource = aulas.ToList();
                }
            }
            for (int i = 0; i < rtxtVagas.Lines.Length; i++)
            {
                string[] linha = rtxtVagas.Lines[i].Split('|');
                if (int.Parse(linha[2]) == idTurma)
                {
                    Vaga vaga = new Vaga();
                    vaga.id = int.Parse(linha[1]);
                    vaga.idTurma = int.Parse(linha[2]);
                    vaga.idAluno = int.Parse(linha[3]);
                    vaga.aluno = linha[4];
                    vaga.ano = int.Parse(linha[5]);
                    vaga.dtAlt = linha[6];
                    vaga.ativo = int.Parse(linha[7]);
                    vagas.Add(vaga);
                    dataGridView2.DataSource = vagas.ToList();
                }
            }
        }
    }
}
