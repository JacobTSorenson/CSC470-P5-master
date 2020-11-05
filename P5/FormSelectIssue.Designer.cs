namespace Builder
{
    partial class FormSelectIssue
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscoveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discoverer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.DiscoveryDate,
            this.Discoverer,
            this.InitialDescription,
            this.Component,
            this.Status});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(814, 315);
            this.dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 175;
            // 
            // DiscoveryDate
            // 
            this.DiscoveryDate.HeaderText = "Discovery Date";
            this.DiscoveryDate.Name = "DiscoveryDate";
            this.DiscoveryDate.Width = 150;
            // 
            // Discoverer
            // 
            this.Discoverer.HeaderText = "Discoverer";
            this.Discoverer.Name = "Discoverer";
            this.Discoverer.Width = 104;
            // 
            // InitialDescription
            // 
            this.InitialDescription.HeaderText = "Initial Description";
            this.InitialDescription.Name = "InitialDescription";
            this.InitialDescription.Width = 104;
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.Name = "Component";
            this.Component.Width = 104;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 104;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(577, 348);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(721, 348);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(105, 23);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select Issue";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // FormSelectIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 389);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormSelectIssue";
            this.Text = "Select Issue";
            this.Load += new System.EventHandler(this.FormSelectIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscoveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discoverer;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectButton;
    }
}