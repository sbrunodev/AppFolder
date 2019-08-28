using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFolder
{
    public partial class frmWindow : Form
    {
        DataTable dt = new DataTable();
        public frmWindow(string Nome)
        {
            InitializeComponent();
            lblMensagem.Text = "Aplicação FolderHide - "+Nome;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            

            this.Height = 401;
            dt.Columns.Add("Pasta");
            dgvDados.DataSource = dt.DefaultView;

            String Caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            Caminho = Caminho.Replace("AppFolder\\AppFolder\\bin\\Debug\\","");

            CarregaPastas(Caminho);
   
           
        }

        private void CarregaPastas(string Caminho)
        {
            dt.Rows.Clear();

            if(Caminho[Caminho.Length-1] != '\\'){
                Caminho += "\\";
             }

            ttbCaminho.Text = Caminho;
            string[] Diretorios = Directory.GetDirectories(Caminho);
            for (int i = 0; i < Diretorios.Length; i++)
            {
                dt.Rows.Add(Diretorios[i].Replace(Caminho, "").Replace("\\",""));
            }


        }

        // Lista todos os arquivos dos diretorios
        private void Listar(string Caminho)
        {
            string Arquivo = "";
            //DirectoryInfo Dir = new DirectoryInfo(@"D:\Pedro\Videos\Anime");
            DirectoryInfo Dir = new DirectoryInfo(@""+Caminho);
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo File in Files)
            {
                Arquivo += File.FullName+"\n";
            }
            MessageBox.Show(Arquivo);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBDialog = new FolderBrowserDialog();

            if (FBDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                CarregaPastas(FBDialog.SelectedPath);
            }

        }

        private void dgvDados_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null)
            {
                int Posicao = dgvDados.CurrentRow.Index;                
                string Pasta = dt.Rows[Posicao]["Pasta"].ToString();
                lblCaminho.Text = ttbCaminho.Text + "" + Pasta;
                this.Height = 467;

                //
                DirectoryInfo DirPasta = Directory.CreateDirectory(lblCaminho.Text);
                //DirPasta.Attributes = FileAttributes.Hidden;

                if ((DirPasta.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    lblStatus.Text = "Status: Visivel";
                    btnAcao.Text = "Esconder Pasta";
                }
                else { 
                    lblStatus.Text = "Status: Oculta";
                    btnAcao.Text = "Exibir Pasta";
                }
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.Height = 401;
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            DirectoryInfo DirPasta = Directory.CreateDirectory(lblCaminho.Text);
            if (lblStatus.Text.Equals("Status: Oculta"))
            {
                DirPasta.Attributes = FileAttributes.Normal;
                lblStatus.Text = "Status: Visivel";
                btnAcao.Text = "Esconder Pasta";
            }
            else
            { 
                DirPasta.Attributes = FileAttributes.Hidden;
                lblStatus.Text = "Status: Oculta";
                btnAcao.Text = "Exibir Pasta";
            }
        }

        private void frmWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            PrimeiroAcess frm = new PrimeiroAcess(1);
            frm.ShowDialog();
            lblMensagem.Text = "Aplicação FolderHide - " + frm.Nome;
        }

        private void btnNaoClique_Click(object sender, EventArgs e)
        {
            DialogResult DResult = MessageBox.Show("É melhor não continuar com essa Ação!\n Deseja realmente executar essa Função???", "FolderHide", MessageBoxButtons.YesNo);
            if (DResult == DialogResult.Yes) { 
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string Pasta = dt.Rows[i]["Pasta"].ToString();
                    string Caminho = ttbCaminho.Text + "" + Pasta;
                
                    Directory.Delete(Caminho, true);
                }
            }
            CarregaPastas(ttbCaminho.Text);
        }


    }
}
