

namespace DiceDuels
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            vidaJugador = new ProgressBar();
            vidaEnemigo = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(504, 315);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.DragDrop += pictureBox1_DragDrop;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // button1
            // 
            button1.Location = new Point(769, 342);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // vidaJugador
            // 
            vidaJugador.Location = new Point(141, 431);
            vidaJugador.Name = "vidaJugador";
            vidaJugador.Size = new Size(246, 44);
            vidaJugador.TabIndex = 4;
            // 
            // vidaEnemigo
            // 
            vidaEnemigo.Location = new Point(785, 111);
            vidaEnemigo.Name = "vidaEnemigo";
            vidaEnemigo.Size = new Size(246, 44);
            vidaEnemigo.TabIndex = 5;
            vidaEnemigo.Tag = "enemigo";
            vidaEnemigo.DragDrop += vidaEnemigo_DragDrop;
            vidaEnemigo.DragEnter += vidaEnemigo_DragEnter;
            vidaEnemigo.DragOver += vidaEnemigo_DragOver;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 679);
            Controls.Add(pictureBox1);
            Controls.Add(vidaJugador);
            Controls.Add(button1);
            Controls.Add(vidaEnemigo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private ProgressBar vidaJugador;
        private ProgressBar vidaEnemigo;
    }
}
