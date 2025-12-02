namespace PrihlasovaniUzivatelu
{
    partial class Infinite_Craftsino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infinite_Craftsino));
            GambleVýsledek = new TextBox();
            RerollButton = new Button();
            pictureSlot3 = new PictureBox();
            pictureSlot2 = new PictureBox();
            pictureSlot1 = new PictureBox();
            JustTextTextbox1 = new TextBox();
            NumberOfFunds = new TextBox();
            Investment = new TextBox();
            JustTextTextbox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureSlot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GambleVýsledek
            // 
            GambleVýsledek.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            GambleVýsledek.Location = new Point(225, 110);
            GambleVýsledek.Name = "GambleVýsledek";
            GambleVýsledek.ReadOnly = true;
            GambleVýsledek.Size = new Size(351, 35);
            GambleVýsledek.TabIndex = 13;
            GambleVýsledek.TextAlign = HorizontalAlignment.Center;
            // 
            // RerollButton
            // 
            RerollButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            RerollButton.Location = new Point(329, 283);
            RerollButton.Name = "RerollButton";
            RerollButton.Size = new Size(137, 57);
            RerollButton.TabIndex = 12;
            RerollButton.Text = "Reroll";
            RerollButton.UseVisualStyleBackColor = true;
            // 
            // pictureSlot3
            // 
            pictureSlot3.Location = new Point(463, 158);
            pictureSlot3.Name = "pictureSlot3";
            pictureSlot3.Size = new Size(113, 106);
            pictureSlot3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot3.TabIndex = 11;
            pictureSlot3.TabStop = false;
            // 
            // pictureSlot2
            // 
            pictureSlot2.Location = new Point(344, 158);
            pictureSlot2.Name = "pictureSlot2";
            pictureSlot2.Size = new Size(113, 106);
            pictureSlot2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot2.TabIndex = 10;
            pictureSlot2.TabStop = false;
            // 
            // pictureSlot1
            // 
            pictureSlot1.Location = new Point(225, 158);
            pictureSlot1.Name = "pictureSlot1";
            pictureSlot1.Size = new Size(113, 106);
            pictureSlot1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot1.TabIndex = 9;
            pictureSlot1.TabStop = false;
            // 
            // JustTextTextbox1
            // 
            JustTextTextbox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            JustTextTextbox1.Location = new Point(12, 305);
            JustTextTextbox1.Name = "JustTextTextbox1";
            JustTextTextbox1.ReadOnly = true;
            JustTextTextbox1.Size = new Size(100, 39);
            JustTextTextbox1.TabIndex = 15;
            JustTextTextbox1.Text = "Funds:";
            // 
            // NumberOfFunds
            // 
            NumberOfFunds.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NumberOfFunds.Location = new Point(12, 346);
            NumberOfFunds.Name = "NumberOfFunds";
            NumberOfFunds.ReadOnly = true;
            NumberOfFunds.Size = new Size(100, 33);
            NumberOfFunds.TabIndex = 14;
            NumberOfFunds.Text = "100000";
            // 
            // Investment
            // 
            Investment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Investment.Location = new Point(660, 352);
            Investment.Name = "Investment";
            Investment.Size = new Size(128, 33);
            Investment.TabIndex = 17;
            Investment.Text = "0";
            Investment.TextAlign = HorizontalAlignment.Right;
            // 
            // JustTextTextbox2
            // 
            JustTextTextbox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            JustTextTextbox2.Location = new Point(660, 305);
            JustTextTextbox2.Name = "JustTextTextbox2";
            JustTextTextbox2.ReadOnly = true;
            JustTextTextbox2.Size = new Size(128, 35);
            JustTextTextbox2.TabIndex = 16;
            JustTextTextbox2.Text = "Investment:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(12, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 33);
            textBox1.TabIndex = 18;
            textBox1.Text = "As The House you can only gain money not lose them";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.backButton;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Infinite_Craftsino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(Investment);
            Controls.Add(JustTextTextbox2);
            Controls.Add(JustTextTextbox1);
            Controls.Add(NumberOfFunds);
            Controls.Add(GambleVýsledek);
            Controls.Add(RerollButton);
            Controls.Add(pictureSlot3);
            Controls.Add(pictureSlot2);
            Controls.Add(pictureSlot1);
            Name = "Infinite_Craftsino";
            Text = "House always wins";
            ((System.ComponentModel.ISupportInitialize)pictureSlot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox GambleVýsledek;
        private Button RerollButton;
        private PictureBox pictureSlot3;
        private PictureBox pictureSlot2;
        private PictureBox pictureSlot1;
        private TextBox JustTextTextbox1;
        private TextBox NumberOfFunds;
        private TextBox Investment;
        private TextBox JustTextTextbox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}