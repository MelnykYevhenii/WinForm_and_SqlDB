
namespace SqlLoginFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.body = new System.Windows.Forms.Panel();
            this.underWelcomeLbl = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Label();
            this.authorization_lbl = new System.Windows.Forms.Label();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.body.Controls.Add(this.underWelcomeLbl);
            this.body.Controls.Add(this.signInBtn);
            this.body.Controls.Add(this.passwordField);
            this.body.Controls.Add(this.pictureBox2);
            this.body.Controls.Add(this.loginField);
            this.body.Controls.Add(this.pictureBox1);
            this.body.Controls.Add(this.header);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 0);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(364, 380);
            this.body.TabIndex = 0;
            this.body.MouseDown += new System.Windows.Forms.MouseEventHandler(this.body_MouseDown);
            this.body.MouseMove += new System.Windows.Forms.MouseEventHandler(this.body_MouseMove);
            // 
            // underWelcomeLbl
            // 
            this.underWelcomeLbl.AutoSize = true;
            this.underWelcomeLbl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.underWelcomeLbl.ForeColor = System.Drawing.Color.Gray;
            this.underWelcomeLbl.Location = new System.Drawing.Point(41, 112);
            this.underWelcomeLbl.Name = "underWelcomeLbl";
            this.underWelcomeLbl.Size = new System.Drawing.Size(294, 14);
            this.underWelcomeLbl.TabIndex = 7;
            this.underWelcomeLbl.Text = "Sign in by entering the information below";
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(121)))), ((int)(((byte)(245)))));
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.Font = new System.Drawing.Font("Consolas", 18F);
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(44, 252);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(291, 58);
            this.signInBtn.TabIndex = 5;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(80, 192);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(255, 29);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SqlLoginFormApp.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(44, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.AccessibleDescription = "";
            this.loginField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(80, 155);
            this.loginField.MaxLength = 16;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(255, 29);
            this.loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SqlLoginFormApp.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(44, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.header.Controls.Add(this.closeBtn);
            this.header.Controls.Add(this.authorization_lbl);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(364, 77);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown_1);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove_1);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(344, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 24);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // authorization_lbl
            // 
            this.authorization_lbl.AutoSize = true;
            this.authorization_lbl.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorization_lbl.Location = new System.Drawing.Point(135, 26);
            this.authorization_lbl.Name = "authorization_lbl";
            this.authorization_lbl.Size = new System.Drawing.Size(116, 28);
            this.authorization_lbl.TabIndex = 0;
            this.authorization_lbl.Text = "Welcome!";
            this.authorization_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 380);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label authorization_lbl;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label underWelcomeLbl;
    }
}

