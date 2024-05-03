using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDuels
{
    public class Enemigo
    {
        private int salud;

        public Enemigo(int salud)
        {
            this.salud = salud;
        }

        public int Salud { get => salud; set => salud = value; }
    }
}
