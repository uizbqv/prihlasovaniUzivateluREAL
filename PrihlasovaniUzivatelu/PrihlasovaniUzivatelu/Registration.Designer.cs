namespace PrihlasovaniUzivatelu
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            label4 = new Label();
            passwordAgainBOX = new TextBox();
            label3 = new Label();
            passwordBOX = new TextBox();
            label2 = new Label();
            label1 = new Label();
            usernameBOX = new TextBox();
            registerBUTTON = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dontMatchLABEL = new Label();
            pictureBox1 = new PictureBox();
            notStrongEnoughLabel = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(547, 395);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 13;
            label4.Text = "Password again";
            // 
            // passwordAgainBOX
            // 
            passwordAgainBOX.Location = new Point(547, 435);
            passwordAgainBOX.Margin = new Padding(6, 5, 6, 5);
            passwordAgainBOX.Name = "passwordAgainBOX";
            passwordAgainBOX.Size = new Size(177, 31);
            passwordAgainBOX.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(547, 302);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // passwordBOX
            // 
            passwordBOX.Location = new Point(547, 342);
            passwordBOX.Margin = new Padding(6, 5, 6, 5);
            passwordBOX.Name = "passwordBOX";
            passwordBOX.Size = new Size(177, 31);
            passwordBOX.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(547, 212);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(529, 143);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 40);
            label1.TabIndex = 8;
            label1.Text = "REGISTER NOW ";
            // 
            // usernameBOX
            // 
            usernameBOX.Location = new Point(547, 250);
            usernameBOX.Margin = new Padding(6, 5, 6, 5);
            usernameBOX.Name = "usernameBOX";
            usernameBOX.Size = new Size(177, 31);
            usernameBOX.TabIndex = 7;
            // 
            // registerBUTTON
            // 
            registerBUTTON.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            registerBUTTON.Location = new Point(561, 493);
            registerBUTTON.Margin = new Padding(4, 5, 4, 5);
            registerBUTTON.Name = "registerBUTTON";
            registerBUTTON.Size = new Size(144, 54);
            registerBUTTON.TabIndex = 14;
            registerBUTTON.Text = "Register!";
            registerBUTTON.UseVisualStyleBackColor = true;
            registerBUTTON.Click += registerBUTTON_Click;
            // 
            // dontMatchLABEL
            // 
            dontMatchLABEL.AutoSize = true;
            dontMatchLABEL.BackColor = Color.Transparent;
            dontMatchLABEL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dontMatchLABEL.ForeColor = Color.Red;
            dontMatchLABEL.Location = new Point(766, 435);
            dontMatchLABEL.Margin = new Padding(6, 0, 6, 0);
            dontMatchLABEL.Name = "dontMatchLABEL";
            dontMatchLABEL.Size = new Size(277, 32);
            dontMatchLABEL.TabIndex = 15;
            dontMatchLABEL.Text = "Passwords don't match";
            dontMatchLABEL.Visible = false;
            dontMatchLABEL.Click += dontMatchLABEL_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.backButton;
            pictureBox1.Location = new Point(36, 38);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // notStrongEnoughLabel
            // 
            notStrongEnoughLabel.AutoSize = true;
            notStrongEnoughLabel.BackColor = Color.Transparent;
            notStrongEnoughLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            notStrongEnoughLabel.ForeColor = Color.Red;
            notStrongEnoughLabel.Location = new Point(766, 339);
            notStrongEnoughLabel.Margin = new Padding(6, 0, 6, 0);
            notStrongEnoughLabel.Name = "notStrongEnoughLabel";
            notStrongEnoughLabel.Size = new Size(353, 32);
            notStrongEnoughLabel.TabIndex = 17;
            notStrongEnoughLabel.Text = "Password isn't strong enough";
            notStrongEnoughLabel.Visible = false;
            notStrongEnoughLabel.Click += NotStrongEnoughLabel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(126, 824);
            label5.Name = "label5";
            label5.Size = new Size(1117, 32);
            label5.TabIndex = 18;
            label5.Text = "Use at least 1 uppercase character, 1 number, 1 special character and is at least 8 characters long";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1333, 865);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(notStrongEnoughLabel);
            Controls.Add(pictureBox1);
            Controls.Add(dontMatchLABEL);
            Controls.Add(registerBUTTON);
            Controls.Add(label4);
            Controls.Add(passwordAgainBOX);
            Controls.Add(label3);
            Controls.Add(passwordBOX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameBOX);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox passwordAgainBOX;
        private Label label3;
        private TextBox passwordBOX;
        private Label label2;
        private Label label1;
        private TextBox usernameBOX;
        private Button registerBUTTON;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label dontMatchLABEL;
        private PictureBox pictureBox1;
        private Label notStrongEnoughLabel;
        private Label label5;
    }
}