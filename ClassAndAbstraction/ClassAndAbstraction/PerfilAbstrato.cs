using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndAbstraction
{
    public abstract class PerfilAbstrato
    {
        public abstract void mostrar();

        public void pegar()
        {
            mostrar();
        }
    }
}
