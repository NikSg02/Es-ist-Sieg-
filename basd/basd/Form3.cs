using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace basd
{
    public partial class Form3 : Form
    {
        Supplier model = new Supplier();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кудашкинDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.кудашкинDataSet.Supplier);
            Clear();
            PopulateDataGridView();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = txt6.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.IdSuppler = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Name = txt1.Text.Trim();
            model.INN = txt2.Text.Trim();
            model.City = txt3.Text.Trim();
            model.Street = txt4.Text.Trim();
            model.DomAndKV = txt5.Text.Trim();
            model.Status = txt6.Text.Trim();
            using (КудашкинEntities1 db = new КудашкинEntities1())
            {
                if (model.IdSuppler == 0)//Insert
                    db.Supplier.Add(model);
                else //Update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }

            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");

        }
        void PopulateDataGridView()
        {
            dgvSupplier.AutoGenerateColumns = false;
            using (КудашкинEntities1 db = new КудашкинEntities1())
            {
                dgvSupplier.DataSource = db.Supplier.ToList<Supplier>();
            }
        }

        private void dgvSupplier_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSupplier.CurrentRow.Index != -1)
            {
                model.IdSuppler = Convert.ToInt32(dgvSupplier.CurrentRow.Cells["idSupplerDataGridViewTextBoxColumn"].Value);
                using (КудашкинEntities1 db = new КудашкинEntities1())
                {
                    model = db.Supplier.Where(x => x.IdSuppler == model.IdSuppler).FirstOrDefault();
                    txt1.Text = model.Name;
                    txt2.Text = model.INN;
                    txt3.Text = model.City;
                    txt4.Text = model.Street;
                    txt5.Text = model.DomAndKV;
                    txt6.Text = model.Status;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (КудашкинEntities1 db = new КудашкинEntities1())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Supplier.Attach(model);
                    db.Supplier.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        
        
            
            private void button1_Click(object sender, EventArgs e)
            {

            Form3.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form4 MyForm4 = new Form4();
            MyForm4.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form5 MyForm5 = new Form5();
            MyForm5.ShowDialog();
            Close();
        }
    }
}

