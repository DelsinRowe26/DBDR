
namespace DBDR
{
    partial class Form2
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
            this.delsinRowe26DataSet = new DBDR.DelsinRowe26DataSet();
            this.delsinRowe26DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delsinRowe26DataSet1 = new DBDR.DelsinRowe26DataSet1();
            this.delsinRowe26DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.drTableTableAdapter1 = new DBDR.DelsinRowe26DataSetTableAdapters.DRTableTableAdapter();
            this.dRTableTableAdapter = new DBDR.DelsinRowe26DataSet1TableAdapters.DRTableTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.delsinRowe26DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delsinRowe26DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delsinRowe26DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delsinRowe26DataSetBindingSource1)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // delsinRowe26DataSet
            // 
            this.delsinRowe26DataSet.DataSetName = "DelsinRowe26DataSet";
            this.delsinRowe26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delsinRowe26DataSetBindingSource
            // 
            this.delsinRowe26DataSetBindingSource.DataSource = this.delsinRowe26DataSet;
            this.delsinRowe26DataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dRTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // dRTableBindingSource
            // 
            this.dRTableBindingSource.DataMember = "DRTable";
            this.dRTableBindingSource.DataSource = this.delsinRowe26DataSet1;
            // 
            // delsinRowe26DataSet1
            // 
            this.delsinRowe26DataSet1.DataSetName = "DelsinRowe26DataSet1";
            this.delsinRowe26DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delsinRowe26DataSetBindingSource1
            // 
            this.delsinRowe26DataSetBindingSource1.DataSource = this.delsinRowe26DataSet;
            this.delsinRowe26DataSetBindingSource1.Position = 0;
            // 
            // drTableTableAdapter1
            // 
            this.drTableTableAdapter1.ClearBeforeFill = true;
            // 
            // dRTableTableAdapter
            // 
            this.dRTableTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(464, 25);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "User",
            "DRTabel"});
            this.comboBox1.Location = new System.Drawing.Point(13, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 318);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delsinRowe26DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delsinRowe26DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delsinRowe26DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delsinRowe26DataSetBindingSource1)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DelsinRowe26DataSet delsinRowe26DataSet;
        public System.Windows.Forms.BindingSource delsinRowe26DataSetBindingSource;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource delsinRowe26DataSetBindingSource1;
        public DelsinRowe26DataSetTableAdapters.DRTableTableAdapter drTableTableAdapter1;
        public DelsinRowe26DataSet1 delsinRowe26DataSet1;
        public System.Windows.Forms.BindingSource dRTableBindingSource;
        public DelsinRowe26DataSet1TableAdapters.DRTableTableAdapter dRTableTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        public System.Windows.Forms.ToolStrip fillToolStrip;
        public System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}