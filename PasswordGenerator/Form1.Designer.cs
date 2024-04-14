namespace PasswordGenerator
{
    partial class MainForm
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
            this.Header = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.checkBoxIsDuplicateChars = new System.Windows.Forms.CheckBox();
            this.trackBarLengthPassword = new System.Windows.Forms.TrackBar();
            this.checkBoxIsNonLetterChars = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonToGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLengthPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Header.Controls.Add(this.label1);
            this.Header.Controls.Add(this.buttonHide);
            this.Header.Controls.Add(this.buttonExit);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(700, 30);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(670, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // buttonHide
            // 
            this.buttonHide.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHide.FlatAppearance.BorderSize = 0;
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHide.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHide.Location = new System.Drawing.Point(640, 0);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(30, 30);
            this.buttonHide.TabIndex = 1;
            this.buttonHide.Text = "−";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            this.buttonHide.MouseEnter += new System.EventHandler(this.buttonHide_MouseEnter);
            this.buttonHide.MouseLeave += new System.EventHandler(this.buttonHide_MouseLeave);
            // 
            // checkBoxIsDuplicateChars
            // 
            this.checkBoxIsDuplicateChars.Location = new System.Drawing.Point(341, 74);
            this.checkBoxIsDuplicateChars.Name = "checkBoxIsDuplicateChars";
            this.checkBoxIsDuplicateChars.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsDuplicateChars.TabIndex = 0;
            this.checkBoxIsDuplicateChars.UseVisualStyleBackColor = true;
            this.checkBoxIsDuplicateChars.CheckedChanged += new System.EventHandler(this.checkBoxIsDuplicateChars_CheckedChanged);
            // 
            // trackBarLengthPassword
            // 
            this.trackBarLengthPassword.Location = new System.Drawing.Point(331, 178);
            this.trackBarLengthPassword.Maximum = 20;
            this.trackBarLengthPassword.Name = "trackBarLengthPassword";
            this.trackBarLengthPassword.Size = new System.Drawing.Size(281, 56);
            this.trackBarLengthPassword.TabIndex = 3;
            // 
            // checkBoxIsNonLetterChars
            // 
            this.checkBoxIsNonLetterChars.AutoSize = true;
            this.checkBoxIsNonLetterChars.Location = new System.Drawing.Point(341, 128);
            this.checkBoxIsNonLetterChars.Name = "checkBoxIsNonLetterChars";
            this.checkBoxIsNonLetterChars.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsNonLetterChars.TabIndex = 4;
            this.checkBoxIsNonLetterChars.UseVisualStyleBackColor = true;
            this.checkBoxIsNonLetterChars.CheckedChanged += new System.EventHandler(this.checkBoxIsNonLetterChars_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Длина пароля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Специальные символы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(289, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Похожие символы (i, l, 1, L, o, 0, O)";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(214, 329);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(207, 31);
            this.textBoxPassword.TabIndex = 8;
            // 
            // buttonToGenerate
            // 
            this.buttonToGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonToGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToGenerate.Location = new System.Drawing.Point(238, 386);
            this.buttonToGenerate.Name = "buttonToGenerate";
            this.buttonToGenerate.Size = new System.Drawing.Size(159, 51);
            this.buttonToGenerate.TabIndex = 9;
            this.buttonToGenerate.Text = "Сгенерировать";
            this.buttonToGenerate.UseVisualStyleBackColor = false;
            this.buttonToGenerate.Click += new System.EventHandler(this.buttonToGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Генератор паролей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 570);
            this.Controls.Add(this.buttonToGenerate);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxIsNonLetterChars);
            this.Controls.Add(this.trackBarLengthPassword);
            this.Controls.Add(this.checkBoxIsDuplicateChars);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 570);
            this.Name = "MainForm";
            this.Text = "–";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLengthPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.CheckBox checkBoxIsDuplicateChars;
        private System.Windows.Forms.TrackBar trackBarLengthPassword;
        private System.Windows.Forms.CheckBox checkBoxIsNonLetterChars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonToGenerate;
        private System.Windows.Forms.Label label1;
    }
}

