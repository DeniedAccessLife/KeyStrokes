using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Indieteur.GlobalHooks;

namespace KeyStrokes
{
    public partial class FormKeyStrokes : Form
    {
        GlobalKeyHook globalKeyHook;
        GlobalMouseHook globalMouseHook;

        public FormKeyStrokes()
        {
            InitializeComponent();

            globalKeyHook = new GlobalKeyHook();
            globalKeyHook.OnKeyDown += GlobalKeyHook_OnKeyDown;
            globalKeyHook.OnKeyUp += GlobalKeyHook_OnKeyUp;

            globalMouseHook = new GlobalMouseHook();
            globalMouseHook.OnButtonDown += GlobalMouseHook_OnButtonDown;
            globalMouseHook.OnButtonUp += GlobalMouseHook_OnButtonUp;
        }

        #region FormDragging
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region Gradient
        float step = 0;
        Color currentColor = Color.FromArgb(46, 204, 113);
        Color targetColor = Color.FromArgb(229, 54, 69);
        Random rnd = new Random();
        #endregion

        private void GlobalKeyHook_OnKeyUp(object sender, GlobalKeyEventArgs e)
        {
            if (e.KeyCode == VirtualKeycodes.W)
            {
                BtnW.BackColor = Color.FromArgb(18, 18, 18);
            }

            if (e.KeyCode == VirtualKeycodes.A)
            {
                BtnA.BackColor = Color.FromArgb(18, 18, 18);
            }

            if (e.KeyCode == VirtualKeycodes.S)
            {
                BtnS.BackColor = Color.FromArgb(18, 18, 18);
            }

            if (e.KeyCode == VirtualKeycodes.D)
            {
                BtnD.BackColor = Color.FromArgb(18, 18, 18);
            }

            if(e.KeyCode == VirtualKeycodes.Space)
            {
                BtnSpace.BackColor = Color.FromArgb(18, 18, 18);
            }
        }

        private void GlobalKeyHook_OnKeyDown(object sender, GlobalKeyEventArgs e)
        {
            if (e.KeyCode == VirtualKeycodes.W)
            {
                BtnW.BackColor = Color.FromArgb(123, 123, 123);
            }

            if (e.KeyCode == VirtualKeycodes.A)
            {
                BtnA.BackColor = Color.FromArgb(123, 123, 123);
            }

            if (e.KeyCode == VirtualKeycodes.S)
            {
                BtnS.BackColor = Color.FromArgb(123, 123, 123);
            }

            if (e.KeyCode == VirtualKeycodes.D)
            {
                BtnD.BackColor = Color.FromArgb(123, 123, 123);
            }

            if (e.KeyCode == VirtualKeycodes.Space)
            {
                BtnSpace.BackColor = Color.FromArgb(123, 123, 123);
            }
        }

        private void GlobalMouseHook_OnButtonUp(object sender, GlobalMouseEventArgs e)
        {
            if (e.Button == GHMouseButtons.Left)
            {
                BtnL.BackColor = Color.FromArgb(18, 18, 18);
            }

            if (e.Button == GHMouseButtons.Right)
            {
                BtnR.BackColor = Color.FromArgb(18, 18, 18);
            }
        }

        private void GlobalMouseHook_OnButtonDown(object sender, GlobalMouseEventArgs e)
        {
            if (e.Button == GHMouseButtons.Left)
            {
                BtnL.BackColor = Color.FromArgb(123, 123, 123);
            }

            if (e.Button == GHMouseButtons.Right)
            {
                BtnR.BackColor = Color.FromArgb(123, 123, 123);
            }
        }

        private void gradient_Tick(object sender, EventArgs e)
        {
            if (step >= 1f)
            {
                step = 0;

                int R = rnd.Next(0, 255);
                int G = rnd.Next(0, 255);
                int B = rnd.Next(0, 255);
                currentColor = targetColor;
                targetColor = Color.FromArgb(R, G, B);
            }
            int mixR = (int)(currentColor.R * (1f - step) + targetColor.R * step);
            int mixG = (int)(currentColor.G * (1f - step) + targetColor.G * step);
            int mixB = (int)(currentColor.B * (1f - step) + targetColor.B * step);

            BtnW.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            BtnA.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            BtnS.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            BtnD.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            BtnSpace.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            BtnL.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            BtnR.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            lblWatermark.ForeColor = Color.FromArgb(mixR, mixG, mixB);

            step += 0.03f;
        }

        private void BtnW_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnA_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnS_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnD_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSpace_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnL_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnR_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}