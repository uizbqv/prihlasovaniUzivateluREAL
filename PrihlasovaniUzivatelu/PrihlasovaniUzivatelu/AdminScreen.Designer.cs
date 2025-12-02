namespace PrihlasovaniUzivatelu
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(117, 89);
            button1.Name = "button1";
            button1.Size = new Size(133, 119);
            button1.TabIndex = 0;
            button1.Text = "Infinite Craftsino";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(387, 89);
            button2.Name = "button2";
            button2.Size = new Size(135, 119);
            button2.TabIndex = 1;
            button2.Text = "Users list";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(622, 338);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AdminScreen";
            Text = "Shush, don't show this to anyone else....";
            FormClosed += AdminScreen_FormClosed;
            Load += AdminScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}