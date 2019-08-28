namespace AppFolder
{
    partial class frmSecurity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurity));
            this.btnAcess = new System.Windows.Forms.Button();
            this.ttbSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcess
            // 
            this.btnAcess.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcess.Location = new System.Drawing.Point(337, 76);
            this.btnAcess.Name = "btnAcess";
            this.btnAcess.Size = new System.Drawing.Size(115, 27);
            this.btnAcess.TabIndex = 5;
            this.btnAcess.Text = "Acessar";
            this.btnAcess.UseVisualStyleBackColor = true;
            this.btnAcess.Click += new System.EventHandler(this.btnAcess_Click);
            // 
            // ttbSenha
            // 
            this.ttbSenha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbSenha.Location = new System.Drawing.Point(16, 76);
            this.ttbSenha.Name = "ttbSenha";
            this.ttbSenha.PasswordChar = ' ';
            this.ttbSenha.Size = new System.Drawing.Size(315, 27);
            this.ttbSenha.TabIndex = 4;
            this.ttbSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aplicação FolderHide";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.Red;
            this.lblResposta.Location = new System.Drawing.Point(15, 116);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(148, 20);
            this.lblResposta.TabIndex = 7;
            this.lblResposta.Text = "Aplicação FolderHide";
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudacao.Location = new System.Drawing.Point(15, 48);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(39, 25);
            this.lblSaudacao.TabIndex = 8;
            this.lblSaudacao.Text = "Olá";
            // 
            // frmSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 165);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAcess);
            this.Controls.Add(this.ttbSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSecurity";
            this.Text = "Área de Acesso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSecurity_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcess;
        private System.Windows.Forms.TextBox ttbSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblSaudacao;
    }
}