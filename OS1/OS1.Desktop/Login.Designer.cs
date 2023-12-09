namespace OS1.Desktop
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnLogin = new Button();
            BtnExit = new Button();
            TxtUserName = new TextBox();
            TxtPassword = new TextBox();
            CboDomains = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "UserName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 53);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 91);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Domain:";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(341, 127);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 43);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(422, 127);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 43);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(133, 12);
            TxtUserName.MaxLength = 32;
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(364, 32);
            TxtUserName.TabIndex = 5;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(133, 50);
            TxtPassword.MaxLength = 32;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '^';
            TxtPassword.Size = new Size(364, 32);
            TxtPassword.TabIndex = 6;
            // 
            // CboDomains
            // 
            CboDomains.FormattingEnabled = true;
            CboDomains.Location = new Point(134, 88);
            CboDomains.Name = "CboDomains";
            CboDomains.Size = new Size(363, 33);
            CboDomains.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 182);
            Controls.Add(CboDomains);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserName);
            Controls.Add(BtnExit);
            Controls.Add(BtnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 5, 5, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnLogin;
        private Button BtnExit;
        private TextBox TxtUserName;
        private TextBox TxtPassword;
        private ComboBox CboDomains;
    }
}