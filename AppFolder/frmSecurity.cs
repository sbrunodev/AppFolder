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

namespace AppFolder
{
    public partial class frmSecurity : Form
    {
        string Senha = "";
        string Nome = "";
        int Tentativa = 0;
        public frmSecurity()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lblResposta.Text = "";
            RecuperaInformacoes();

        }

        private void btnAcess_Click(object sender, EventArgs e)
        {
            if (ttbSenha.Text.Equals(Senha))
            {
                frmWindow frm = new frmWindow(Nome);
                this.Hide();
                frm.ShowDialog();
                //this.Close();
            }
            else
            {
                Tentativa++;

                if (Tentativa == 4)
                    Application.Exit();

                string[] Resposta = new string[7];
                Resposta[0] = "Senha Incorreta! :p";
                Resposta[1] = "Parece que você não sabe a senha, né?";
                Resposta[2] = "aff, vai tentando!!!";
                Resposta[3] = "Uma hora acerta!";
                Resposta[4] = "Por favor, Reinicie seu computador!";
                Resposta[5] = "Essa passou perto !!!";
                Resposta[6] = "Faltou o 'B' no final !!!";

                Random RNumber = new Random();
                lblResposta.Text = Resposta[RNumber.Next(0, 7)];                
            }
        }


        public void RecuperaInformacoes()
        {
            string Caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Acess.txt";
            StreamReader sr = new StreamReader(Caminho);
            try
            {
                Nome = sr.ReadLine();
                lblSaudacao.Text = "Olá "+Nome+", informe sua senha";
                Senha = sr.ReadLine();
            }
            catch
            {

            }

            sr.Close();

        }

        private void frmSecurity_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
