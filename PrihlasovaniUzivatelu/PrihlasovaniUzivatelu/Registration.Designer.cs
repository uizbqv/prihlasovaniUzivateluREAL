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
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 242);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 13;
            label4.Text = "Password again";
            // 
            // passwordAgainBOX
            // 
            passwordAgainBOX.Location = new Point(383, 261);
            passwordAgainBOX.Margin = new Padding(4, 3, 4, 3);
            passwordAgainBOX.Name = "passwordAgainBOX";
            passwordAgainBOX.Size = new Size(125, 23);
            passwordAgainBOX.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 187);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // passwordBOX
            // 
            passwordBOX.Location = new Point(383, 205);
            passwordBOX.Margin = new Padding(4, 3, 4, 3);
            passwordBOX.Name = "passwordBOX";
            passwordBOX.Size = new Size(125, 23);
            passwordBOX.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 8;
            label1.Text = "REGISTER NOW ";
            // 
            // usernameBOX
            // 
            usernameBOX.Location = new Point(383, 150);
            usernameBOX.Margin = new Padding(4, 3, 4, 3);
            usernameBOX.Name = "usernameBOX";
            usernameBOX.Size = new Size(125, 23);
            usernameBOX.TabIndex = 7;
            // 
            // registerBUTTON
            // 
            registerBUTTON.Location = new Point(407, 320);
            registerBUTTON.Name = "registerBUTTON";
            registerBUTTON.Size = new Size(75, 23);
            registerBUTTON.TabIndex = 14;
            registerBUTTON.Text = "Register!";
            registerBUTTON.UseVisualStyleBackColor = true;
            registerBUTTON.Click += registerBUTTON_Click;
            // 
            // dontMatchLABEL
            // 
            dontMatchLABEL.AutoSize = true;
            dontMatchLABEL.ForeColor = Color.Red;
            dontMatchLABEL.Location = new Point(529, 264);
            dontMatchLABEL.Margin = new Padding(4, 0, 4, 0);
            dontMatchLABEL.Name = "dontMatchLABEL";
            dontMatchLABEL.Size = new Size(130, 15);
            dontMatchLABEL.TabIndex = 15;
            dontMatchLABEL.Text = "Passwords don't match";
            dontMatchLABEL.Visible = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dontMatchLABEL);
            Controls.Add(registerBUTTON);
            Controls.Add(label4);
            Controls.Add(passwordAgainBOX);
            Controls.Add(label3);
            Controls.Add(passwordBOX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameBOX);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registration";
            Text = "Registrace";
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
    }
}