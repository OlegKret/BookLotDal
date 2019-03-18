namespace Test
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
            this.repoSalesBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.repoSalesBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repoSalesBookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.repoSalesBookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repoSalesBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSalesBookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSalesBookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSalesBookBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // repoSalesBookBindingSource
            // 
            this.repoSalesBookBindingSource.DataSource = typeof(BookLotDal.Repos.RepoSalesBook);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.repoSalesBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(290, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // repoSalesBookBindingSource1
            // 
            this.repoSalesBookBindingSource1.DataSource = typeof(BookLotDal.Repos.RepoSalesBook);
            // 
            // contextDataGridViewTextBoxColumn
            // 
            this.contextDataGridViewTextBoxColumn.DataPropertyName = "Context";
            this.contextDataGridViewTextBoxColumn.HeaderText = "Context";
            this.contextDataGridViewTextBoxColumn.Name = "contextDataGridViewTextBoxColumn";
            this.contextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repoSalesBookBindingSource2
            // 
            this.repoSalesBookBindingSource2.DataSource = typeof(BookLotDal.Repos.RepoSalesBook);
            // 
            // repoSalesBookBindingSource3
            // 
            this.repoSalesBookBindingSource3.DataSource = typeof(BookLotDal.Repos.RepoSalesBook);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.repoSalesBookBindingSource2, "Context", true));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repoSalesBookBindingSource3, "Context", true));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repoSalesBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSalesBookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSalesBookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSalesBookBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource repoSalesBookBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource repoSalesBookBindingSource1;
        private System.Windows.Forms.BindingSource repoSalesBookBindingSource2;
        private System.Windows.Forms.BindingSource repoSalesBookBindingSource3;
    }
}

