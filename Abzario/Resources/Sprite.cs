using System;
using System.Drawing;
using System.Windows.Forms;

namespace Abzario.Resources {
     class Sprite {
        
        private Bitmap _image;
        private Vector2 _position;
        private int _width;
        private int _height;
        private Bitmap[] _animation;
        private int _currenFrame;
        private int _animSpeed = 4;
        private int _currentSpeed = 0;
        public PictureBox box;
        private Direction _direct = Direction.Right;
        private int jumptopgranice = 100;
        private int jumpbotgranice = 300;

        public Sprite(Bitmap image, Vector2 position, int width, int height) {
            _image = image;
            _position = position;
            _width = width;
            _height = height;
        }

        public void Create(Panel canvas) {
            PictureBox box = new PictureBox();
            box.Parent = canvas;
            box.Image = _image;
            box.Left = _position.x;
            box.Top = _position.y;
            box.Width = _width;
            box.Height = _height;
            box.SizeMode = PictureBoxSizeMode.StretchImage;
            this.box = box;
        }

        public void SetAnimation(Bitmap[] animation) {
            _animation = animation;
            _currenFrame = 0;
        }

        public void NextFrame() {
            box.Image = _animation[_currenFrame];
            _currentSpeed++;
            if (_currentSpeed >= _animSpeed) {
                _currenFrame++;
                if (_currenFrame >= _animation.Length) {
                    _currenFrame = 0;
                }
                _currentSpeed = 0;
            }
        }

        public void ResetImage() {
            box.Image = _image;
            _currentSpeed = 0;
        }

        public void Jump() {
            while(box.Top > jumptopgranice) {
                box.Top -= 5;
            }
            while (box.Top < jumpbotgranice) {
                box.Top += 5;
            }
        }

        public void SetDirection(Direction dir) {
            if (dir != _direct) {
                box.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                _direct = dir;
            }
        }

    }
}
