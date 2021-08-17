
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
            this.loadTableButton = new System.Windows.Forms.Button();
            this.CustomerCountLabel = new System.Windows.Forms.Label();
            this.TableCountValue = new System.Windows.Forms.Label();
            this.TableCountUpdateButton = new System.Windows.Forms.Button();
            this.TableSelectionBox = new System.Windows.Forms.ComboBox();
            this.TableSelectionBoxLabel = new System.Windows.Forms.Label();
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
            this.CustomerGridView.Location = new System.Drawing.Point(12, 108);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.Size = new System.Drawing.Size(776, 209);
            this.CustomerGridView.TabIndex = 2;
            // 
            // loadTableButton
            // 
            this.loadTableButton.Location = new System.Drawing.Point(695, 33);
            this.loadTableButton.Name = "loadTableButton";
            this.loadTableButton.Size = new System.Drawing.Size(91, 23);
            this.loadTableButton.TabIndex = 3;
            this.loadTableButton.Text = "Load Table";
            this.loadTableButton.UseVisualStyleBackColor = true;
            this.loadTableButton.Click += new System.EventHandler(this.loadDatabaseButton_Click);
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
            this.CustomerCountLabel.Text = "Table Count:";
            this.CustomerCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TableCountValue
            // 
            this.TableCountValue.AutoSize = true;
            this.TableCountValue.Location = new System.Drawing.Point(105, 22);
            this.TableCountValue.Name = "TableCountValue";
            this.TableCountValue.Size = new System.Drawing.Size(28, 13);
            this.TableCountValue.TabIndex = 5;
            this.TableCountValue.Text = "XXX";
            // 
            // TableCountUpdateButton
            // 
            this.TableCountUpdateButton.Location = new System.Drawing.Point(598, 33);
            this.TableCountUpdateButton.Name = "TableCountUpdateButton";
            this.TableCountUpdateButton.Size = new System.Drawing.Size(91, 23);
            this.TableCountUpdateButton.TabIndex = 6;
            this.TableCountUpdateButton.Text = "Table Count";
            this.TableCountUpdateButton.UseVisualStyleBackColor = true;
            this.TableCountUpdateButton.Click += new System.EventHandler(this.CustomerCountUpdateButton_Click);
            // 
            // TableSelectionBox
            // 
            this.TableSelectionBox.FormattingEnabled = true;
            this.TableSelectionBox.Items.AddRange(new object[] {
            "Customers",
            "Employees",
            "Orders"});
            this.TableSelectionBox.Location = new System.Drawing.Point(665, 6);
            this.TableSelectionBox.Name = "TableSelectionBox";
            this.TableSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.TableSelectionBox.TabIndex = 7;
            this.TableSelectionBox.TextChanged += new System.EventHandler(this.TableSelectionBox_TextChanged);
            // 
            // TableSelectionBoxLabel
            // 
            this.TableSelectionBoxLabel.AutoSize = true;
            this.TableSelectionBoxLabel.Location = new System.Drawing.Point(580, 9);
            this.TableSelectionBoxLabel.Name = "TableSelectionBoxLabel";
            this.TableSelectionBoxLabel.Size = new System.Drawing.Size(79, 13);
            this.TableSelectionBoxLabel.TabIndex = 8;
            this.TableSelectionBoxLabel.Text = "Table to Load :";
            // 
            // CustomerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 327);
            this.Controls.Add(this.TableSelectionBoxLabel);
            this.Controls.Add(this.TableSelectionBox);
            this.Controls.Add(this.TableCountUpdateButton);
            this.Controls.Add(this.TableCountValue);
            this.Controls.Add(this.CustomerCountLabel);
            this.Controls.Add(this.loadTableButton);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.connectionStatusValue);
            this.Controls.Add(this.connectionStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT481 Unit 3 Table Viewer";
            this.Load += new System.EventHandler(this.CustomerViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label connectionStatusValue;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Button loadTableButton;
        private System.Windows.Forms.Label CustomerCountLabel;
        private System.Windows.Forms.Label TableCountValue;
        private System.Windows.Forms.Button TableCountUpdateButton;
        private System.Windows.Forms.ComboBox TableSelectionBox;
        private System.Windows.Forms.Label TableSelectionBoxLabel;
    }
}

