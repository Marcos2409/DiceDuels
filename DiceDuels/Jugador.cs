using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDuels
{
    public class Jugador
    {
        private int salud;

        public Jugador(int salud)
        {
            this.salud = salud;
        }

        public int Salud { get => salud; set => salud = value; }
    }
}
