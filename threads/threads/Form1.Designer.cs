namespace threads
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
            this.button_WithThread = new System.Windows.Forms.Button();
            this.button_WithoutThread = new System.Windows.Forms.Button();
            this.pictureBox_Panel = new System.Windows.Forms.PictureBox();
            this.panel_X1 = new System.Windows.Forms.Panel();
            this.panel_X2 = new System.Windows.Forms.Panel();
            this.panel_Y1 = new System.Windows.Forms.Panel();
            this.panel_Y2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Panel)).BeginInit();
            this.SuspendLayout();
            // 
            // button_WithThread
            // 
            this.button_WithThread.Location = new System.Drawing.Point(415, 240);
            this.button_WithThread.Name = "button_WithThread";
            this.button_WithThread.Size = new System.Drawing.Size(150, 30);
            this.button_WithThread.TabIndex = 0;
            this.button_WithThread.Text = "Cu fire de executie";
            this.button_WithThread.UseVisualStyleBackColor = true;
            this.button_WithThread.Click += new System.EventHandler(this.button_WithThread_Click);
            // 
            // button_WithoutThread
            // 
            this.button_WithoutThread.Location = new System.Drawing.Point(415, 284);
            this.button_WithoutThread.Name = "button_WithoutThread";
            this.button_WithoutThread.Size = new System.Drawing.Size(150, 30);
            this.button_WithoutThread.TabIndex = 1;
            this.button_WithoutThread.Text = "Fara fire de executie";
            this.button_WithoutThread.UseVisualStyleBackColor = true;
            this.button_WithoutThread.Click += new System.EventHandler(this.button_WithoutThread_Click);
            // 
            // pictureBox_Panel
            // 
            this.pictureBox_Panel.BackColor = System.Drawing.Color.White;
            this.pictureBox_Panel.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Panel.Name = "pictureBox_Panel";
            this.pictureBox_Panel.Size = new System.Drawing.Size(982, 552);
            this.pictureBox_Panel.TabIndex = 2;
            this.pictureBox_Panel.TabStop = false;
            this.pictureBox_Panel.Click += new System.EventHandler(this.pictureBox_Panel_Click);
            // 
            // panel_X1
            // 
            this.panel_X1.BackColor = System.Drawing.Color.Black;
            this.panel_X1.Location = new System.Drawing.Point(0, 276);
            this.panel_X1.Name = "panel_X1";
            this.panel_X1.Size = new System.Drawing.Size(410, 2);
            this.panel_X1.TabIndex = 3;
            // 
            // panel_X2
            // 
            this.panel_X2.BackColor = System.Drawing.Color.Black;
            this.panel_X2.Location = new System.Drawing.Point(569, 276);
            this.panel_X2.Name = "panel_X2";
            this.panel_X2.Size = new System.Drawing.Size(410, 2);
            this.panel_X2.TabIndex = 4;
            // 
            // panel_Y1
            // 
            this.panel_Y1.BackColor = System.Drawing.Color.Black;
            this.panel_Y1.Location = new System.Drawing.Point(491, 0);
            this.panel_Y1.Name = "panel_Y1";
            this.panel_Y1.Size = new System.Drawing.Size(2, 230);
            this.panel_Y1.TabIndex = 5;
            // 
            // panel_Y2
            // 
            this.panel_Y2.BackColor = System.Drawing.Color.Black;
            this.panel_Y2.Location = new System.Drawing.Point(491, 321);
            this.panel_Y2.Name = "panel_Y2";
            this.panel_Y2.Size = new System.Drawing.Size(2, 230);
            this.panel_Y2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel_Y2);
            this.Controls.Add(this.panel_Y1);
            this.Controls.Add(this.panel_X2);
            this.Controls.Add(this.panel_X1);
            this.Controls.Add(this.button_WithoutThread);
            this.Controls.Add(this.button_WithThread);
            this.Controls.Add(this.pictureBox_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Panel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_WithThread;
        private System.Windows.Forms.Button button_WithoutThread;
        private System.Windows.Forms.PictureBox pictureBox_Panel;
        private System.Windows.Forms.Panel panel_X1;
        private System.Windows.Forms.Panel panel_X2;
        private System.Windows.Forms.Panel panel_Y1;
        private System.Windows.Forms.Panel panel_Y2;
    }
}

