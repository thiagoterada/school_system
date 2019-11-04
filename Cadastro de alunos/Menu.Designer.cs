namespace Cadastro_de_alunos
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Aluno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Escola = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Materia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Periodo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Professor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda_ResetCad = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuAjuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1124, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro_Aluno,
            this.menuCadastro_Escola,
            this.menuCadastro_Materia,
            this.menuCadastro_Periodo,
            this.menuCadastro_Professor,
            this.turmaToolStripMenuItem});
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(86, 24);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuCadastro_Aluno
            // 
            this.menuCadastro_Aluno.Name = "menuCadastro_Aluno";
            this.menuCadastro_Aluno.Size = new System.Drawing.Size(216, 26);
            this.menuCadastro_Aluno.Text = "Aluno";
            this.menuCadastro_Aluno.Click += new System.EventHandler(this.menuCadastro_Aluno_Click);
            // 
            // menuCadastro_Escola
            // 
            this.menuCadastro_Escola.Name = "menuCadastro_Escola";
            this.menuCadastro_Escola.Size = new System.Drawing.Size(216, 26);
            this.menuCadastro_Escola.Text = "Escola";
            this.menuCadastro_Escola.Click += new System.EventHandler(this.menuCadastro_Escola_Click);
            // 
            // menuCadastro_Materia
            // 
            this.menuCadastro_Materia.Name = "menuCadastro_Materia";
            this.menuCadastro_Materia.Size = new System.Drawing.Size(216, 26);
            this.menuCadastro_Materia.Text = "Matéria";
            this.menuCadastro_Materia.Click += new System.EventHandler(this.menuCadastro_Materia_Click);
            // 
            // menuCadastro_Periodo
            // 
            this.menuCadastro_Periodo.Name = "menuCadastro_Periodo";
            this.menuCadastro_Periodo.Size = new System.Drawing.Size(216, 26);
            this.menuCadastro_Periodo.Text = "Período";
            this.menuCadastro_Periodo.Click += new System.EventHandler(this.menuCadastro_Periodo_Click);
            // 
            // menuCadastro_Professor
            // 
            this.menuCadastro_Professor.Name = "menuCadastro_Professor";
            this.menuCadastro_Professor.Size = new System.Drawing.Size(216, 26);
            this.menuCadastro_Professor.Text = "Professor";
            this.menuCadastro_Professor.Click += new System.EventHandler(this.menuCadastro_Professor_Click);
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAjuda_ResetCad,
            this.sairToolStripMenuItem});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(60, 24);
            this.menuAjuda.Text = "Ajuda";
            // 
            // menuAjuda_ResetCad
            // 
            this.menuAjuda_ResetCad.Name = "menuAjuda_ResetCad";
            this.menuAjuda_ResetCad.Size = new System.Drawing.Size(202, 26);
            this.menuAjuda_ResetCad.Text = "Resetar Cadastros";
            this.menuAjuda_ResetCad.Click += new System.EventHandler(this.menuAjuda_ResetCad_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1133, 139);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(20, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1124, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(370, 20);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "            ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(370, 20);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "                                ";
            this.toolStripStatusLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(370, 20);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "                                     ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.turmaToolStripMenuItem.Text = "Turma";
            this.turmaToolStripMenuItem.Click += new System.EventHandler(this.turmaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1124, 455);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Aluno;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Escola;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Materia;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Periodo;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Professor;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda_ResetCad;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
    }
}