namespace BookLotTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderRepoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderRepoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderRepoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(275, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextDataGridViewTextBoxColumn
            // 
            this.contextDataGridViewTextBoxColumn.DataPropertyName = "Context";
            this.contextDataGridViewTextBoxColumn.HeaderText = "Context";
            this.contextDataGridViewTextBoxColumn.Name = "contextDataGridViewTextBoxColumn";
            this.contextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderRepoBindingSource
            // 
            this.orderRepoBindingSource.DataSource = typeof(BookLotDal.Repos.OrderRepo);
            // 
            // orderRepoBindingSource1
            // 
            this.orderRepoBindingSource1.DataSource = typeof(BookLotDal.Repos.OrderRepo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderRepoBindingSource;
        private System.Windows.Forms.BindingSource orderRepoBindingSource1;
    }
}

