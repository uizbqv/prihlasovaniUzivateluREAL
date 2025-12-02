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
            pictureSlot1.Location = new Point(229, 150);
            pictureSlot1.Name = "pictureSlot1";
            pictureSlot1.Size = new Size(113, 106);
            pictureSlot1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot1.TabIndex = 0;
            pictureSlot1.TabStop = false;
            // 
            // pictureSlot2
            // 
            pictureSlot2.Location = new Point(348, 150);
            pictureSlot2.Name = "pictureSlot2";
            pictureSlot2.Size = new Size(113, 106);
            pictureSlot2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot2.TabIndex = 1;
            pictureSlot2.TabStop = false;
            // 
            // pictureSlot3
            // 
            pictureSlot3.Location = new Point(467, 150);
            pictureSlot3.Name = "pictureSlot3";
            pictureSlot3.Size = new Size(113, 106);
            pictureSlot3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSlot3.TabIndex = 2;
            pictureSlot3.TabStop = false;
            // 
            // RerollButton
            // 
            RerollButton.Location = new Point(333, 275);
            RerollButton.Name = "RerollButton";
            RerollButton.Size = new Size(137, 57);
            RerollButton.TabIndex = 3;
            RerollButton.Text = "Reroll";
            RerollButton.UseVisualStyleBackColor = true;
            RerollButton.Click += RerollButton_Click;
            // 
            // NumberOfFunds
            // 
            NumberOfFunds.Font = new Font("Times New Roman", 14.25F);
            NumberOfFunds.Location = new Point(12, 309);
            NumberOfFunds.Name = "NumberOfFunds";
            NumberOfFunds.ReadOnly = true;
            NumberOfFunds.Size = new Size(100, 29);
            NumberOfFunds.TabIndex = 4;
            NumberOfFunds.Text = "1000";
            // 
            // JustTextTextbox1
            // 
            JustTextTextbox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            JustTextTextbox1.Location = new Point(12, 268);
            JustTextTextbox1.Name = "JustTextTextbox1";
            JustTextTextbox1.ReadOnly = true;
            JustTextTextbox1.Size = new Size(100, 35);
            JustTextTextbox1.TabIndex = 5;
            JustTextTextbox1.Text = "Funds:";
            // 
            // JustTextTextbox2
            // 
            JustTextTextbox2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            JustTextTextbox2.Location = new Point(659, 268);
            JustTextTextbox2.Name = "JustTextTextbox2";
            JustTextTextbox2.ReadOnly = true;
            JustTextTextbox2.Size = new Size(128, 35);
            JustTextTextbox2.TabIndex = 6;
            JustTextTextbox2.Text = "Investment:";
            // 
            // Investment
            // 
            Investment.Font = new Font("Times New Roman", 14.25F);
            Investment.Location = new Point(659, 315);
            Investment.Name = "Investment";
            Investment.Size = new Size(128, 29);
            Investment.TabIndex = 7;
            Investment.Text = "0";
            Investment.TextAlign = HorizontalAlignment.Right;
            // 
            // GambleVýsledek
            // 
            GambleVýsledek.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            GambleVýsledek.Location = new Point(229, 102);
            GambleVýsledek.Name = "GambleVýsledek";
            GambleVýsledek.ReadOnly = true;
            GambleVýsledek.Size = new Size(351, 35);
            GambleVýsledek.TabIndex = 8;
            GambleVýsledek.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(12, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Mine";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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