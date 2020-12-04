
namespace basd
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvIdProdukts = new System.Windows.Forms.DataGridView();
            this.idGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduktsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кудашкинDataSet = new basd.КудашкинDataSet();
            this.idProduktsTableAdapter = new basd.КудашкинDataSetTableAdapters.IdProduktsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdProdukts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idProduktsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кудашкинDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(102, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(128, 86);
            this.txtArt.Multiline = true;
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(146, 20);
            this.txtArt.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 127);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(128, 168);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(146, 20);
            this.txtRemove.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Признак удаления";
            // 
            // dgvIdProdukts
            // 
            this.dgvIdProdukts.AutoGenerateColumns = false;
            this.dgvIdProdukts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdProdukts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGoodsDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.removeDataGridViewTextBoxColumn});
            this.dgvIdProdukts.DataSource = this.idProduktsBindingSource;
            this.dgvIdProdukts.Location = new System.Drawing.Point(399, 86);
            this.dgvIdProdukts.Name = "dgvIdProdukts";
            this.dgvIdProdukts.Size = new System.Drawing.Size(389, 296);
            this.dgvIdProdukts.TabIndex = 10;
            this.dgvIdProdukts.DoubleClick += new System.EventHandler(this.dgvIdProdukts_DoubleClick);
            // 
            // idGoodsDataGridViewTextBoxColumn
            // 
            this.idGoodsDataGridViewTextBoxColumn.DataPropertyName = "IdGoods";
            this.idGoodsDataGridViewTextBoxColumn.HeaderText = "IdGoods";
            this.idGoodsDataGridViewTextBoxColumn.Name = "idGoodsDataGridViewTextBoxColumn";
            this.idGoodsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // removeDataGridViewTextBoxColumn
            // 
            this.removeDataGridViewTextBoxColumn.DataPropertyName = "Remove";
            this.removeDataGridViewTextBoxColumn.HeaderText = "Remove";
            this.removeDataGridViewTextBoxColumn.Name = "removeDataGridViewTextBoxColumn";
            // 
            // idProduktsBindingSource
            // 
            this.idProduktsBindingSource.DataMember = "IdProdukts";
            this.idProduktsBindingSource.DataSource = this.кудашкинDataSet;
            // 
            // кудашкинDataSet
            // 
            this.кудашкинDataSet.DataSetName = "КудашкинDataSet";
            this.кудашкинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idProduktsTableAdapter
            // 
            this.idProduktsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Поставщики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Данные по Сырью";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(599, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Данные по договорам закупки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvIdProdukts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdProdukts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idProduktsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кудашкинDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvIdProdukts;
        private КудашкинDataSet кудашкинDataSet;
        private System.Windows.Forms.BindingSource idProduktsBindingSource;
        private КудашкинDataSetTableAdapters.IdProduktsTableAdapter idProduktsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn removeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}