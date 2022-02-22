namespace Kongolian_Auto_Clicker
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.Windowbar = new System.Windows.Forms.Panel();
            this.LblAutoClicker = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBIntervel = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.Interval = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.TBClicks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Windowbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // Windowbar
            // 
            this.Windowbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Windowbar.Controls.Add(this.LblAutoClicker);
            this.Windowbar.Location = new System.Drawing.Point(0, 0);
            this.Windowbar.Name = "Windowbar";
            this.Windowbar.Size = new System.Drawing.Size(150, 25);
            this.Windowbar.TabIndex = 0;
            // 
            // LblAutoClicker
            // 
            this.LblAutoClicker.AutoSize = true;
            this.LblAutoClicker.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAutoClicker.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAutoClicker.Location = new System.Drawing.Point(4, 4);
            this.LblAutoClicker.Name = "LblAutoClicker";
            this.LblAutoClicker.Size = new System.Drawing.Size(119, 19);
            this.LblAutoClicker.TabIndex = 0;
            this.LblAutoClicker.Text = "AutoClicker  ";
            this.LblAutoClicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblAutoClicker_MouseDown);
            this.LblAutoClicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblAutoClicker_MouseMove);
            this.LblAutoClicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblAutoClicker_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Location = new System.Drawing.Point(127, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(23, 23);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = " Intervel (MS)";
            // 
            // TBIntervel
            // 
            this.TBIntervel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.TBIntervel.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBIntervel.ForeColor = System.Drawing.Color.White;
            this.TBIntervel.Location = new System.Drawing.Point(10, 57);
            this.TBIntervel.Name = "TBIntervel";
            this.TBIntervel.Size = new System.Drawing.Size(128, 21);
            this.TBIntervel.TabIndex = 2;
            this.TBIntervel.Text = "100";
            this.TBIntervel.TextChanged += new System.EventHandler(this.TBIntervel_TextChanged);
            this.TBIntervel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBIntervel_KeyPress);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirm.Location = new System.Drawing.Point(10, 84);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(126, 31);
            this.BtnConfirm.TabIndex = 3;
            this.BtnConfirm.Text = "Enable";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // Interval
            // 
            this.Interval.Tick += new System.EventHandler(this.Interval_Tick);
            // 
            // Delay
            // 
            this.Delay.Interval = 1000;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // TBClicks
            // 
            this.TBClicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.TBClicks.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBClicks.ForeColor = System.Drawing.Color.White;
            this.TBClicks.Location = new System.Drawing.Point(13, 146);
            this.TBClicks.Name = "TBClicks";
            this.TBClicks.ReadOnly = true;
            this.TBClicks.Size = new System.Drawing.Size(128, 21);
            this.TBClicks.TabIndex = 5;
            this.TBClicks.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clicks:";
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(150, 175);
            this.Controls.Add(this.TBClicks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TBIntervel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.Windowbar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoClicker";
            this.Text = "AutoClicker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AutoClicker_Load);
            this.Windowbar.ResumeLayout(false);
            this.Windowbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Windowbar;
        private System.Windows.Forms.Label LblAutoClicker;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBIntervel;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Timer Interval;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.TextBox TBClicks;
        private System.Windows.Forms.Label label2;
    }
}