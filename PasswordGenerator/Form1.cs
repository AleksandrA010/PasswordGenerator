using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        private bool isNonLetterChars = false;
        private bool isDuplicateChars = false;

        private Generator generator = new Generator();
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Red;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void buttonHide_MouseEnter(object sender, EventArgs e)
        {
            buttonHide.BackColor = Color.RoyalBlue;
        }

        private void buttonHide_MouseLeave(object sender, EventArgs e)
        {
            buttonHide.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void checkBoxIsNonLetterChars_CheckedChanged(object sender, EventArgs e)
        {
            isNonLetterChars = !isNonLetterChars;

        }

        private void checkBoxIsDuplicateChars_CheckedChanged(object sender, EventArgs e)
        {
            isDuplicateChars = !isDuplicateChars;
        }

        private void buttonToGenerate_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPassword.Text = generator.GeneratePassword(trackBarLengthPassword.Value, isNonLetterChars, isDuplicateChars);
        }
    }
}
