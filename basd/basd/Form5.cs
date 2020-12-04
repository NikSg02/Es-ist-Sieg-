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
    public partial class Form5 : Form
    {
        DannyDZ model = new DannyDZ();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кудашкинDataSet.DannyDZ". При необходимости она может быть перемещена или удалена.
            this.dannyDZTableAdapter.Fill(this.кудашкинDataSet.DannyDZ);
            Clear();
            PopulateDataGridView();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.IdContract = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.IdContract = int.Parse(txt1.Text.Trim());
            model.NumberContract = txt2.Text.Trim();
            model.IdSuppler = int.Parse(txt3.Text.Trim());
            model.Date = txt4.Text.Trim();
            model.Status = txt5.Text.Trim();
            using (КудашкинEntities1 db = new КудашкинEntities1())
            {
                if (model.IdContract == 0)//Insert
                    db.DannyDZ.Add(model);
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
            dgvD.AutoGenerateColumns = false;
            using (КудашкинEntities1 db = new КудашкинEntities1())
            {
                dgvD.DataSource = db.DannyDZ.ToList<DannyDZ>();
            }
        }

        private void dgvD_DoubleClick(object sender, EventArgs e)
        {
            if (dgvD.CurrentRow.Index != -1)
            {
                model.IdContract = Convert.ToInt32(dgvD.CurrentRow.Cells["idContractDataGridViewTextBoxColumn"].Value);
                using (КудашкинEntities1 db = new КудашкинEntities1())
                {
                    model = db.DannyDZ.Where(x => x.IdContract == model.IdContract).FirstOrDefault();
                    txt1.Text = Convert.ToString(model.IdContract);
                    txt2.Text = Convert.ToString(model.NumberContract);
                    txt3.Text = Convert.ToString(model.IdSuppler);
                    txt4.Text = Convert.ToString(model.Date);
                    txt5.Text = Convert.ToString(model.Status);
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
                        db.DannyDZ.Attach(model);
                    db.DannyDZ.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form4 MyForm4 = new Form4();
            MyForm4.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
