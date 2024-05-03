namespace DiceDuels
{
    public partial class Form1 : Form
    {
        private Juego juego = new Juego();
        private Dado dado = new Dado();
        private Jugador jugador = new Jugador(42);
        private Enemigo enemigo = new Enemigo(20);
        private bool turnoJugador = true;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            vidaEnemigo.AllowDrop = true;

            juego = new Juego();
            dado = new Dado();
            dado.Resultado = dado.TirarDado();
            vidaJugador.Maximum = jugador.Salud;
            vidaEnemigo.Maximum = enemigo.Salud;
            vidaJugador.Value = vidaJugador.Maximum;
            vidaEnemigo.Value = vidaEnemigo.Maximum;
            vidaEnemigo.DragDrop += vidaEnemigo_DragDrop;
            vidaEnemigo.DragEnter += vidaEnemigo_DragEnter;
            vidaEnemigo.DragOver += vidaEnemigo_DragOver;
            pictureBox1.DragDrop += pictureBox1_DragDrop;
        }


        private bool isDragging = false;
        private Point startPoint;
        private void moverUpAtaque(PictureBox caja, ProgressBar vidaEnemigo, MouseEventArgs e, int ubiX, Dado dado1)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                if (pictureBox1.Bounds.IntersectsWith(vidaEnemigo.Bounds))
                {
                    if (vidaEnemigo.Tag == "enemigo")
                    {
                        if (vidaEnemigo.Value - Convert.ToInt32(dado1.Resultado) >= 0)
                        {
                            vidaEnemigo.Value -= Convert.ToInt32(dado1.Resultado);
                        }
                        else
                        {
                            vidaEnemigo.Value = 0;
                           
                        }

                    }
                    else
                    {
                        vidaEnemigo.Value += dado1.Resultado;

                    }
                    pictureBox1.Location = new Point(ubiX, 300);
                    
                }
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                pictureBox1.Left += e.X - startPoint.X;
                pictureBox1.Top += e.Y - startPoint.Y;
            }
        }
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                int valorDado = dado.Resultado;

                if (vidaEnemigo.Value - valorDado > 0)
                {
                    vidaEnemigo.Value -= valorDado;
                }
                else
                {
                    vidaEnemigo.Value = 0;
                }

                juego.ActualizarTurno(vidaJugador, jugador.Salud, dado);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {                   
            moverUpAtaque(pictureBox1, vidaEnemigo, e, 400, dado);
            moverUpAtaque(pictureBox1, vidaJugador, e, 400, dado);

        }

        private void vidaEnemigo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void vidaEnemigo_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                int valorDado = dado.TirarDado();

                if (vidaEnemigo.Value - valorDado > 0)
                {
                    vidaEnemigo.Value -= valorDado;
                }
                else
                {
                    vidaEnemigo.Value = 0;
                }

                //MessageBox.Show($"Valor del dado: {valorDado}", "Dado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                juego.ActualizarTurno(vidaJugador, jugador.Salud, dado);
            }
        }


        private void vidaEnemigo_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool terminar = false;
            int resultado = dado.TirarDado();

            pictureBox1.Image = dado.ObtenerImagenDado(resultado);


            turnoJugador = !turnoJugador;
            juego.ActualizarTurno(vidaJugador, jugador.Salud, dado);
            if (juego.JuegoTerminado(vidaJugador))
            {
                this.Close();
            }
        }

    }
}
