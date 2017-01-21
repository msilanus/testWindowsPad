using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace WindowsFormsApplication1
{
    public partial class FormTestGamePad : Form
    {
        public FormTestGamePad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.A == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                 cbA.Checked = true;
            else cbA.Checked = false;


            if (GamePad.GetState(PlayerIndex.One).Buttons.B == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                 cbB.Checked = true;
            else cbB.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).Buttons.X == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                 cbX.Checked = true;
            else cbX.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).Buttons.Y == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                 cbY.Checked = true;
            else cbY.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).DPad.Up == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                 cbDPadUp.Checked = true;
            else cbDPadUp.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).DPad.Down == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                cbDPadDown.Checked = true;
            else cbDPadDown.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).DPad.Left == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                cbDPadLeft.Checked = true;
            else cbDPadLeft.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).DPad.Right == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                cbDPadRight.Checked = true;
            else cbDPadRight.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).Buttons.LeftShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                cbLeftShoulder.Checked = true;
            else cbLeftShoulder.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).Buttons.RightShoulder == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                cbRightShoulder.Checked = true;
            else cbRightShoulder.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).Buttons.LeftStick == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                cbThumbLeft.Checked = true;
            else cbThumbLeft.Checked = false;

            if (GamePad.GetState(PlayerIndex.One).Buttons.RightStick == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                cbThumbRight.Checked = true;
            else cbThumbRight.Checked = false;

            pbLeft.Value = (int)(GamePad.GetState(PlayerIndex.One).Triggers.Left * 1000);
            pbRight.Value = (int)(GamePad.GetState(PlayerIndex.One).Triggers.Right * 1000);

            int thumbLeftX = (int)(GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.X * 1000);
            int thumbLeftY = (int)(GamePad.GetState(PlayerIndex.One).ThumbSticks.Left.Y * 1000);
            int thumbRightX = (int)(GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.X * 1000);
            int thumbRightY = (int)(GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.Y * 1000);
            
            tbThumLeftX.Value = thumbLeftX;
            tbThumLeftY.Value = thumbLeftY;
            tbThumRightX.Value = thumbRightX;
            tbThumRightY.Value = thumbRightY;

            lbThumbLeftX.Text = thumbLeftX.ToString();
            lbThumbLeftY.Text = thumbLeftY.ToString();
            lbThumbRightX.Text = thumbRightX.ToString();
            lbThumbRightY.Text = thumbRightY.ToString();
        }


    }
}
