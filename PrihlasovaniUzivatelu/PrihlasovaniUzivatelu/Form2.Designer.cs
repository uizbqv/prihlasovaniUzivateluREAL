namespace PrihlasovaniUzivatelu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureSlot1 = new PictureBox();
            pictureSlot2 = new PictureBox();
            pictureSlot3 = new PictureBox();
            RerollButton = new Button();
            NumberOfFunds = new TextBox();
            JustTextTextbox1 = new TextBox();
            JustTextTextbox2 = new TextBox();
            Investment = new TextBox();
            GambleVýsledek = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureSlot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot3).BeginInit();
            SuspendLayout();
            // 
            // pictureSlot1
            // 
            pictureSlot1.Location = new Point(327, 250);
            pictureSlot1.Margin = new Padding(4, 5, 4, 5);
            pictureSlot1.Name = "pictureSlot1";
            pictureSlot1.Size = new Size(161, 177);
            pictureSlot1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot1.TabIndex = 0;
            pictureSlot1.TabStop = false;
            // 
            // pictureSlot2
            // 
            pictureSlot2.Location = new Point(497, 250);
            pictureSlot2.Margin = new Padding(4, 5, 4, 5);
            pictureSlot2.Name = "pictureSlot2";
            pictureSlot2.Size = new Size(161, 177);
            pictureSlot2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot2.TabIndex = 1;
            pictureSlot2.TabStop = false;
            // 
            // pictureSlot3
            // 
            pictureSlot3.Location = new Point(667, 250);
            pictureSlot3.Margin = new Padding(4, 5, 4, 5);
            pictureSlot3.Name = "pictureSlot3";
            pictureSlot3.Size = new Size(161, 177);
            pictureSlot3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot3.TabIndex = 2;
            pictureSlot3.TabStop = false;
            // 
            // RerollButton
            // 
            RerollButton.BackColor = Color.Transparent;
            RerollButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            RerollButton.ForeColor = Color.Black;
            RerollButton.Location = new Point(476, 458);
            RerollButton.Margin = new Padding(4, 5, 4, 5);
            RerollButton.Name = "RerollButton";
            RerollButton.Size = new Size(196, 95);
            RerollButton.TabIndex = 3;
            RerollButton.Text = "Reroll";
            RerollButton.UseVisualStyleBackColor = false;
            RerollButton.Click += RerollButton_Click;
            // 
            // NumberOfFunds
            // 
            NumberOfFunds.Font = new Font("Times New Roman", 14.25F);
            NumberOfFunds.Location = new Point(17, 515);
            NumberOfFunds.Margin = new Padding(4, 5, 4, 5);
            NumberOfFunds.Name = "NumberOfFunds";
            NumberOfFunds.ReadOnly = true;
            NumberOfFunds.Size = new Size(141, 40);
            NumberOfFunds.TabIndex = 4;
            NumberOfFunds.Text = "1000";
            // 
            // JustTextTextbox1
            // 
            JustTextTextbox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            JustTextTextbox1.Location = new Point(17, 447);
            JustTextTextbox1.Margin = new Padding(4, 5, 4, 5);
            JustTextTextbox1.Name = "JustTextTextbox1";
            JustTextTextbox1.ReadOnly = true;
            JustTextTextbox1.Size = new Size(141, 55);
            JustTextTextbox1.TabIndex = 5;
            JustTextTextbox1.Text = "Funds:";
            // 
            // JustTextTextbox2
            // 
            JustTextTextbox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            JustTextTextbox2.Location = new Point(911, 447);
            JustTextTextbox2.Margin = new Padding(4, 5, 4, 5);
            JustTextTextbox2.Name = "JustTextTextbox2";
            JustTextTextbox2.ReadOnly = true;
            JustTextTextbox2.Size = new Size(211, 55);
            JustTextTextbox2.TabIndex = 6;
            JustTextTextbox2.Text = "Investment:";
            // 
            // Investment
            // 
            Investment.Font = new Font("Times New Roman", 14.25F);
            Investment.Location = new Point(941, 525);
            Investment.Margin = new Padding(4, 5, 4, 5);
            Investment.Name = "Investment";
            Investment.Size = new Size(181, 40);
            Investment.TabIndex = 7;
            Investment.Text = "0";
            Investment.TextAlign = HorizontalAlignment.Right;
            // 
            // GambleVýsledek
            // 
            GambleVýsledek.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            GambleVýsledek.Location = new Point(327, 170);
            GambleVýsledek.Margin = new Padding(4, 5, 4, 5);
            GambleVýsledek.Name = "GambleVýsledek";
            GambleVýsledek.ReadOnly = true;
            GambleVýsledek.Size = new Size(500, 53);
            GambleVýsledek.TabIndex = 8;
            GambleVýsledek.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(17, 670);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 9;
            button1.Text = "Mine";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(GambleVýsledek);
            Controls.Add(Investment);
            Controls.Add(JustTextTextbox2);
            Controls.Add(JustTextTextbox1);
            Controls.Add(NumberOfFunds);
            Controls.Add(RerollButton);
            Controls.Add(pictureSlot3);
            Controls.Add(pictureSlot2);
            Controls.Add(pictureSlot1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Good luck!";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureSlot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSlot3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureSlot1;
        private PictureBox pictureSlot2;
        private PictureBox pictureSlot3;
        private Button RerollButton;
        private TextBox NumberOfFunds;
        private TextBox JustTextTextbox1;
        private TextBox JustTextTextbox2;
        private TextBox Investment;
        private TextBox GambleVýsledek;
        private Button button1;
    }
}