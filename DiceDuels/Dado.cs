using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDuels
{
    public class Dado
    {

        private Random random;
        private int resultado;

        public int Resultado { get => resultado; set => resultado = value; }

        public Dado ()
        {
            random = new Random();
            resultado = TirarDado();
        }


        public int TirarDado()
        {
            return random.Next(1, 7);
        }

        public void UpdateDado()
        {
            Resultado = TirarDado();
        }

        public Image ObtenerImagenDado(int numeroDado)
        {
            Bitmap bitmap = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                g.DrawString(numeroDado.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(20, 20));
            }
            return bitmap;
        }

        internal void DoDragDrop(Dado dado1, DragDropEffects move)
        {
            throw new NotImplementedException();
        }
    }
}
