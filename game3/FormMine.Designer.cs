namespace game3
{
    partial class FormMine
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
            labelOre = new Label();
            textBoxSellOre = new TextBox();
            buttonSell = new Button();
            labelWorker = new Label();
            buttonBuy = new Button();
            SuspendLayout();
            // 
            // labelOre
            // 
            labelOre.AutoSize = true;
            labelOre.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOre.Location = new Point(174, 18);
            labelOre.Name = "labelOre";
            labelOre.Size = new Size(96, 38);
            labelOre.TabIndex = 0;
            labelOre.Text = "Ore: ";
            // 
            // textBoxSellOre
            // 
            textBoxSellOre.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSellOre.Location = new Point(12, 59);
            textBoxSellOre.Name = "textBoxSellOre";
            textBoxSellOre.Size = new Size(253, 45);
            textBoxSellOre.TabIndex = 1;
            // 
            // buttonSell
            // 
            buttonSell.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSell.Location = new Point(271, 59);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(135, 45);
            buttonSell.TabIndex = 2;
            buttonSell.Text = "Sell";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += buttonSell_Click;
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWorker.Location = new Point(135, 116);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(159, 38);
            labelWorker.TabIndex = 3;
            labelWorker.Text = "Worker:";
            // 
            // buttonBuy
            // 
            buttonBuy.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuy.Location = new Point(66, 168);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(287, 45);
            buttonBuy.TabIndex = 4;
            buttonBuy.Text = "Buy 300$";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // FormMine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 225);
            Controls.Add(buttonBuy);
            Controls.Add(labelWorker);
            Controls.Add(buttonSell);
            Controls.Add(textBoxSellOre);
            Controls.Add(labelOre);
            Name = "FormMine";
            Text = "FormMine";
            Load += FormMine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOre;
        private TextBox textBoxSellOre;
        private Button buttonSell;
        private Label labelWorker;
        private Button buttonBuy;
    }
}