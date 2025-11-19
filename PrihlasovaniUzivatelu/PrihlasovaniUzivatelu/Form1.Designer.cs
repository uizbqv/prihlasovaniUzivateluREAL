namespace PrihlasovaniUzivatelu
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            usernameBOX1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            passwordBOX1 = new TextBox();
            label4 = new Label();
            registerLABEL = new Label();
            logInBUTTON1 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(257, 50);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(477, 77);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 264);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // usernameBOX1
            // 
            usernameBOX1.Location = new Point(457, 310);
            usernameBOX1.Margin = new Padding(4, 3, 4, 3);
            usernameBOX1.Name = "usernameBOX1";
            usernameBOX1.Size = new Size(116, 23);
            usernameBOX1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(483, 292);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 340);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // passwordBOX1
            // 
            passwordBOX1.Location = new Point(457, 359);
            passwordBOX1.Margin = new Padding(4, 3, 4, 3);
            passwordBOX1.Name = "passwordBOX1";
            passwordBOX1.Size = new Size(116, 23);
            passwordBOX1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 459);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account?";
            // 
            // registerLABEL
            // 
            registerLABEL.AutoSize = true;
            registerLABEL.Cursor = Cursors.Hand;
            registerLABEL.ForeColor = SystemColors.ActiveCaption;
            registerLABEL.Location = new Point(483, 459);
            registerLABEL.Margin = new Padding(4, 0, 4, 0);
            registerLABEL.Name = "registerLABEL";
            registerLABEL.Size = new Size(84, 15);
            registerLABEL.TabIndex = 7;
            registerLABEL.Text = "Register NOW!";
            registerLABEL.Click += registerLABEL_Click;
            // 
            // logInBUTTON1
            // 
            logInBUTTON1.Location = new Point(469, 389);
            logInBUTTON1.Margin = new Padding(4, 3, 4, 3);
            logInBUTTON1.Name = "logInBUTTON1";
            logInBUTTON1.Size = new Size(88, 27);
            logInBUTTON1.TabIndex = 8;
            logInBUTTON1.Text = "Log in";
            logInBUTTON1.UseVisualStyleBackColor = true;
            logInBUTTON1.Click += logInBUTTON1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 487);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "dffsd";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(990, 522);
            Controls.Add(button1);
            Controls.Add(logInBUTTON1);
            Controls.Add(registerLABEL);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passwordBOX1);
            Controls.Add(label2);
            Controls.Add(usernameBOX1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Craftsino";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox usernameBOX1;
        private Label label2;
        private Label label3;
        private TextBox passwordBOX1;
        private Label label4;
        private Label registerLABEL;
        private Button logInBUTTON1;
        private Button button1;
    }
}

