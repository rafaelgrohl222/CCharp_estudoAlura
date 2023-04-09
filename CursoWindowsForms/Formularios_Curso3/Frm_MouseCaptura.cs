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
    public partial class Frm_MouseCaptura : Form
    {
        public Frm_MouseCaptura()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            string str1 = e.Button.ToString();
            Btn_MouseCaptura.Text = str1;//botão recebe o que precionar
            MessageBox.Show("Foi precionado o botão da(o) " + str1);
        }
    }
}
