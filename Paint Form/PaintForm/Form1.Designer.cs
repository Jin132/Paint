namespace PaintForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColorPickerButton = new System.Windows.Forms.Button();
            this.PenButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.FillColorCheckBox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.load = new System.Windows.Forms.Button();
            this.Чб = new System.Windows.Forms.Button();
            this.rotate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 501);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ColorPickerButton
            // 
            this.ColorPickerButton.Location = new System.Drawing.Point(729, 12);
            this.ColorPickerButton.Name = "ColorPickerButton";
            this.ColorPickerButton.Size = new System.Drawing.Size(88, 90);
            this.ColorPickerButton.TabIndex = 1;
            this.ColorPickerButton.Text = "Color Picker";
            this.ColorPickerButton.UseVisualStyleBackColor = true;
            this.ColorPickerButton.Click += new System.EventHandler(this.ColorPickerButton_Click);
            // 
            // PenButton
            // 
            this.PenButton.Location = new System.Drawing.Point(725, 159);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(92, 45);
            this.PenButton.TabIndex = 2;
            this.PenButton.Text = "Pen";
            this.PenButton.UseVisualStyleBackColor = true;
            this.PenButton.Click += new System.EventHandler(this.PenButtond_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(729, 108);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(92, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(865, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FillColorCheckBox
            // 
            this.FillColorCheckBox.AutoSize = true;
            this.FillColorCheckBox.Location = new System.Drawing.Point(725, 374);
            this.FillColorCheckBox.Name = "FillColorCheckBox";
            this.FillColorCheckBox.Size = new System.Drawing.Size(65, 17);
            this.FillColorCheckBox.TabIndex = 4;
            this.FillColorCheckBox.Text = "Fill Color";
            this.FillColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(725, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "Rectangle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PenButtond_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(725, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 45);
            this.button5.TabIndex = 2;
            this.button5.Text = "Line";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PenButtond_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(725, 428);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 45);
            this.button6.TabIndex = 2;
            this.button6.Text = "Circle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PenButtond_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(725, 470);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 45);
            this.button7.TabIndex = 2;
            this.button7.Text = "Triangle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PenButtond_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(725, 294);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(92, 23);
            this.save.TabIndex = 5;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(725, 265);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(92, 23);
            this.load.TabIndex = 6;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.button2_Click);
            // 
            // Чб
            // 
            this.Чб.Location = new System.Drawing.Point(725, 236);
            this.Чб.Name = "Чб";
            this.Чб.Size = new System.Drawing.Size(92, 23);
            this.Чб.TabIndex = 7;
            this.Чб.Text = "black";
            this.Чб.UseVisualStyleBackColor = true;
            this.Чб.Click += new System.EventHandler(this.button8_Click);
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(725, 207);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(92, 23);
            this.rotate.TabIndex = 8;
            this.rotate.Text = "Rotate";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 527);
            this.Controls.Add(this.rotate);
            this.Controls.Add(this.Чб);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.FillColorCheckBox);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PenButton);
            this.Controls.Add(this.ColorPickerButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ColorPickerButton;
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox FillColorCheckBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button Чб;
        private System.Windows.Forms.Button rotate;
    }
}

