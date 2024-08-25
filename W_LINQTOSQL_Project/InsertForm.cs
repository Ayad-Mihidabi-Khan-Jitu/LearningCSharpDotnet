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
    public partial class InsertForm : Form
        {
        public InsertForm()
            {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            UniversityDataDataContext universityData = new UniversityDataDataContext();//conn established
            if (textBox1.ReadOnly == false)
                {
                Student student = new Student();
                student.Id = Convert.ToInt32(textBox1.Text); // or, student.Id = int.Parse(textBox1.Text);
                student.S_Name = textBox2.Text;
                student.Reg = textBox3.Text;
                universityData.Students.InsertOnSubmit(student);//inserting on student table as a row
                universityData.SubmitChanges();//comminting the changes
                MessageBox.Show("Record inserted into the Student Table");
                }
            else
                {
                Student student = universityData.Students.SingleOrDefault(E => E.Id == int.Parse(textBox1.Text));
                student.Id = int.Parse(textBox1.Text);
                student.S_Name = textBox2.Text;
                student.Reg = textBox3.Text;
                universityData.SubmitChanges();//comminting the changes
                MessageBox.Show("Record updated into the Student Table");
                }
            }

        private void button2_Click(object sender, EventArgs e)
            {
            
            foreach (Control contrls in this.Controls)
                {
                //contrls.Text = "";
                
                if (contrls is TextBox)
                        {
                        TextBox tb = contrls as TextBox;
                        tb.Clear();
                        }
                }
            if (textBox1.ReadOnly == true)
                {
                textBox1.Focus();
                }
            else 
                {
                textBox2.Focus();
                }
            
            }

        private void button3_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void InsertForm_Load(object sender, EventArgs e)
            {

            }
        }
    }
