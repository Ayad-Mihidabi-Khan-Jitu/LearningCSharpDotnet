using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;

namespace LINQTOSQL
    {
    public partial class LinqToSQL_3 : Form
        {
        UniversityDataDataContext universityData;
        public LinqToSQL_3()
            {
            InitializeComponent();
            }
        private void LinqToSQL_3_Load(object sender, EventArgs e)
            {
            universityData = new UniversityDataDataContext();
            
            ///Select all from Teacher
            ISingleResult<Teacher_SelectResult> selectResults1 = universityData.Teacher_Select();
            dataGridView1.DataSource = selectResults1;

            ///Select all from Teacher where Department = EEE
            //ISingleResult<Teacher_SpScResult> selectResults2 = universityData.Teacher_SpSc(null);
            ISingleResult<Teacher_SpScResult> selectResults2 = universityData.Teacher_SpSc("EEE");
            dataGridView2.DataSource = selectResults2;
            }

        private void insert_Click(object sender, EventArgs e)
            {
            int? SL = null;
            universityData.Teacher_Insert(textBox2.Text,textBox3.Text,ref SL);
            textBox1.Text = SL.ToString();
            universityData.SubmitChanges();

            ///aita te akta jhamela ache ata insert korar por just akta value update hoy ak tar ashi hoy na
            //Table<Teacher> teachers = universityData.Teachers;
            //dataGridView1.DataSource = teachers; 

            ShowtheTables();
            }

        private void clear_Click(object sender, EventArgs e)
            {
            foreach(Control cntrl in this.Controls)
                {
                if(cntrl is TextBox)
                    {
                    TextBox text = cntrl as TextBox;
                    text.Clear();
                    }
                }
            textBox2.Focus();
            }

        private void close_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        void ShowtheTables()
            {
            ///Select all from Teacher
            ISingleResult<Teacher_SelectResult> selectResults1 = universityData.Teacher_Select();
            dataGridView1.DataSource = selectResults1;

            ///Select all from Teacher where Department = EEE
            //ISingleResult<Teacher_SpScResult> selectResults2 = universityData.Teacher_SpSc(null);
            ISingleResult<Teacher_SpScResult> selectResults2 = universityData.Teacher_SpSc("EEE");
            dataGridView2.DataSource = selectResults2;
            }
        }
    }
