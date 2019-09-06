namespace SistemaAgenda
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fUNCIONARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPag2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNovoNome = new System.Windows.Forms.Label();
            this.btnAlterarNome = new System.Windows.Forms.Button();
            this.btnAlterarTel = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNovoTel = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fUNCIONARIOSToolStripMenuItem,
            this.tabPag2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fUNCIONARIOSToolStripMenuItem
            // 
            this.fUNCIONARIOSToolStripMenuItem.Name = "fUNCIONARIOSToolStripMenuItem";
            this.fUNCIONARIOSToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.fUNCIONARIOSToolStripMenuItem.Text = "FUNCIONARIOS";
            // 
            // tabPag2ToolStripMenuItem
            // 
            this.tabPag2ToolStripMenuItem.Name = "tabPag2ToolStripMenuItem";
            this.tabPag2ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.tabPag2ToolStripMenuItem.Text = "tabPag2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME";
            // 
            // txtTel
            // 
            this.txtTel.AutoSize = true;
            this.txtTel.Location = new System.Drawing.Point(234, 47);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(27, 13);
            this.txtTel.TabIndex = 2;
            this.txtTel.Text = "TEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOVO TEL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.AutoSize = true;
            this.txtNovoNome.Location = new System.Drawing.Point(20, 135);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(73, 13);
            this.txtNovoNome.TabIndex = 4;
            this.txtNovoNome.Text = "NOVO NOME";
            // 
            // btnAlterarNome
            // 
            this.btnAlterarNome.Location = new System.Drawing.Point(502, 119);
            this.btnAlterarNome.Name = "btnAlterarNome";
            this.btnAlterarNome.Size = new System.Drawing.Size(123, 23);
            this.btnAlterarNome.TabIndex = 5;
            this.btnAlterarNome.Text = "ALTERAR NOME";
            this.btnAlterarNome.UseVisualStyleBackColor = true;
            // 
            // btnAlterarTel
            // 
            this.btnAlterarTel.Location = new System.Drawing.Point(502, 148);
            this.btnAlterarTel.Name = "btnAlterarTel";
            this.btnAlterarTel.Size = new System.Drawing.Size(123, 23);
            this.btnAlterarTel.TabIndex = 6;
            this.btnAlterarTel.Text = "ALTERAR TEL";
            this.btnAlterarTel.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(375, 148);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(121, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(375, 119);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(121, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(375, 90);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(375, 61);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNovoTel
            // 
            this.txtNovoTel.Location = new System.Drawing.Point(237, 151);
            this.txtNovoTel.Name = "txtNovoTel";
            this.txtNovoTel.Size = new System.Drawing.Size(100, 20);
            this.txtNovoTel.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 194);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(481, 168);
            this.textBox5.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 374);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtNovoTel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterarTel);
            this.Controls.Add(this.btnAlterarNome);
            this.Controls.Add(this.txtNovoNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fUNCIONARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabPag2ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNovoNome;
        private System.Windows.Forms.Button btnAlterarNome;
        private System.Windows.Forms.Button btnAlterarTel;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtNovoTel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}