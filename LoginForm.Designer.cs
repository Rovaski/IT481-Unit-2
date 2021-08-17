
namespace IT481_Unit_2
{
    partial class LoginForm
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasscodeLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasscodeTextBox = new System.Windows.Forms.TextBox();
            this.SubmitLoginButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(9, 41);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasscodeLabel
            // 
            this.PasscodeLabel.AutoSize = true;
            this.PasscodeLabel.Location = new System.Drawing.Point(10, 67);
            this.PasscodeLabel.Name = "PasscodeLabel";
            this.PasscodeLabel.Size = new System.Drawing.Size(57, 13);
            this.PasscodeLabel.TabIndex = 1;
            this.PasscodeLabel.Text = "Passcode:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(73, 38);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(157, 20);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // PasscodeTextBox
            // 
            this.PasscodeTextBox.Location = new System.Drawing.Point(73, 64);
            this.PasscodeTextBox.Name = "PasscodeTextBox";
            this.PasscodeTextBox.PasswordChar = '*';
            this.PasscodeTextBox.Size = new System.Drawing.Size(157, 20);
            this.PasscodeTextBox.TabIndex = 3;
            this.PasscodeTextBox.UseSystemPasswordChar = true;
            // 
            // SubmitLoginButton
            // 
            this.SubmitLoginButton.Location = new System.Drawing.Point(75, 142);
            this.SubmitLoginButton.Name = "SubmitLoginButton";
            this.SubmitLoginButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitLoginButton.TabIndex = 4;
            this.SubmitLoginButton.Text = "Login";
            this.SubmitLoginButton.UseVisualStyleBackColor = true;
            this.SubmitLoginButton.Click += new System.EventHandler(this.SubmitLoginButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(156, 142);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(1, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(241, 24);
            this.InfoLabel.TabIndex = 6;
            this.InfoLabel.Text = "Customer and Sales App";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(22, 93);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(44, 13);
            this.ServerLabel.TabIndex = 7;
            this.ServerLabel.Text = "Server :";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(73, 90);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(157, 20);
            this.ServerTextBox.TabIndex = 8;
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(73, 116);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(157, 20);
            this.DatabaseTextBox.TabIndex = 10;
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(7, 119);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(59, 13);
            this.DatabaseLabel.TabIndex = 9;
            this.DatabaseLabel.Text = "Database :";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 178);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SubmitLoginButton);
            this.Controls.Add(this.PasscodeTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasscodeLabel);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasscodeLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasscodeTextBox;
        private System.Windows.Forms.Button SubmitLoginButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.Label DatabaseLabel;
    }
}