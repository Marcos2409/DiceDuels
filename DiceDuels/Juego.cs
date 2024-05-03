using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDuels
{
    public class Juego
    {
        private Jugador jugador;
        private Enemigo enemigo;
        private List<Dado> dados;
        public Juego()
        {
            jugador = new Jugador(42);
            enemigo = new Enemigo(30);
            dados = new List<Dado>();
            for (int i = 0; i < 3; i++)
            {
                dados.Add(new Dado());
            }
        }

        
        public void ActualizarTurno(ProgressBar vidaJugador, int vida, Dado dado1)
        {
            dado1.UpdateDado();

            Random rd = new Random();

            int ataqueEnemigo = rd.Next(1, 9);
            
            if( vidaJugador.Value- ataqueEnemigo > 0 )
            {
                vidaJugador.Value -= rd.Next(1, 9);
            }
            else
            {
                vidaJugador.Value = 0;
            }
            JuegoTerminado(vidaJugador);



        }
        //public void TurnoJugador()
        //{
            
        //}

        //public void TurnoEnemigo()
        //{
            
        //}

        public bool JuegoTerminado(ProgressBar vidaJugador)
        {
            if (vidaJugador.Value == 0)
            {
                MessageBox.Show("HAS PERDIDO", "¡Lo siento!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
