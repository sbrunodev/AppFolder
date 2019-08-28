using System;
using System.Collections;
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
    public partial class PrimeiroAcess : Form
    {
        string Caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Acess.txt";
        int Status = 0;
        public string Nome { get; set; }
        public PrimeiroAcess(int pStatus=0)
        {
            InitializeComponent();
            Status = pStatus;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            String Caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            lblMsg.Text = "Aplicação FolderHide - Primeiro Acesso";
            if (ExisteArquivo() && pStatus == 0)            
                AbreLogin();
            else 
                if (pStatus == 1) { 
                    RecuperaInformacoes();
                    lblMsg.Text = "Aplicação FolderHide - Alterar Informações";
                    btnEntrar.Text = "Salvar";
                    this.Text = "Aplicação FolderHide";
                }
            
            lblResposta.Text = "";
        }

        public void RecuperaInformacoes()
        {
            StreamReader sr = new StreamReader(Caminho);
            try
            {
                ttbNome.Text = sr.ReadLine();
                ttbSenha.Text = sr.ReadLine();
            }
            catch
            {

            }

            sr.Close();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string Erro = "";
            if (ttbNome.Text.Equals("") || ttbSenha.Text.Equals(""))
                Erro += "Informe o campo nome e senha !!!";
            else
                if (!ttbSenha.Text.Equals(ttbConfirma.Text))
                    Erro += "As senhas informadas não conferem!!!";

            if (Erro.Equals(""))
            {
                Salvar();

            }
            else
                lblResposta.Text = Erro;
        }



        private bool ExisteArquivo()
        {
            if (!File.Exists(Caminho))
                return false;
            else
                return true;
        }


        public void Salvar()
        {
            StreamWriter writer = new StreamWriter(Caminho);
            writer.WriteLine(ttbNome.Text);
            writer.WriteLine(ttbSenha.Text);

            writer.Close();
            writer.Dispose();

            MessageBox.Show("Informações salvas com Sucesso!");

            AbreLogin();
        }

        public void AbreLogin()
        {
            if (Status == 0) { 
                this.Hide();
                frmSecurity frmS = new frmSecurity();
                frmS.ShowDialog();
            }
            else {
                Nome = ttbNome.Text; 
                this.Close();
            }




        }

        public void LeConexao(string caminho)
        {

            ArrayList arrayDados = new ArrayList();

            StreamReader sr = new StreamReader(caminho);

            while (!sr.EndOfStream)
            {
                arrayDados.Add(sr.ReadLine());
            }
            try
            {
                //clsConfigBanco.Construtor(arrayDados[0].ToString(), arrayDados[1].ToString(), arrayDados[2].ToString(), arrayDados[3].ToString(), arrayDados[4].ToString());
            }
            catch
            {
                MessageBox.Show("Por favor informe todas informações para conexão com o Banco");
            }

            sr.Close();

        }


    }
}
