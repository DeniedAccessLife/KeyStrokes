using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyStrokes
{
    public class NoFocusButton : Button
    {
        public NoFocusButton()
        {
            this.SetStyle(ControlStyles.Selectable, false);
        }
    }

    partial class FormKeyStrokes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeyStrokes));
            this.gradient = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxKeyboard = new System.Windows.Forms.CheckBox();
            this.checkBoxMouse = new System.Windows.Forms.CheckBox();
            this.checkBoxWatermark = new System.Windows.Forms.CheckBox();
            this.labelFunctions = new System.Windows.Forms.Label();
            this.watermark = new System.Windows.Forms.Label();
            this.labelColors = new System.Windows.Forms.Label();
            this.checkBoxGradient = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn8 = new KeyStrokes.NoFocusButton();
            this.Btn13 = new KeyStrokes.NoFocusButton();
            this.Btn7 = new KeyStrokes.NoFocusButton();
            this.Btn15 = new KeyStrokes.NoFocusButton();
            this.Btn6 = new KeyStrokes.NoFocusButton();
            this.Btn5 = new KeyStrokes.NoFocusButton();
            this.Btn14 = new KeyStrokes.NoFocusButton();
            this.Btn11 = new KeyStrokes.NoFocusButton();
            this.Btn4 = new KeyStrokes.NoFocusButton();
            this.Btn12 = new KeyStrokes.NoFocusButton();
            this.Btn3 = new KeyStrokes.NoFocusButton();
            this.Btn16 = new KeyStrokes.NoFocusButton();
            this.Btn2 = new KeyStrokes.NoFocusButton();
            this.Btn10 = new KeyStrokes.NoFocusButton();
            this.Btn1 = new KeyStrokes.NoFocusButton();
            this.Btn9 = new KeyStrokes.NoFocusButton();
            this.Right = new KeyStrokes.NoFocusButton();
            this.Left = new KeyStrokes.NoFocusButton();
            this.Space = new KeyStrokes.NoFocusButton();
            this.D = new KeyStrokes.NoFocusButton();
            this.S = new KeyStrokes.NoFocusButton();
            this.A = new KeyStrokes.NoFocusButton();
            this.W = new KeyStrokes.NoFocusButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient
            // 
            this.gradient.Interval = 20;
            this.gradient.Tick += new System.EventHandler(this.gradient_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.checkBoxKeyboard);
            this.panel1.Controls.Add(this.checkBoxMouse);
            this.panel1.Controls.Add(this.checkBoxWatermark);
            this.panel1.Controls.Add(this.labelFunctions);
            this.panel1.Location = new System.Drawing.Point(401, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 285);
            this.panel1.TabIndex = 39;
            this.panel1.Visible = false;
            // 
            // checkBoxKeyboard
            // 
            this.checkBoxKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxKeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxKeyboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkBoxKeyboard.Location = new System.Drawing.Point(4, 106);
            this.checkBoxKeyboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxKeyboard.Name = "checkBoxKeyboard";
            this.checkBoxKeyboard.Size = new System.Drawing.Size(186, 35);
            this.checkBoxKeyboard.TabIndex = 46;
            this.checkBoxKeyboard.TabStop = false;
            this.checkBoxKeyboard.Text = "Keyboard";
            this.checkBoxKeyboard.UseVisualStyleBackColor = true;
            // 
            // checkBoxMouse
            // 
            this.checkBoxMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxMouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkBoxMouse.Location = new System.Drawing.Point(4, 80);
            this.checkBoxMouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMouse.Name = "checkBoxMouse";
            this.checkBoxMouse.Size = new System.Drawing.Size(186, 35);
            this.checkBoxMouse.TabIndex = 45;
            this.checkBoxMouse.TabStop = false;
            this.checkBoxMouse.Text = "Mouse";
            this.checkBoxMouse.UseVisualStyleBackColor = true;
            // 
            // checkBoxWatermark
            // 
            this.checkBoxWatermark.Checked = true;
            this.checkBoxWatermark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWatermark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxWatermark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkBoxWatermark.Location = new System.Drawing.Point(4, 55);
            this.checkBoxWatermark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxWatermark.Name = "checkBoxWatermark";
            this.checkBoxWatermark.Size = new System.Drawing.Size(186, 35);
            this.checkBoxWatermark.TabIndex = 44;
            this.checkBoxWatermark.TabStop = false;
            this.checkBoxWatermark.Text = "Watermark";
            this.checkBoxWatermark.UseVisualStyleBackColor = true;
            this.checkBoxWatermark.CheckedChanged += new System.EventHandler(this.checkBoxWatermark_CheckedChanged);
            // 
            // labelFunctions
            // 
            this.labelFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.labelFunctions.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunctions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.labelFunctions.Location = new System.Drawing.Point(0, 0);
            this.labelFunctions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunctions.Name = "labelFunctions";
            this.labelFunctions.Size = new System.Drawing.Size(195, 52);
            this.labelFunctions.TabIndex = 39;
            this.labelFunctions.Text = "Functions";
            this.labelFunctions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watermark
            // 
            this.watermark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watermark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.watermark.Location = new System.Drawing.Point(204, 269);
            this.watermark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.watermark.Name = "watermark";
            this.watermark.Size = new System.Drawing.Size(188, 28);
            this.watermark.TabIndex = 45;
            this.watermark.Text = "\'Insert\' to show menu.";
            this.watermark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColors
            // 
            this.labelColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.labelColors.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.labelColors.Location = new System.Drawing.Point(0, 0);
            this.labelColors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColors.Name = "labelColors";
            this.labelColors.Size = new System.Drawing.Size(195, 52);
            this.labelColors.TabIndex = 39;
            this.labelColors.Text = "Colors";
            this.labelColors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxGradient
            // 
            this.checkBoxGradient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxGradient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxGradient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkBoxGradient.Location = new System.Drawing.Point(4, 246);
            this.checkBoxGradient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxGradient.Name = "checkBoxGradient";
            this.checkBoxGradient.Size = new System.Drawing.Size(186, 35);
            this.checkBoxGradient.TabIndex = 40;
            this.checkBoxGradient.TabStop = false;
            this.checkBoxGradient.Text = "Gradient";
            this.checkBoxGradient.UseVisualStyleBackColor = true;
            this.checkBoxGradient.CheckedChanged += new System.EventHandler(this.checkBoxGradient_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.Btn8);
            this.panel2.Controls.Add(this.checkBoxGradient);
            this.panel2.Controls.Add(this.Btn13);
            this.panel2.Controls.Add(this.Btn7);
            this.panel2.Controls.Add(this.Btn15);
            this.panel2.Controls.Add(this.Btn6);
            this.panel2.Controls.Add(this.Btn5);
            this.panel2.Controls.Add(this.Btn14);
            this.panel2.Controls.Add(this.Btn11);
            this.panel2.Controls.Add(this.Btn4);
            this.panel2.Controls.Add(this.Btn12);
            this.panel2.Controls.Add(this.Btn3);
            this.panel2.Controls.Add(this.Btn16);
            this.panel2.Controls.Add(this.Btn2);
            this.panel2.Controls.Add(this.Btn10);
            this.panel2.Controls.Add(this.Btn1);
            this.panel2.Controls.Add(this.Btn9);
            this.panel2.Controls.Add(this.labelColors);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 285);
            this.panel2.TabIndex = 49;
            this.panel2.Visible = false;
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Btn8.FlatAppearance.BorderSize = 3;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Location = new System.Drawing.Point(153, 103);
            this.Btn8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(38, 38);
            this.Btn8.TabIndex = 48;
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn13
            // 
            this.Btn13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Btn13.FlatAppearance.BorderSize = 3;
            this.Btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn13.Location = new System.Drawing.Point(4, 198);
            this.Btn13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn13.Name = "Btn13";
            this.Btn13.Size = new System.Drawing.Size(38, 38);
            this.Btn13.TabIndex = 48;
            this.Btn13.UseVisualStyleBackColor = false;
            this.Btn13.Click += new System.EventHandler(this.Btn13_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(188)))));
            this.Btn7.FlatAppearance.BorderSize = 3;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Location = new System.Drawing.Point(104, 103);
            this.Btn7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(38, 38);
            this.Btn7.TabIndex = 47;
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn15
            // 
            this.Btn15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(81)))), ((int)(((byte)(157)))));
            this.Btn15.FlatAppearance.BorderSize = 3;
            this.Btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn15.Location = new System.Drawing.Point(104, 198);
            this.Btn15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn15.Name = "Btn15";
            this.Btn15.Size = new System.Drawing.Size(38, 38);
            this.Btn15.TabIndex = 47;
            this.Btn15.UseVisualStyleBackColor = false;
            this.Btn15.Click += new System.EventHandler(this.Btn15_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.Btn6.FlatAppearance.BorderSize = 3;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Location = new System.Drawing.Point(54, 103);
            this.Btn6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(38, 38);
            this.Btn6.TabIndex = 46;
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Btn5.FlatAppearance.BorderSize = 3;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Location = new System.Drawing.Point(104, 55);
            this.Btn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(38, 38);
            this.Btn5.TabIndex = 45;
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn14
            // 
            this.Btn14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.Btn14.FlatAppearance.BorderSize = 3;
            this.Btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn14.Location = new System.Drawing.Point(54, 198);
            this.Btn14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn14.Name = "Btn14";
            this.Btn14.Size = new System.Drawing.Size(38, 38);
            this.Btn14.TabIndex = 46;
            this.Btn14.UseVisualStyleBackColor = false;
            this.Btn14.Click += new System.EventHandler(this.Btn14_Click);
            // 
            // Btn11
            // 
            this.Btn11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.Btn11.FlatAppearance.BorderSize = 3;
            this.Btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn11.Location = new System.Drawing.Point(104, 151);
            this.Btn11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn11.Name = "Btn11";
            this.Btn11.Size = new System.Drawing.Size(38, 38);
            this.Btn11.TabIndex = 45;
            this.Btn11.UseVisualStyleBackColor = false;
            this.Btn11.Click += new System.EventHandler(this.Btn11_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(169)))), ((int)(((byte)(24)))));
            this.Btn4.FlatAppearance.BorderSize = 3;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Location = new System.Drawing.Point(153, 55);
            this.Btn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(38, 38);
            this.Btn4.TabIndex = 43;
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn12
            // 
            this.Btn12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(94)))), ((int)(((byte)(35)))));
            this.Btn12.FlatAppearance.BorderSize = 3;
            this.Btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn12.Location = new System.Drawing.Point(153, 151);
            this.Btn12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn12.Name = "Btn12";
            this.Btn12.Size = new System.Drawing.Size(38, 38);
            this.Btn12.TabIndex = 43;
            this.Btn12.UseVisualStyleBackColor = false;
            this.Btn12.Click += new System.EventHandler(this.Btn12_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Btn3.FlatAppearance.BorderSize = 3;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Location = new System.Drawing.Point(4, 103);
            this.Btn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(38, 38);
            this.Btn3.TabIndex = 42;
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn16
            // 
            this.Btn16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(98)))), ((int)(((byte)(249)))));
            this.Btn16.FlatAppearance.BorderSize = 3;
            this.Btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn16.Location = new System.Drawing.Point(153, 198);
            this.Btn16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn16.Name = "Btn16";
            this.Btn16.Size = new System.Drawing.Size(38, 38);
            this.Btn16.TabIndex = 42;
            this.Btn16.UseVisualStyleBackColor = false;
            this.Btn16.Click += new System.EventHandler(this.Btn16_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.Btn2.FlatAppearance.BorderSize = 3;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Location = new System.Drawing.Point(54, 55);
            this.Btn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(38, 38);
            this.Btn2.TabIndex = 41;
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn10
            // 
            this.Btn10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(121)))), ((int)(((byte)(145)))));
            this.Btn10.FlatAppearance.BorderSize = 3;
            this.Btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn10.Location = new System.Drawing.Point(54, 151);
            this.Btn10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn10.Name = "Btn10";
            this.Btn10.Size = new System.Drawing.Size(38, 38);
            this.Btn10.TabIndex = 41;
            this.Btn10.UseVisualStyleBackColor = false;
            this.Btn10.Click += new System.EventHandler(this.Btn10_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.Btn1.FlatAppearance.BorderSize = 3;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Location = new System.Drawing.Point(4, 55);
            this.Btn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(38, 38);
            this.Btn1.TabIndex = 40;
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(80)))));
            this.Btn9.FlatAppearance.BorderSize = 3;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Location = new System.Drawing.Point(4, 151);
            this.Btn9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(38, 38);
            this.Btn9.TabIndex = 40;
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Right.FlatAppearance.BorderSize = 3;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Right.Location = new System.Drawing.Point(332, 204);
            this.Right.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(60, 62);
            this.Right.TabIndex = 37;
            this.Right.Text = "R";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Left.FlatAppearance.BorderSize = 3;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Left.Location = new System.Drawing.Point(204, 204);
            this.Left.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(60, 62);
            this.Left.TabIndex = 36;
            this.Left.Text = "L";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // Space
            // 
            this.Space.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Space.FlatAppearance.BorderSize = 3;
            this.Space.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Space.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Space.Location = new System.Drawing.Point(204, 140);
            this.Space.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(189, 55);
            this.Space.TabIndex = 35;
            this.Space.Text = "Space";
            this.Space.UseVisualStyleBackColor = false;
            this.Space.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.D.FlatAppearance.BorderSize = 3;
            this.D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.D.Location = new System.Drawing.Point(332, 74);
            this.D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(60, 62);
            this.D.TabIndex = 34;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = false;
            this.D.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.S.FlatAppearance.BorderSize = 3;
            this.S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.S.Location = new System.Drawing.Point(268, 74);
            this.S.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(60, 62);
            this.S.TabIndex = 33;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = false;
            this.S.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.A.FlatAppearance.BorderSize = 3;
            this.A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.A.Location = new System.Drawing.Point(204, 74);
            this.A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(60, 62);
            this.A.TabIndex = 32;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = false;
            this.A.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.W.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.W.FlatAppearance.BorderSize = 3;
            this.W.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.W.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.W.Location = new System.Drawing.Point(268, 8);
            this.W.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(60, 62);
            this.W.TabIndex = 31;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = false;
            this.W.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // FormKeyStrokes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(596, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.watermark);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.D);
            this.Controls.Add(this.S);
            this.Controls.Add(this.A);
            this.Controls.Add(this.W);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKeyStrokes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyStrokes";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label watermark;
        private NoFocusButton W;
        private NoFocusButton A;
        private NoFocusButton S;
        private NoFocusButton D;
        private NoFocusButton Space;
        private new NoFocusButton Left;
        private new NoFocusButton Right;
        private Panel panel1;
        private Panel panel2;
        private Timer gradient;
        private Label labelColors;
        private Label labelFunctions;
        private CheckBox checkBoxMouse;
        private CheckBox checkBoxKeyboard;
        private CheckBox checkBoxWatermark;
        private CheckBox checkBoxGradient;
        private NoFocusButton Btn9;
        private NoFocusButton Btn1;
        private NoFocusButton Btn10;
        private NoFocusButton Btn2;
        private NoFocusButton Btn16;
        private NoFocusButton Btn3;
        private NoFocusButton Btn12;
        private NoFocusButton Btn4;
        private NoFocusButton Btn8;
        private NoFocusButton Btn11;
        private NoFocusButton Btn14;
        private NoFocusButton Btn5;
        private NoFocusButton Btn6;
        private NoFocusButton Btn15;
        private NoFocusButton Btn7;
        private NoFocusButton Btn13;

        private void ChangeColor(Color color)
        {
            gradient.Enabled = false;
            checkBoxGradient.Checked = false;

            W.ForeColor = color;
            A.ForeColor = color;
            S.ForeColor = color;
            D.ForeColor = color;
            Left.ForeColor = color;
            Space.ForeColor = color;
            Right.ForeColor = color;

            watermark.ForeColor = color;
            labelColors.ForeColor = color;
            labelFunctions.ForeColor = color;

            checkBoxMouse.ForeColor = color;
            checkBoxGradient.ForeColor = color;
            checkBoxKeyboard.ForeColor = color;
            checkBoxWatermark.ForeColor = color;
        }

        private void gradient_Tick(object sender, EventArgs e)
        {
            Color nextColor = Colorful.GetNextColor();

            foreach (Control control in changeColor)
            {
                control.ForeColor = nextColor;
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            Screen screen = Screen.FromControl(this);
            Rectangle workingArea = screen.WorkingArea;
            int bufferX = 195;

            if (base.Right - bufferX > workingArea.Right)
            {
                base.Left = workingArea.Right - Width + bufferX;
            }
            else if (base.Left + bufferX < workingArea.Left)
            {
                base.Left = workingArea.Left - bufferX;
            }
            if (Bottom > workingArea.Bottom)
            {
                Top = workingArea.Bottom - Height;
            }
            else if (Top < workingArea.Top)
            {
                Top = workingArea.Top;
            }
        }
    }
}