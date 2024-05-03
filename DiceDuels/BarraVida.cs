using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDuels
{
    public class BarraVida
    {

       

        public static void ProcesarDado(Dado dado, ProgressBar progressBar, int vidaMaxJugador)
        {
            int valorDado = dado.Resultado;

            if (progressBar.Tag != null && progressBar.Tag.ToString() == "enemigo")
            {
                if (progressBar.Value - valorDado >= 0)
                {
                    progressBar.Value -= valorDado;
                }
                else
                {
                    progressBar.Value = 0;
                }
            }
            else
            {
                if(progressBar.Value + valorDado <= vidaMaxJugador)
                {
                    progressBar.Value += valorDado;
                }
                else
                {
                    progressBar.Value = vidaMaxJugador;
                }
            }
        }
    }

}
