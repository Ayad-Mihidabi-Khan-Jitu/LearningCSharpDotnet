using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQTOSQL
    {
    public partial class LinqToSQL_2 : Form
        {
        UniversityDataDataContext universityData;
        List<Student> students = new List<Student>();
        public LinqToSQL_2()
            {
            InitializeComponent();
            }
        private void LoadTable()
            {
            universityData = new UniversityDataDataContext();
            dataGridView1.DataSource = universityData.Students;
            }

        private void LinqToSQL_2_Load(object sender, EventArgs e)
            {
            LoadTable();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            InsertForm insert = new InsertForm();
            insert.ShowDialog();
            LoadTable();
           }

        private void button2_Click(object sender, EventArgs e)
            {
            if (dataGridView1.SelectedRows.Count > 0)
                {
                InsertForm update = new InsertForm();
                update.textBox1.ReadOnly = true;
                update.button2.Enabled = false;
                update.button1.Text = "Update";
                update.textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                update.textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                update.textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                update.ShowDialog();
                LoadTable();
                }
            else
                {
                MessageBox.Show("Please Select the entire Row ");
                }

            }

        private void button3_Click(object sender, EventArgs e)
            {
            if (dataGridView1.SelectedRows.Count > 0)
                {
                if(MessageBox.Show("Are you sure of deleting the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    int rowsel = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    Student student = universityData.Students.SingleOrDefault(E => E.Id == rowsel);
                    universityData.Students.DeleteOnSubmit(student);
                    universityData.SubmitChanges();//comminting the changes
                    LoadTable();
                    }
                }
            else
                {
                MessageBox.Show("Please Select the entire Row ");
                }
            }

        private void button4_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        }
    }
