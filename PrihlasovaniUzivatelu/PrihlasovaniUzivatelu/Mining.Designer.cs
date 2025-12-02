namespace PrihlasovaniUzivatelu
{
    partial class Mining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mining));
            button1 = new Button();
            textBox1 = new TextBox();
            Funds = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Times New Roman", 72F, FontStyle.Bold);
            button1.Location = new Point(122, 42);
            button1.Name = "button1";
            button1.Size = new Size(571, 303);
            button1.TabIndex = 0;
            button1.Text = "MINE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(12, 351);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(128, 33);
            textBox1.TabIndex = 1;
            textBox1.Text = "Mined Funds:";
            // 
            // Funds
            // 
            Funds.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Funds.Location = new Point(12, 389);
            Funds.Name = "Funds";
            Funds.ReadOnly = true;
            Funds.Size = new Size(100, 29);
            Funds.TabIndex = 2;
            Funds.Text = "0";
            // 
            // Mining
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(Funds);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Mining";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Keep on mining!!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox Funds;
    }
}