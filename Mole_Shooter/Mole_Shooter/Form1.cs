#define My_Debug
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mole_Shooter.Properties;
using System.Media;


namespace Mole_Shooter
{

   
    public partial class MoleShooter : Form
    {
        bool splat = false;

        int _gameFrame = 0;
        int _splatTime = 0;
#if My_Debug
        int _cursX = 0;
        int _cursY = 0;
#endif

        CMole _mole;
        CSplat _splat;
        CSign _sign;
        CScoreFrame _scoreFrame;


        public MoleShooter()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(Resources.Site);
            this.Cursor = CustomCursor.CreateCursor(b, b.Height / 2, b.Width / 2);

            _scoreFrame = new CScoreFrame() { Left = 1, Top = 1 };
            _sign = new CSign() { Left = 1180, Top = 180 };


            _mole = new CMole() { Left = 550, Top = 550 };
            _splat = new CSplat();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {
            if (_gameFrame >= 8)
            {
                UpdateMole();
                _gameFrame = 0;

            }
            if (splat)
            {
                if (_splatTime >= 3)
                {
                    splat = false;
                    _splatTime = 0;
                    UpdateMole();

                }
                _splatTime++;

            }

            _gameFrame++;
            
            this.Refresh();   
        }
       
        private void UpdateMole()
        {
            Random rnd = new Random();﻿
            _mole.Update(
                rnd.Next(Resources.Mole.Width, this.Width - Resources.Mole.Width),
                rnd.Next(this.Height / 2, this.Height - Resources.Mole.Height * 1)
                
            );
        }
   

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            if (splat == true)
            {
                _splat.DrawImage(dc);
            }
            else
            {

            }

            
            _sign.DrawImage(dc);
            _scoreFrame.DrawImage(dc);



#if My_Debug
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X=" + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(), _font,
                new Rectangle(0, 0, 120, 20), SystemColors.ControlText, flags);
#endif

            _mole.DrawImage(dc);

            base.OnPaint(e);

        }

        private void MoleShooter_MouseMove(object sender, MouseEventArgs e)
        {
#if My_Debug
            _cursX = e.X;
            _cursY = e.Y;
#endif
                this.Refresh();
        }

        private void MoleShooter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 1230 && e.X < 1290 && e.Y > 220 && e.Y < 235) //Start
            {
                timerGameLoop.Start();
            }
            else if (e.X > 1230 && e.X < 1290 && e.Y > 248 && e.Y < 265) //Stop
            {
                timerGameLoop.Stop();
            }
            else if (e.X > 1230 && e.X < 1290 && e.Y > 270 & e.Y < 287) //Reset
            {
                timerGameLoop.Stop();

            }
            else if (e.X > 1230 && e.X < 1290 && e.Y > 294 && e.Y < 313) //Quit
            {
                timerGameLoop.Stop();

            }
            else
            {
                if (_mole.Hit(e.X, e.Y))
                {
                     splat = true;
                    _splat.Left = _mole.Left - Resources.Splat.Width / 3;
                    _splat.Top = _mole.Top - Resources.Splat.Height / 3;
                }
            }
            Firegun();
        }
        private void Firegun()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.ShotGun);
            simpleSound.Play();
        }

    }
}
