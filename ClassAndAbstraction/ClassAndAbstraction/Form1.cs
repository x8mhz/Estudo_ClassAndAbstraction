using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndAbstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            btn_Salvar.Parent = pictureBox1;
            btn_Sair.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Perfil p1 = new Perfil();

            p1.set_Nome(txt_Nome.Text);
            p1.set_CPF(txt_CPF.Text);
            p1.set_Telefone(txt_Telefone.Text);

            p1.pegar();

            this.txt_Nome.Clear();
            this.txt_CPF.Clear();
            this.txt_Telefone.Clear();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
