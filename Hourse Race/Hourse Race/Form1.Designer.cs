namespace Hourse_Race
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.horse1 = new System.Windows.Forms.PictureBox();
            this.horse2 = new System.Windows.Forms.PictureBox();
            this.horse3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1195, 55);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1195, 55);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1195, 55);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1136, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 426);
            this.label4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // horse1
            // 
            this.horse1.BackColor = System.Drawing.Color.White;
            this.horse1.Image = ((System.Drawing.Image)(resources.GetObject("horse1.Image")));
            this.horse1.Location = new System.Drawing.Point(5, 77);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(100, 55);
            this.horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse1.TabIndex = 5;
            this.horse1.TabStop = false;
            // 
            // horse2
            // 
            this.horse2.BackColor = System.Drawing.Color.White;
            this.horse2.Image = ((System.Drawing.Image)(resources.GetObject("horse2.Image")));
            this.horse2.Location = new System.Drawing.Point(5, 224);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(100, 55);
            this.horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse2.TabIndex = 6;
            this.horse2.TabStop = false;
            // 
            // horse3
            // 
            this.horse3.BackColor = System.Drawing.Color.White;
            this.horse3.Image = ((System.Drawing.Image)(resources.GetObject("horse3.Image")));
            this.horse3.Location = new System.Drawing.Point(5, 371);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(100, 55);
            this.horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse3.TabIndex = 7;
            this.horse3.TabStop = false;
            this.horse3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(947, 65);
            this.label5.TabIndex = 8;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(261, 462);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1201, 685);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox horse1;
        private System.Windows.Forms.PictureBox horse2;
        private System.Windows.Forms.PictureBox horse3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

