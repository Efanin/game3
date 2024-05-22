namespace game3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBoxIronMine = new PictureBox();
            labelBalance = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxCoalMine = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIronMine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoalMine).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIronMine
            // 
            pictureBoxIronMine.Image = Resource1.IronMine;
            pictureBoxIronMine.Location = new Point(117, 137);
            pictureBoxIronMine.Name = "pictureBoxIronMine";
            pictureBoxIronMine.Size = new Size(184, 141);
            pictureBoxIronMine.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIronMine.TabIndex = 0;
            pictureBoxIronMine.TabStop = false;
            pictureBoxIronMine.Click += pictureBoxIronMine_Click;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalance.Location = new Point(12, 9);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(244, 38);
            labelBalance.TabIndex = 1;
            labelBalance.Text = "Balance: 100$";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBoxCoalMine
            // 
            pictureBoxCoalMine.Image = Resource1.CoalMine;
            pictureBoxCoalMine.Location = new Point(366, 137);
            pictureBoxCoalMine.Name = "pictureBoxCoalMine";
            pictureBoxCoalMine.Size = new Size(184, 141);
            pictureBoxCoalMine.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCoalMine.TabIndex = 0;
            pictureBoxCoalMine.TabStop = false;
            pictureBoxCoalMine.Click += pictureBoxCoalMine_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 631);
            Controls.Add(labelBalance);
            Controls.Add(pictureBoxCoalMine);
            Controls.Add(pictureBoxIronMine);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIronMine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoalMine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIronMine;
        private Label labelBalance;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBoxCoalMine;
    }
}
