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
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

            //Label do Frm_Cadastro Cliente
            Chk_TemPai.Text = "Pai Desconhecido";
            Grp_Codigo.Text = "Código";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros";
            Grp_Genero.Text = "Genero";
            Lbl_Bairro.Text = "Bairro";
            Lbl_Cidade.Text = "Cidade";
            Lbl_Estado.Text = "Estado";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Outros.Text = "Outros";
            Cmb_Estado.Items.Clear();//Limpar o campo
            //Add.Items = coleção
            Cmb_Estado.Items.Add("Acre (AC)");
            Cmb_Estado.Items.Add("Amazonas (AM)");
            Cmb_Estado.Items.Add("Minas Gerais (MG)");

            Tls_Pricipal.Items[0].ToolTipText = "Novo Usuário";
            Tls_Pricipal.Items[1].ToolTipText = "Buscar Usuário";
            Tls_Pricipal.Items[2].ToolTipText = "Atualizar dados alterado";
            Tls_Pricipal.Items[3].ToolTipText = "Excluir Usuário";
            Tls_Pricipal.Items[4].ToolTipText = "Limpar dados";
        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão novo usuário");
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Buscar");
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão salsar dados");
        }

        private void ApagatoolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão excluir usuário");
        }

        private void LimpartoolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão limpar dados");
        }
    }
}
