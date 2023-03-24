﻿using System;
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

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
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
    }
}