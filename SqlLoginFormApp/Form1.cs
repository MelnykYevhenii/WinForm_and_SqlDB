using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlLoginFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.loginField.AutoSize = false;
            this.loginField.Size = new Size(this.loginField.Size.Width, 30);

            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width, 30);

            signInBtn.MouseEnter += OnMouseEnterButton;
            signInBtn.MouseLeave += OnMouseLeaveButton;
        }
        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            signInBtn.BackColor = Color.FromArgb(66, 212, 40);
        }
        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            signInBtn.BackColor = Color.FromArgb(44, 121, 245);
        }
        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void body_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void body_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void header_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void header_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
       
    }
}
