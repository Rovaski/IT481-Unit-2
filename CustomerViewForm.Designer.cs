
namespace IT481_Unit_2
{
    partial class CustomerViewForm
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
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.connectionStatusValue = new System.Windows.Forms.Label();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.loadDatabaseButton = new System.Windows.Forms.Button();
            this.CustomerCountLabel = new System.Windows.Forms.Label();
            this.CustomerCountValue = new System.Windows.Forms.Label();
            this.CustomerCountUpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(12, 9);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(97, 13);
            this.connectionStatusLabel.TabIndex = 0;
            this.connectionStatusLabel.Text = "Connection Status:";
            // 
            // connectionStatusValue
            // 
            this.connectionStatusValue.AutoSize = true;
            this.connectionStatusValue.ForeColor = System.Drawing.Color.Green;
            this.connectionStatusValue.Location = new System.Drawing.Point(105, 9);
            this.connectionStatusValue.Name = "connectionStatusValue";
            this.connectionStatusValue.Size = new System.Drawing.Size(37, 13);
            this.connectionStatusValue.TabIndex = 1;
            this.connectionStatusValue.Text = "Status";
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(12, 38);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.Size = new System.Drawing.Size(776, 209);
            this.CustomerGridView.TabIndex = 2;
            // 
            // loadDatabaseButton
            // 
            this.loadDatabaseButton.Location = new System.Drawing.Point(697, 4);
            this.loadDatabaseButton.Name = "loadDatabaseButton";
            this.loadDatabaseButton.Size = new System.Drawing.Size(91, 23);
            this.loadDatabaseButton.TabIndex = 3;
            this.loadDatabaseButton.Text = "Load Database";
            this.loadDatabaseButton.UseVisualStyleBackColor = true;
            this.loadDatabaseButton.Click += new System.EventHandler(this.loadDatabaseButton_Click);
            // 
            // CustomerCountLabel
            // 
            this.CustomerCountLabel.AutoSize = true;
            this.CustomerCountLabel.Location = new System.Drawing.Point(12, 22);
            this.CustomerCountLabel.MinimumSize = new System.Drawing.Size(97, 0);
            this.CustomerCountLabel.Name = "CustomerCountLabel";
            this.CustomerCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerCountLabel.Size = new System.Drawing.Size(97, 13);
            this.CustomerCountLabel.TabIndex = 4;
            this.CustomerCountLabel.Text = "Customer Count:";
            this.CustomerCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CustomerCountValue
            // 
            this.CustomerCountValue.AutoSize = true;
            this.CustomerCountValue.Location = new System.Drawing.Point(105, 22);
            this.CustomerCountValue.Name = "CustomerCountValue";
            this.CustomerCountValue.Size = new System.Drawing.Size(28, 13);
            this.CustomerCountValue.TabIndex = 5;
            this.CustomerCountValue.Text = "XXX";
            // 
            // CustomerCountUpdateButton
            // 
            this.CustomerCountUpdateButton.Location = new System.Drawing.Point(600, 4);
            this.CustomerCountUpdateButton.Name = "CustomerCountUpdateButton";
            this.CustomerCountUpdateButton.Size = new System.Drawing.Size(91, 23);
            this.CustomerCountUpdateButton.TabIndex = 6;
            this.CustomerCountUpdateButton.Text = "Customer Count";
            this.CustomerCountUpdateButton.UseVisualStyleBackColor = true;
            this.CustomerCountUpdateButton.Click += new System.EventHandler(this.CustomerCountUpdateButton_Click);
            // 
            // CustomerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 256);
            this.Controls.Add(this.CustomerCountUpdateButton);
            this.Controls.Add(this.CustomerCountValue);
            this.Controls.Add(this.CustomerCountLabel);
            this.Controls.Add(this.loadDatabaseButton);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.connectionStatusValue);
            this.Controls.Add(this.connectionStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT481 Unit 2 Customer View";
            this.Load += new System.EventHandler(this.CustomerViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label connectionStatusValue;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Button loadDatabaseButton;
        private System.Windows.Forms.Label CustomerCountLabel;
        private System.Windows.Forms.Label CustomerCountValue;
        private System.Windows.Forms.Button CustomerCountUpdateButton;
    }
}

