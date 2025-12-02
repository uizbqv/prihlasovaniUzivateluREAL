namespace PrihlasovaniUzivatelu
{
    partial class Button2
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(350, 388);
            button1.Name = "button1";
            button1.Size = new Size(151, 50);
            button1.TabIndex = 0;
            button1.Text = "Show users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UsersListBox
            // 
            UsersListBox.FormattingEnabled = true;
            UsersListBox.ItemHeight = 15;
            UsersListBox.Location = new Point(195, 111);
            UsersListBox.Name = "UsersListBox";
            UsersListBox.Size = new Size(457, 259);
            UsersListBox.TabIndex = 2;
            UsersListBox.SelectedIndexChanged += UsersListBox_SelectedIndexChanged;
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
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Button2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Commands;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(UsersListBox);
            Controls.Add(button1);
            Name = "Button2";
            Text = "Admin_Vypsat_Users";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox UsersListBox;
        private PictureBox pictureBox1;
    }
}