using Indieteur.GlobalHooks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyStrokes
{
    public partial class FormKeyStrokes : Form
    {
        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;

        GlobalKeyHook globalKeyHook;
        GlobalMouseHook globalMouseHook;

        List<Control> changeColor;
        Dictionary<GHMouseButtons, Button> mouseMap;
        Dictionary<VirtualKeycodes, Button> keyboardMap;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormKeyStrokes()
        {
            InitializeComponent();

            globalKeyHook = new GlobalKeyHook();
            globalKeyHook.OnKeyDown += GlobalKeyHook_OnKeyDown;
            globalKeyHook.OnKeyUp += GlobalKeyHook_OnKeyUp;

            globalMouseHook = new GlobalMouseHook();
            globalMouseHook.OnButtonDown += GlobalMouseHook_OnButtonDown;
            globalMouseHook.OnButtonUp += GlobalMouseHook_OnButtonUp;

            changeColor = new List<Control> { W, A, S, D, Space, Left, Right, labelColors, labelFunctions, watermark, checkBoxGradient, checkBoxWatermark, checkBoxMouse, checkBoxKeyboard };

            mouseMap = new Dictionary<GHMouseButtons, Button>
            {
                { GHMouseButtons.Left, Left },
                { GHMouseButtons.Right, Right },
            };

            keyboardMap = new Dictionary<VirtualKeycodes, Button>
            {
                { VirtualKeycodes.W, W },
                { VirtualKeycodes.A, A },
                { VirtualKeycodes.S, S },
                { VirtualKeycodes.D, D },
                { VirtualKeycodes.Space, Space }
            };
        }

        private void GlobalKeyHook_OnKeyUp(object sender, GlobalKeyEventArgs e)
        {
            if (keyboardMap.TryGetValue(e.KeyCode, out var button))
            {
                button.BackColor = Color.FromArgb(18, 18, 18);
            }
        }

        private void GlobalKeyHook_OnKeyDown(object sender, GlobalKeyEventArgs e)
        {
            if (checkBoxKeyboard.Checked == true)
            {
                SoundPlayer keyboard = new SoundPlayer(Properties.Resources.Keyboard);
                keyboard.Play();
            }

            if (keyboardMap.TryGetValue(e.KeyCode, out var button))
            {
                button.BackColor = Color.FromArgb(100, 100, 100);
            }

            if (e.KeyCode == VirtualKeycodes.Insert)
            {
                panel1.Visible = !panel1.Visible;
                panel2.Visible = !panel2.Visible;

                watermark.Text = "KeyStrokes";
                watermark.Font = new Font(watermark.Font.Name, 9.75F, watermark.Font.Style);
            }
        }

        private void GlobalMouseHook_OnButtonUp(object sender, GlobalMouseEventArgs e)
        {
            if (mouseMap.TryGetValue(e.Button, out var button))
            {
                button.BackColor = Color.FromArgb(18, 18, 18);
            }
        }

        private void GlobalMouseHook_OnButtonDown(object sender, GlobalMouseEventArgs e)
        {
            if (checkBoxMouse.Checked == true)
            {
                SoundPlayer mouse = new SoundPlayer(Properties.Resources.Mouse);
                mouse.Play();
            }

            if (mouseMap.TryGetValue(e.Button, out var button))
            {
                button.BackColor = Color.FromArgb(100, 100, 100);
            }
        }

        private void checkBoxGradient_CheckedChanged(object sender, EventArgs e)
        {
            gradient.Enabled = checkBoxGradient.Checked;
        }

        private void checkBoxWatermark_CheckedChanged(object sender, EventArgs e)
        {
            watermark.Visible = checkBoxWatermark.Checked;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(229, 54, 69));
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(0, 21, 255));
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(190, 0, 255));
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(11, 169, 24));
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(24, 240, 255));
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(255, 98, 0));
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(255, 0, 188));
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(114, 0, 255));
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(236, 234, 80));
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(100, 121, 145));
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(102, 66, 91));
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(205, 94, 35));
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(46, 204, 113));
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(228, 85, 96));
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(156, 81, 157));
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.FromArgb(72, 98, 249));
        }
    }
}