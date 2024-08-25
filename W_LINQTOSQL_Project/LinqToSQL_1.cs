using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LINQTOSQL
    {
    public partial class LinqToSQL_1 : Form
        {
        UniversityDataDataContext universityData;
        List<Student> students = new List<Student>();
        int index = 0;
        public LinqToSQL_1()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            ///Jehetu UniversityDataDataContext bar bar use korbo tai ata class er moddhe decalare korlam opore
            //UniversityDataDataContext universityData = new UniversityDataDataContext(); //mainly ata holo database er sathe connection establish kora
            universityData = new UniversityDataDataContext();

            ///dataGridView er moddhe table ta assign korlam process-1
            Table<Student>StudentTable = universityData.Students;
            dataGridView1.DataSource = StudentTable;

            ///dataGridView er moddhe table ta assign korlam process-2
            //dataGridView1.DataSource = universityData.Students; 

            ///universityData database er Students table ta ke list e convert korlam
            students = universityData.Students.ToList();
            TableData();
            }
        private void TableData()
            {
            textBox1.Text = students[index].Id.ToString();
            textBox2.Text = students[index].S_Name.ToString();
            textBox3.Text = students[index].Reg.ToString();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            ///Process-1
            /*
            index--;            
            if (index < 0)
                {
                index = 0;
                MessageBox.Show("This is First Record ");
                }
            else
                {
                TableData();
                }
            */

            ///Process-2
            if (index > 0)
                {
                index = index - 1;
                TableData();
                }
            else
                {
                MessageBox.Show("This is First Record ");
                }

            }

        private void button2_Click(object sender, EventArgs e)
            {
            /*
            ///Process-1
            index++;
            if (index > students.Count-1)
                {
                index = students.Count - 1;
                MessageBox.Show("This is Last Record ");
                }
            else
                {
                TableData();
                }
            */

            ///Process-2
            if (index < students.Count - 1)
                {
                index = index + 1;
                TableData();
                }
            else
                {
                MessageBox.Show("This is Last Record ");
                }

            }

        private void button3_Click(object sender, EventArgs e)
            {
            MessageBox.Show("Do you want to close?");
            this.Close();
            }
        }
    }
