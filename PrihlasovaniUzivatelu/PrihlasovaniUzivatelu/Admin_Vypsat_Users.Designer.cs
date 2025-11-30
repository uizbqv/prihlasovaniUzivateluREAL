namespace PrihlasovaniUzivatelu
{
    partial class Admin_Vypsat_Users
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
            button1 = new Button();
            UsersListBox = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(329, 388);
            button1.Name = "button1";
            button1.Size = new Size(138, 50);
            button1.TabIndex = 0;
            button1.Text = "Show users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UsersListBox
            // 
            UsersListBox.FormattingEnabled = true;
            UsersListBox.ItemHeight = 15;
            UsersListBox.Location = new Point(103, 111);
            UsersListBox.Name = "UsersListBox";
            UsersListBox.Size = new Size(607, 244);
            UsersListBox.TabIndex = 2;
            // 
            // Admin_Vypsat_Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UsersListBox);
            Controls.Add(button1);
            Name = "Admin_Vypsat_Users";
            Text = "Admin_Vypsat_Users";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox UsersListBox;
    }
}