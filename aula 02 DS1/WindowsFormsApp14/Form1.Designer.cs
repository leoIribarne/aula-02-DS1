namespace WindowsFormsApp14
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.contratos = new System.Windows.Forms.GroupBox();
            this.btnestagio = new System.Windows.Forms.RadioButton();
            this.btnefetivo = new System.Windows.Forms.RadioButton();
            this.habilidade = new System.Windows.Forms.GroupBox();
            this.java = new System.Windows.Forms.CheckBox();
            this.pyton = new System.Windows.Forms.CheckBox();
            this.typescript = new System.Windows.Forms.CheckBox();
            this.php = new System.Windows.Forms.CheckBox();
            this.csharp = new System.Windows.Forms.CheckBox();
            this.sql = new System.Windows.Forms.CheckBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.contratos.SuspendLayout();
            this.habilidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(55, 46);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(33, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "nome";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(94, 43);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(164, 20);
            this.txtnome.TabIndex = 1;
            // 
            // contratos
            // 
            this.contratos.Controls.Add(this.btnefetivo);
            this.contratos.Controls.Add(this.btnestagio);
            this.contratos.Location = new System.Drawing.Point(58, 111);
            this.contratos.Name = "contratos";
            this.contratos.Size = new System.Drawing.Size(200, 63);
            this.contratos.TabIndex = 2;
            this.contratos.TabStop = false;
            this.contratos.Text = "Tipo de Contrato";
            this.contratos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnestagio
            // 
            this.btnestagio.AutoSize = true;
            this.btnestagio.Location = new System.Drawing.Point(6, 37);
            this.btnestagio.Name = "btnestagio";
            this.btnestagio.Size = new System.Drawing.Size(60, 17);
            this.btnestagio.TabIndex = 0;
            this.btnestagio.TabStop = true;
            this.btnestagio.Text = "Estagio";
            this.btnestagio.UseVisualStyleBackColor = true;
            this.btnestagio.CheckedChanged += new System.EventHandler(this.btnefetivo_CheckedChanged);
            // 
            // btnefetivo
            // 
            this.btnefetivo.AutoSize = true;
            this.btnefetivo.Location = new System.Drawing.Point(109, 37);
            this.btnefetivo.Name = "btnefetivo";
            this.btnefetivo.Size = new System.Drawing.Size(58, 17);
            this.btnefetivo.TabIndex = 1;
            this.btnefetivo.TabStop = true;
            this.btnefetivo.Text = "Efetivo";
            this.btnefetivo.UseVisualStyleBackColor = true;
            this.btnefetivo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // habilidade
            // 
            this.habilidade.Controls.Add(this.sql);
            this.habilidade.Controls.Add(this.csharp);
            this.habilidade.Controls.Add(this.php);
            this.habilidade.Controls.Add(this.typescript);
            this.habilidade.Controls.Add(this.pyton);
            this.habilidade.Controls.Add(this.java);
            this.habilidade.Location = new System.Drawing.Point(511, 96);
            this.habilidade.Name = "habilidade";
            this.habilidade.Size = new System.Drawing.Size(200, 164);
            this.habilidade.TabIndex = 3;
            this.habilidade.TabStop = false;
            this.habilidade.Text = "Tipo de Contrato";
            this.habilidade.Enter += new System.EventHandler(this.habilidade_Enter);
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.Location = new System.Drawing.Point(16, 37);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(49, 17);
            this.java.TabIndex = 0;
            this.java.Text = "Java";
            this.java.UseVisualStyleBackColor = true;
            this.java.CheckedChanged += new System.EventHandler(this.java_CheckedChanged);
            // 
            // pyton
            // 
            this.pyton.AutoSize = true;
            this.pyton.Location = new System.Drawing.Point(114, 38);
            this.pyton.Name = "pyton";
            this.pyton.Size = new System.Drawing.Size(58, 17);
            this.pyton.TabIndex = 1;
            this.pyton.Text = "python";
            this.pyton.UseVisualStyleBackColor = true;
            // 
            // typescript
            // 
            this.typescript.AutoSize = true;
            this.typescript.Location = new System.Drawing.Point(16, 83);
            this.typescript.Name = "typescript";
            this.typescript.Size = new System.Drawing.Size(75, 17);
            this.typescript.TabIndex = 2;
            this.typescript.Text = "Typescript";
            this.typescript.UseVisualStyleBackColor = true;
            this.typescript.CheckedChanged += new System.EventHandler(this.typescript_CheckedChanged);
            // 
            // php
            // 
            this.php.AutoSize = true;
            this.php.Location = new System.Drawing.Point(16, 132);
            this.php.Name = "php";
            this.php.Size = new System.Drawing.Size(45, 17);
            this.php.TabIndex = 3;
            this.php.Text = "Php";
            this.php.UseVisualStyleBackColor = true;
            // 
            // csharp
            // 
            this.csharp.AutoSize = true;
            this.csharp.Location = new System.Drawing.Point(114, 83);
            this.csharp.Name = "csharp";
            this.csharp.Size = new System.Drawing.Size(39, 17);
            this.csharp.TabIndex = 4;
            this.csharp.Text = "c#";
            this.csharp.UseVisualStyleBackColor = true;
            // 
            // sql
            // 
            this.sql.AutoSize = true;
            this.sql.Location = new System.Drawing.Point(114, 132);
            this.sql.Name = "sql";
            this.sql.Size = new System.Drawing.Size(47, 17);
            this.sql.TabIndex = 5;
            this.sql.Text = "SQL";
            this.sql.UseVisualStyleBackColor = true;
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(58, 202);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(200, 49);
            this.cadastrar.TabIndex = 4;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // registro
            // 
            this.registro.Location = new System.Drawing.Point(58, 283);
            this.registro.Multiline = true;
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(647, 155);
            this.registro.TabIndex = 5;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(274, 202);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(198, 49);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.habilidade);
            this.Controls.Add(this.contratos);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.Text = "aula2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contratos.ResumeLayout(false);
            this.contratos.PerformLayout();
            this.habilidade.ResumeLayout(false);
            this.habilidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.GroupBox contratos;
        private System.Windows.Forms.RadioButton btnefetivo;
        private System.Windows.Forms.RadioButton btnestagio;
        private System.Windows.Forms.GroupBox habilidade;
        private System.Windows.Forms.CheckBox sql;
        private System.Windows.Forms.CheckBox csharp;
        private System.Windows.Forms.CheckBox php;
        private System.Windows.Forms.CheckBox typescript;
        private System.Windows.Forms.CheckBox pyton;
        private System.Windows.Forms.CheckBox java;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TextBox registro;
        private System.Windows.Forms.Button btn_limpar;
    }
}

