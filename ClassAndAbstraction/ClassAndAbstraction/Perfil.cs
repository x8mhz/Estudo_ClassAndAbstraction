using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndAbstraction
{
    class Perfil : PerfilAbstrato
    {
        private string nome;
        private string cpf;
        private string telefone;

        public string get_Nome()
        {
            return this.nome;
        }

        public void set_Nome(string nome)
        {
            this.nome = nome;
        }

        public string get_CPF()
        {
            return this.cpf;
        }

        public void set_CPF(string cpf)
        {
            this.cpf = cpf;
        }

        public string get_Telefone()
        {
            return this.telefone;
        }

        public void set_Telefone(string telefone)
        {
            this.telefone = telefone;
        }

        public override void mostrar()
        {
            MessageBox.Show(this.get_Nome() + '\n' + this.get_CPF() + '\n' + this.get_Telefone(),"Informação", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
