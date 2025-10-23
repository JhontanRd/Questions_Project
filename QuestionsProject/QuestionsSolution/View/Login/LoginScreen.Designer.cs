
namespace QuestionsSolution
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PtbLogo = new PictureBox();
            LblUser = new Label();
            TxtUser = new TextBox();
            LblPassword = new Label();
            TxtPassword = new TextBox();
            BtnAccess = new Button();
            BtnCreateUser = new Button();
            ((System.ComponentModel.ISupportInitialize)PtbLogo).BeginInit();
            SuspendLayout();
            // 
            // PtbLogo
            // 
            PtbLogo.BackColor = SystemColors.ControlDark;
            PtbLogo.Location = new Point(297, 33);
            PtbLogo.MaximumSize = new Size(200, 200);
            PtbLogo.MinimumSize = new Size(200, 200);
            PtbLogo.Name = "PtbLogo";
            PtbLogo.Size = new Size(200, 200);
            PtbLogo.TabIndex = 0;
            PtbLogo.TabStop = false;
            // 
            // LblUser
            // 
            LblUser.AutoSize = true;
            LblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblUser.Location = new Point(364, 257);
            LblUser.Name = "LblUser";
            LblUser.Size = new Size(57, 21);
            LblUser.TabIndex = 1;
            LblUser.Text = "Login:";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(269, 281);
            TxtUser.MaxLength = 30;
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(250, 29);
            TxtUser.TabIndex = 2;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblPassword.Location = new Point(364, 324);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(61, 21);
            LblPassword.TabIndex = 3;
            LblPassword.Text = "Senha:";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(269, 348);
            TxtPassword.MaxLength = 16;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(250, 29);
            TxtPassword.TabIndex = 4;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // BtnAccess
            // 
            BtnAccess.Cursor = Cursors.Hand;
            BtnAccess.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnAccess.Location = new Point(276, 403);
            BtnAccess.Name = "BtnAccess";
            BtnAccess.Size = new Size(100, 30);
            BtnAccess.TabIndex = 5;
            BtnAccess.Text = "Entrar";
            BtnAccess.UseVisualStyleBackColor = true;
            BtnAccess.Click += BtnAccess_Click_1;
            // 
            // BtnCreateUser
            // 
            BtnCreateUser.Cursor = Cursors.Hand;
            BtnCreateUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnCreateUser.Location = new Point(415, 403);
            BtnCreateUser.Name = "BtnCreateUser";
            BtnCreateUser.Size = new Size(100, 30);
            BtnCreateUser.TabIndex = 6;
            BtnCreateUser.Text = "Cadastro";
            BtnCreateUser.UseVisualStyleBackColor = true;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(784, 461);
            Controls.Add(BtnCreateUser);
            Controls.Add(BtnAccess);
            Controls.Add(TxtPassword);
            Controls.Add(LblPassword);
            Controls.Add(TxtUser);
            Controls.Add(LblUser);
            Controls.Add(PtbLogo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questions Login";
            ((System.ComponentModel.ISupportInitialize)PtbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnAccess_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox PtbLogo;
        private Label LblUser;
        private TextBox TxtUser;
        private Label LblPassword;
        private TextBox TxtPassword;
        private Button BtnAccess;
        private Button BtnCreateUser;
    }
}
