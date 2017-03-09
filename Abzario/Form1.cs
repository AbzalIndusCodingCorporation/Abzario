using Abzario.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abzario {
    public partial class Form1 : Form {
        
        Sprite abzal;
        const int PIXEL = 4;
        const int spwnX = 4;
        const int spwnY = 300;
        Timer timer = new Timer();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.AllowTransparency = true;
            //this.TransparencyKey = this.BackColor;
            //this.TransparencyKey = canvas.BackColor;
            DoubleBuffered = true;

            timer.Interval = 1000;
            timer.Tick += OnTimer;
            timer.Start();

            // создаем спрайт
            abzal = new Sprite(ScaleUp(new Bitmap("img/abzarioIdle.png"), 4),
                                       new Vector2(spwnX, spwnY),
                                       64,
                                       64);

            abzal.Create(canvas);

            Bitmap[] anim = { ScaleUp(new Bitmap("img/abzarioWalk1.png"), 4), ScaleUp(new Bitmap("img/abzarioWalk2.png"), 4) };
            abzal.SetAnimation(anim);

        }

        private void OnTimer(object sender, EventArgs e) {
            
        }

        Bitmap ScaleUp(Bitmap source, int scale) {
            Bitmap result = new Bitmap(source.Width * scale, source.Height * scale);
            for (int i = 0; i < source.Width; i++) {
                for (int j = 0; j < source.Height; j++) {
                    for (int l = 0; l < scale; l++) {
                        for (int k = 0; k < scale; k++)
                            result.SetPixel(i * scale + l, j * scale + k, source.GetPixel(i, j));
                    }
                }
            }
            return result;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.A:
                    abzal.box.Left -= PIXEL;
                    abzal.SetDirection(Direction.Left);
                    //abzal.NextFrame();
                    break;
                case Keys.D:
                    abzal.box.Left += PIXEL;
                    abzal.SetDirection(Direction.Right);
                    //abzal.NextFrame();
                    break;
                case Keys.W:
                    abzal.Jump();
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.A:
                case Keys.D:
                    //abzal.ResetImage(); 
                    break;
            }
        }

    }
}
