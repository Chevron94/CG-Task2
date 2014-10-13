namespace Task2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Камера = new System.Windows.Forms.Label();
            this.Camera_Angle = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Button();
            this.SetColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Inp_Pyram2_H = new System.Windows.Forms.TextBox();
            this.Inp_Len = new System.Windows.Forms.TextBox();
            this.Inp_Pyram1_H = new System.Windows.Forms.TextBox();
            this.Inp_W = new System.Windows.Forms.TextBox();
            this.Inp_H = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Inp_Cam_Pos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Inp_Cam_Dir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Inp_Light_Dir = new System.Windows.Forms.TextBox();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Camera_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Inp_Light_Dir);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Inp_Cam_Dir);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Inp_Cam_Pos);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Камера);
            this.panel1.Controls.Add(this.Camera_Angle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Draw);
            this.panel1.Controls.Add(this.SetColor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Inp_Pyram2_H);
            this.panel1.Controls.Add(this.Inp_Len);
            this.panel1.Controls.Add(this.Inp_Pyram1_H);
            this.panel1.Controls.Add(this.Inp_W);
            this.panel1.Controls.Add(this.Inp_H);
            this.panel1.Location = new System.Drawing.Point(813, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 482);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Угол:";
            // 
            // Камера
            // 
            this.Камера.AutoSize = true;
            this.Камера.Location = new System.Drawing.Point(3, 185);
            this.Камера.Name = "Камера";
            this.Камера.Size = new System.Drawing.Size(49, 13);
            this.Камера.TabIndex = 16;
            this.Камера.Text = "Камера:";
            // 
            // Camera_Angle
            // 
            this.Camera_Angle.Location = new System.Drawing.Point(149, 203);
            this.Camera_Angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Camera_Angle.Name = "Camera_Angle";
            this.Camera_Angle.Size = new System.Drawing.Size(46, 20);
            this.Camera_Angle.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Пирамиды:";
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(58, 445);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(110, 23);
            this.Draw.TabIndex = 13;
            this.Draw.Text = "Нарисовать";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // SetColor
            // 
            this.SetColor.Location = new System.Drawing.Point(58, 416);
            this.SetColor.Name = "SetColor";
            this.SetColor.Size = new System.Drawing.Size(110, 23);
            this.SetColor.TabIndex = 12;
            this.SetColor.Text = "Задать цвет";
            this.SetColor.UseVisualStyleBackColor = true;
            this.SetColor.Click += new System.EventHandler(this.SetColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Высота первой пирамиды:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Высота второй пирамиды:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ширина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Высота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Параллелепипед";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Длина:";
            // 
            // Inp_Pyram2_H
            // 
            this.Inp_Pyram2_H.Location = new System.Drawing.Point(159, 154);
            this.Inp_Pyram2_H.Name = "Inp_Pyram2_H";
            this.Inp_Pyram2_H.Size = new System.Drawing.Size(36, 20);
            this.Inp_Pyram2_H.TabIndex = 5;
            // 
            // Inp_Len
            // 
            this.Inp_Len.Location = new System.Drawing.Point(159, 29);
            this.Inp_Len.Name = "Inp_Len";
            this.Inp_Len.Size = new System.Drawing.Size(36, 20);
            this.Inp_Len.TabIndex = 1;
            // 
            // Inp_Pyram1_H
            // 
            this.Inp_Pyram1_H.Location = new System.Drawing.Point(159, 128);
            this.Inp_Pyram1_H.Name = "Inp_Pyram1_H";
            this.Inp_Pyram1_H.Size = new System.Drawing.Size(36, 20);
            this.Inp_Pyram1_H.TabIndex = 4;
            // 
            // Inp_W
            // 
            this.Inp_W.Location = new System.Drawing.Point(159, 55);
            this.Inp_W.Name = "Inp_W";
            this.Inp_W.Size = new System.Drawing.Size(36, 20);
            this.Inp_W.TabIndex = 2;
            // 
            // Inp_H
            // 
            this.Inp_H.Location = new System.Drawing.Point(159, 81);
            this.Inp_H.Name = "Inp_H";
            this.Inp_H.Size = new System.Drawing.Size(36, 20);
            this.Inp_H.TabIndex = 3;
            // 
            // Inp_Cam_Pos
            // 
            this.Inp_Cam_Pos.Location = new System.Drawing.Point(116, 229);
            this.Inp_Cam_Pos.Name = "Inp_Cam_Pos";
            this.Inp_Cam_Pos.Size = new System.Drawing.Size(79, 20);
            this.Inp_Cam_Pos.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Позиция:";
            // 
            // Inp_Cam_Dir
            // 
            this.Inp_Cam_Dir.Location = new System.Drawing.Point(116, 264);
            this.Inp_Cam_Dir.Name = "Inp_Cam_Dir";
            this.Inp_Cam_Dir.Size = new System.Drawing.Size(79, 20);
            this.Inp_Cam_Dir.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Направление:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Свет:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Направление:";
            // 
            // Inp_Light_Dir
            // 
            this.Inp_Light_Dir.Location = new System.Drawing.Point(116, 335);
            this.Inp_Light_Dir.Name = "Inp_Light_Dir";
            this.Inp_Light_Dir.Size = new System.Drawing.Size(79, 20);
            this.Inp_Light_Dir.TabIndex = 24;
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.Location = new System.Drawing.Point(1, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(806, 503);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1025, 506);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Camera_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Button SetColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Inp_Pyram2_H;
        private System.Windows.Forms.TextBox Inp_Len;
        private System.Windows.Forms.TextBox Inp_Pyram1_H;
        private System.Windows.Forms.TextBox Inp_W;
        private System.Windows.Forms.TextBox Inp_H;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Камера;
        private System.Windows.Forms.NumericUpDown Camera_Angle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox Inp_Light_Dir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Inp_Cam_Dir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Inp_Cam_Pos;
        private System.Windows.Forms.PictureBox Canvas;
    }
}

