namespace KeyStrokes
{
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
            this.lblWatermark = new System.Windows.Forms.Label();
            this.BtnR = new KeyStrokes.NoFocusBtn();
            this.BtnL = new KeyStrokes.NoFocusBtn();
            this.BtnSpace = new KeyStrokes.NoFocusBtn();
            this.BtnD = new KeyStrokes.NoFocusBtn();
            this.BtnS = new KeyStrokes.NoFocusBtn();
            this.BtnA = new KeyStrokes.NoFocusBtn();
            this.BtnW = new KeyStrokes.NoFocusBtn();
            this.SuspendLayout();
            // 
            // gradient
            // 
            this.gradient.Enabled = true;
            this.gradient.Interval = 80;
            this.gradient.Tick += new System.EventHandler(this.gradient_Tick);
            // 
            // lblWatermark
            // 
            this.lblWatermark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lblWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWatermark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblWatermark.Location = new System.Drawing.Point(-1, 168);
            this.lblWatermark.Name = "lblWatermark";
            this.lblWatermark.Size = new System.Drawing.Size(130, 18);
            this.lblWatermark.TabIndex = 45;
            this.lblWatermark.Text = "KeyStrokes";
            this.lblWatermark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWatermark.Visible = false;
            // 
            // BtnR
            // 
            this.BtnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BtnR.FlatAppearance.BorderSize = 3;
            this.BtnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnR.Location = new System.Drawing.Point(87, 125);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(40, 40);
            this.BtnR.TabIndex = 37;
            this.BtnR.Text = "R";
            this.BtnR.UseVisualStyleBackColor = false;
            this.BtnR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnR_MouseDown);
            // 
            // BtnL
            // 
            this.BtnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BtnL.FlatAppearance.BorderSize = 3;
            this.BtnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnL.Location = new System.Drawing.Point(1, 125);
            this.BtnL.Name = "BtnL";
            this.BtnL.Size = new System.Drawing.Size(40, 40);
            this.BtnL.TabIndex = 36;
            this.BtnL.Text = "L";
            this.BtnL.UseVisualStyleBackColor = false;
            this.BtnL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnL_MouseDown);
            // 
            // BtnSpace
            // 
            this.BtnSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BtnSpace.FlatAppearance.BorderSize = 3;
            this.BtnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnSpace.Location = new System.Drawing.Point(1, 86);
            this.BtnSpace.Name = "BtnSpace";
            this.BtnSpace.Size = new System.Drawing.Size(126, 36);
            this.BtnSpace.TabIndex = 35;
            this.BtnSpace.Text = "Space";
            this.BtnSpace.UseVisualStyleBackColor = false;
            this.BtnSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSpace_MouseDown);
            // 
            // BtnD
            // 
            this.BtnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BtnD.FlatAppearance.BorderSize = 3;
            this.BtnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnD.Location = new System.Drawing.Point(87, 43);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(40, 40);
            this.BtnD.TabIndex = 34;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = false;
            this.BtnD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnD_MouseDown);
            // 
            // BtnS
            // 
            this.BtnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BtnS.FlatAppearance.BorderSize = 3;
            this.BtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnS.Location = new System.Drawing.Point(44, 43);
            this.BtnS.Name = "BtnS";
            this.BtnS.Size = new System.Drawing.Size(40, 40);
            this.BtnS.TabIndex = 33;
            this.BtnS.Text = "S";
            this.BtnS.UseVisualStyleBackColor = false;
            this.BtnS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnS_MouseDown);
            // 
            // BtnA
            // 
            this.BtnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BtnA.FlatAppearance.BorderSize = 3;
            this.BtnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnA.Location = new System.Drawing.Point(1, 43);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(40, 40);
            this.BtnA.TabIndex = 32;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = false;
            this.BtnA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnA_MouseDown);
            // 
            // BtnW
            // 
            this.BtnW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BtnW.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnW.FlatAppearance.BorderSize = 3;
            this.BtnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnW.Location = new System.Drawing.Point(44, 0);
            this.BtnW.Name = "BtnW";
            this.BtnW.Size = new System.Drawing.Size(40, 40);
            this.BtnW.TabIndex = 31;
            this.BtnW.Text = "W";
            this.BtnW.UseVisualStyleBackColor = false;
            this.BtnW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnW_MouseDown);
            // 
            // FormKeyStrokes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(128, 186);
            this.Controls.Add(this.lblWatermark);
            this.Controls.Add(this.BtnR);
            this.Controls.Add(this.BtnL);
            this.Controls.Add(this.BtnSpace);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnS);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.BtnW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKeyStrokes";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyStrokes";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.ResumeLayout(false);

        }

        #endregion
        private KeyStrokes.NoFocusBtn BtnW;
        private KeyStrokes.NoFocusBtn BtnA;
        private KeyStrokes.NoFocusBtn BtnS;
        private KeyStrokes.NoFocusBtn BtnD;
        private KeyStrokes.NoFocusBtn BtnSpace;
        private KeyStrokes.NoFocusBtn BtnL;
        private KeyStrokes.NoFocusBtn BtnR;
        private System.Windows.Forms.Timer gradient;
        private System.Windows.Forms.Label lblWatermark;
    }
}