namespace Cadastro_de_alunos
{
    partial class profCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnExcluir2 = new System.Windows.Forms.Button();
            this.cboEst = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvProfs = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(266, 397);
            this.btnAlt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(100, 28);
            this.btnAlt.TabIndex = 16;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnExcluir2
            // 
            this.btnExcluir2.Location = new System.Drawing.Point(101, 433);
            this.btnExcluir2.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir2.Name = "btnExcluir2";
            this.btnExcluir2.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir2.TabIndex = 17;
            this.btnExcluir2.Text = "Excluir";
            this.btnExcluir2.UseVisualStyleBackColor = true;
            this.btnExcluir2.Click += new System.EventHandler(this.btnExcluir2_Click);
            // 
            // cboEst
            // 
            this.cboEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEst.FormattingEnabled = true;
            this.cboEst.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEst.Location = new System.Drawing.Point(229, 80);
            this.cboEst.Margin = new System.Windows.Forms.Padding(4);
            this.cboEst.Name = "cboEst";
            this.cboEst.Size = new System.Drawing.Size(185, 24);
            this.cboEst.TabIndex = 7;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(306, 299);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(108, 22);
            this.txtCep.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(308, 280);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 63;
            this.label14.Text = "CEP*:";
            // 
            // dgvProfs
            // 
            this.dgvProfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfs.Location = new System.Drawing.Point(452, 16);
            this.dgvProfs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProfs.Name = "dgvProfs";
            this.dgvProfs.Size = new System.Drawing.Size(566, 445);
            this.dgvProfs.TabIndex = 62;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(158, 397);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(1084, 208);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir(1)";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(50, 397);
            this.btnCad.Margin = new System.Windows.Forms.Padding(4);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(100, 28);
            this.btnCad.TabIndex = 14;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cboSexo.Location = new System.Drawing.Point(16, 134);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(185, 24);
            this.cboSexo.TabIndex = 2;
            // 
            // txtCompl
            // 
            this.txtCompl.Location = new System.Drawing.Point(229, 356);
            this.txtCompl.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(185, 22);
            this.txtCompl.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 336);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Complemento:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(229, 300);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(71, 22);
            this.txtNum.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 280);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Número*:";
            // 
            // txtLogra
            // 
            this.txtLogra.Location = new System.Drawing.Point(229, 239);
            this.txtLogra.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogra.Name = "txtLogra";
            this.txtLogra.Size = new System.Drawing.Size(185, 22);
            this.txtLogra.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 219);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "Logradouro*:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(229, 188);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(185, 22);
            this.txtBairro.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "Bairro*:";
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(229, 134);
            this.txtCid.Margin = new System.Windows.Forms.Padding(4);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(185, 22);
            this.txtCid.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "Cidade*:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 51;
            this.label13.Text = "Estado*:";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(16, 356);
            this.txtCel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(185, 22);
            this.txtCel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 336);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Celular*:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(16, 299);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 22);
            this.txtTel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Telefone*:";
            // 
            // txtDn
            // 
            this.txtDn.Location = new System.Drawing.Point(16, 239);
            this.txtDn.Margin = new System.Windows.Forms.Padding(4);
            this.txtDn.Name = "txtDn";
            this.txtDn.Size = new System.Drawing.Size(185, 22);
            this.txtDn.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Data de Nascimento*:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(16, 188);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(185, 22);
            this.txtCpf.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "CPF*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Sexo*:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 82);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cadastro de Professores";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1084, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 64;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(217, 433);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 99;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // profCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 480);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnExcluir2);
            this.Controls.Add(this.cboEst);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvProfs);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtCompl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLogra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "profCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.profCad_FormClosed);
            this.Load += new System.EventHandler(this.profCad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnExcluir2;
        private System.Windows.Forms.ComboBox cboEst;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvProfs;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLogra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnConsultar;
    }
}