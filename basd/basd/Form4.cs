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
    public partial class Form4 : Form
    {
        DannyS model = new DannyS();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кудашкинDataSet.DannyS". При необходимости она может быть перемещена или удалена.
            this.dannySTableAdapter.Fill(this.кудашкинDataSet.DannyS);
            Clear();
            PopulateDataGridView();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()//обновление полей ввода
        {
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.IdContract = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            model.IdContract = int.Parse(txt1.Text.Trim());
            model.IdGoods = int.Parse(txt2.Text.Trim());
            model.Price = txt3.Text.Trim();
            model.Count = txt4.Text.Trim();
            model.Status = txt5.Text.Trim();
            using (КудашкинEntities1 db = new КудашкинEntities1())
            {
                if (model.IdContract == 0)//Insert
                    db.DannyS.Add(model);
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
            dgvS.AutoGenerateColumns = false;
            using (КудашкинEntities1 db = new КудашкинEntities1())
            {
                dgvS.DataSource = db.DannyS.ToList<DannyS>();
            }
        }

        private void dgvS_DoubleClick(object sender, EventArgs e)
        {
            if (dgvS.CurrentRow.Index != -1)
            {
                model.IdContract = Convert.ToInt32(dgvS.CurrentRow.Cells["idContractDataGridViewTextBoxColumn"].Value);
                using (КудашкинEntities1 db = new КудашкинEntities1())
                {
                    model = db.DannyS.Where(x => x.IdContract == model.IdContract).FirstOrDefault();



                    txt1.Text = Convert.ToString(model.IdContract);
                    txt2.Text = Convert.ToString(model.IdGoods);
                    txt3.Text = model.Price;
                    txt4.Text = model.Count;
                    txt5.Text = model.Status;
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
                        db.DannyS.Attach(model);
                    db.DannyS.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Hide();
            Form5 MyForm5 = new Form5();
            MyForm5.ShowDialog();
            Close();
        }
    }
}
