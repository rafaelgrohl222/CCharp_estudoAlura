using CursoWindowsForms.Formularios_Curso1_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        //Variaveis Globais
        int ControleHelloWorld = 0;
        int ControleDemostracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            menuPrincipalToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }
        private void demostraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemostracaoKey += 1;

            Frm_DemostracaoKey_UC u = new Frm_DemostracaoKey_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Demostração Key - " + ControleDemostracaoKey;//Name (nome interno) do TabPage
            TB.Text = "Demostração Key - " + ControleDemostracaoKey;//Nome Da aba
            TB.ImageIndex = 0;
            TB.Controls.Add(u);//adicionar (controles internos) meu TabPage dentro TabControl
            Tbc_Aplicacoes.TabPages.Add(TB);//adicionar Tbc_Aplicacoes dentro TabPage  

            //Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            //f.ShowDialog();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;

            Frm_HelloWorld_UC u = new Frm_HelloWorld_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Hello World - " + ControleHelloWorld;//Nome do TabPage
            TB.Text = "Hello World - " + ControleHelloWorld;//Nome Da aba
            TB.ImageIndex = 1;
            TB.Controls.Add(u);//adicionar meu TabPage dentro TabControl
            Tbc_Aplicacoes.TabPages.Add(TB);//adicionar Tbc_Aplicacoes dentro TabPage  

            //Frm_HelloWorld f = new Frm_HelloWorld();
            //f.ShowDialog();

        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;

            Frm_Mascara_UC u = new Frm_Mascara_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Mascara - " + ControleMascara;//Nome do TabPage
            TB.Text = "Mascara - " + ControleMascara;//Nome Da aba
            TB.ImageIndex = 2;
            TB.Controls.Add(u);//adicionar meu TabPage dentro TabControl
            Tbc_Aplicacoes.TabPages.Add(TB);//adicionar (Tbc_Aplicacoes nome TabControl) dentro TabPage  

            //Frm_Mascara f = new Frm_Mascara();
            //f.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;

            Frm_ValidaCPF_UC u = new Frm_ValidaCPF_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF - " + ControleValidaCPF;//Nome do TabPage
            TB.Text = "Valida CPF - " + ControleValidaCPF;//Nome Da aba
            TB.ImageIndex = 3;
            TB.Controls.Add(u);//adicionar meu TabPage dentro TabControl
            Tbc_Aplicacoes.TabPages.Add(TB);//adicionar (Tbc_Aplicacoes nome TabControl) dentro TabPage

            //Frm_ValidaCPF f = new Frm_ValidaCPF();
            //f.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;

            Frm_ValidaCPF2_UC u = new Frm_ValidaCPF2_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF 2 - " + ControleValidaCPF2;//Nome do TabPage
            TB.Text = "Valida CPF 2 - " + ControleValidaCPF2;//Nome Da aba
            TB.ImageIndex = 4;
            TB.Controls.Add(u);//adicionar meu TabPage dentro TabControl
            Tbc_Aplicacoes.TabPages.Add(TB);//adicionar (Tbc_Aplicacoes nome TabControl) dentro TabPage

            //Frm_ValidaCPF2 f = new Frm_ValidaCPF2();
            //f.ShowDialog();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;

            Frm_ValidaSenha_UC u = new Frm_ValidaSenha_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida Senha - " + ControleValidaSenha;//Nome do TabPage
            TB.Text = "Valida Senha - " + ControleValidaSenha;//Nome Da aba
            TB.ImageIndex = 5;
            TB.Controls.Add(u);//adicionar meu TabPage dentro TabControl
            Tbc_Aplicacoes.TabPages.Add(TB);//adicionar (Tbc_Aplicacoes nome TabControl) dentro TabPage

            //Frm_ValidaSenha f = new Frm_ValidaSenha();
            //f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Principal f = new Frm_Principal();
            f.ShowDialog();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
            else
            {
                MessageBox.Show("Não existe, Aba para apagar!...");
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "D:\\CCharp_Projetos\\CCharp_Alura\\CursoWindowsForms\\curso\\CursoWindowsForms\\Imagens";// Barra dupla tiro o erro do diretório
            Db.Filter = "PNG|*.PNG";//Filtro só ver um tipo de imagem
            Db.Title = "Escolha a imagem";//Titulo

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeAquivoImagem = Db.FileName;


                ControleArquivoImagem += 1;

                Frm_ArquivoImagem_UC u = new Frm_ArquivoImagem_UC(nomeAquivoImagem);
                u.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Arquivo Imagem - " + ControleArquivoImagem;//Nome do TabPage
                TB.Text = "Arquivo Imagem - " + ControleArquivoImagem;//Nome Da aba
                TB.ImageIndex = 6;
                TB.Controls.Add(u);//adicionar meu TabPage dentro TabControl
                Tbc_Aplicacoes.TabPages.Add(TB);//adicionar (Tbc_Aplicacoes nome TabControl) dentro TabPage
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login f = new Frm_Login();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string senha = f.senha;
                string login = f.login;

                if (CursoWindowsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    menuPrincipalToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + login + "! ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha inválida! ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao DB = new Frm_Questao("Frm_Question96x961", "Você deseja se desconectar?");
            DB.ShowDialog();
            //if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            if (DB.DialogResult == DialogResult.Yes)
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);

                //Count= contar
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i+=-1)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                menuPrincipalToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
            }
        }
    }
}
