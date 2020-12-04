
namespace basd
{
    partial class Form5
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.dgvD = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.кудашкинDataSet = new basd.КудашкинDataSet();
            this.dannyDZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dannyDZTableAdapter = new basd.КудашкинDataSetTableAdapters.DannyDZTableAdapter();
            this.idContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSupplerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кудашкинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannyDZBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 23);
            this.button3.TabIndex = 61;
            this.button3.Text = "Данные по Сырью";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "Поставщики";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Сырье";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Признак удаления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Дата поставки";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(140, 238);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(146, 20);
            this.txt5.TabIndex = 56;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(140, 202);
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(146, 20);
            this.txt4.TabIndex = 55;
            // 
            // dgvD
            // 
            this.dgvD.AllowUserToDeleteRows = false;
            this.dgvD.AutoGenerateColumns = false;
            this.dgvD.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContractDataGridViewTextBoxColumn,
            this.numberContractDataGridViewTextBoxColumn,
            this.idSupplerDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvD.DataSource = this.dannyDZBindingSource;
            this.dgvD.Location = new System.Drawing.Point(343, 57);
            this.dgvD.Name = "dgvD";
            this.dgvD.ReadOnly = true;
            this.dgvD.Size = new System.Drawing.Size(489, 362);
            this.dgvD.TabIndex = 54;
            this.dgvD.DoubleClick += new System.EventHandler(this.dgvD_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Id Поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Номер контракта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Id Контракта";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(140, 160);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(146, 20);
            this.txt3.TabIndex = 50;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(140, 126);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(146, 20);
            this.txt2.TabIndex = 49;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(140, 84);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(146, 20);
            this.txt1.TabIndex = 48;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(114, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // кудашкинDataSet
            // 
            this.кудашкинDataSet.DataSetName = "КудашкинDataSet";
            this.кудашкинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dannyDZBindingSource
            // 
            this.dannyDZBindingSource.DataMember = "DannyDZ";
            this.dannyDZBindingSource.DataSource = this.кудашкинDataSet;
            // 
            // dannyDZTableAdapter
            // 
            this.dannyDZTableAdapter.ClearBeforeFill = true;
            // 
            // idContractDataGridViewTextBoxColumn
            // 
            this.idContractDataGridViewTextBoxColumn.DataPropertyName = "IdContract";
            this.idContractDataGridViewTextBoxColumn.HeaderText = "IdContract";
            this.idContractDataGridViewTextBoxColumn.Name = "idContractDataGridViewTextBoxColumn";
            this.idContractDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberContractDataGridViewTextBoxColumn
            // 
            this.numberContractDataGridViewTextBoxColumn.DataPropertyName = "NumberContract";
            this.numberContractDataGridViewTextBoxColumn.HeaderText = "NumberContract";
            this.numberContractDataGridViewTextBoxColumn.Name = "numberContractDataGridViewTextBoxColumn";
            this.numberContractDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSupplerDataGridViewTextBoxColumn
            // 
            this.idSupplerDataGridViewTextBoxColumn.DataPropertyName = "IdSuppler";
            this.idSupplerDataGridViewTextBoxColumn.HeaderText = "IdSuppler";
            this.idSupplerDataGridViewTextBoxColumn.Name = "idSupplerDataGridViewTextBoxColumn";
            this.idSupplerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.dgvD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кудашкинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannyDZBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.DataGridView dgvD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private КудашкинDataSet кудашкинDataSet;
        private System.Windows.Forms.BindingSource dannyDZBindingSource;
        private КудашкинDataSetTableAdapters.DannyDZTableAdapter dannyDZTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupplerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}