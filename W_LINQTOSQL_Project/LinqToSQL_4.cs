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
    public partial class LinqToSQL_4 : Form
        {
        bool flag = false; 
        //bool flag1=false;
        UniversityDataDataContext UniversityData;
        public LinqToSQL_4()
            {
            InitializeComponent();
            }

         private void LinqToSQL_4_Load(object sender, EventArgs e)
            {
            UniversityData = new UniversityDataDataContext();

            var Etable = from E in UniversityData.Emps orderby E.Sal select E;
            dataGridView1.DataSource = Etable;

            var Cbox = from E in UniversityData.Emps select new { E.Job };
            comboBox1.DataSource = Cbox.Distinct();
            comboBox1.DisplayMember = "Job";
            comboBox1.SelectedIndex = -1;
            flag = true;

            /*
            //////ami chaisilam combobox e click korle sort hobe but error ach
            List<string> citem = new List<string> { "Empno", "Ename", "Job", "Mgr", "HireDate", "Sal", "Comm", "Deptno", "Dept" };
            citem.Sort();
            var Cboxo = citem;
            comboBox2.DataSource = Cboxo;
            comboBox2.SelectedIndex = -1;
            flag1 = true;
            */
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            if(flag)
            dataGridView1.DataSource = from E in UniversityData.Emps where E.Job == comboBox1.Text select E; 
            }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
            {
            //dataGridView1.DataSource = from E in UniversityData.Emps where E.Job == comboBox1.Text select E;
            dataGridView1.DataSource = from E in UniversityData.Emps where E.Job.Contains( comboBox1.Text) select E;
            }

        bool State = false;
        private void buttonEname_Click(object sender, EventArgs e)
            {
            if (State)
                {
                dataGridView1.DataSource = from E in UniversityData.Emps orderby E.Ename descending select E;
                buttonEname.Text = "D. Ordered By Ename";
                State = false;
                }
            else
                {
                dataGridView1.DataSource = from E in UniversityData.Emps orderby E.Ename select E;
                State = true;
                buttonEname.Text = "A. Ordered By Ename";
                }
            
            }

        private void GetJobSal_Click(object sender, EventArgs e)
            {
            dataGridView1.DataSource = from E in UniversityData.Emps select new { E.Job, Salary = E.Sal };
            }

        private void groupbyDep_Click(object sender, EventArgs e)
            {
            dataGridView1.DataSource = from E in UniversityData.Emps group E by E.Deptno into G select  new {DepNo = G.Key, EmpNum = G.Count() };
            }

        private void groupbyJob_Click(object sender, EventArgs e)
            {
            dataGridView1.DataSource = from E in UniversityData.Emps group E by E.Job into G select new {Job  = G.Key, EmpNum = G.Count() };
            }

        private void groupbydep5_Click(object sender, EventArgs e)
            {
            dataGridView1.DataSource = from E in UniversityData.Emps group E by E.Job into G where G.Count() > 4 select new { Job = G.Key, EmpNum = G.Count() };
            }

        private void mulclause_Click(object sender, EventArgs e)
            {
            dataGridView1.DataSource = from E in UniversityData.Emps where E.Job == "Clerk" group E by E.Deptno into G where G.Count() > 1 orderby G.Key descending select new { DeptNO = G.Key, ClerkCount = G.Count() };
            }

        private void mulQuerySalDep_Click(object sender, EventArgs e)
            {
            dataGridView1.DataSource = from E in UniversityData.Emps group E by E.Deptno into G select new { DeptNo = G.Key, MaxSal = G.Max(E => E.Sal) };
            }



        /*
         ///ami chaisilam combobox e click korle sort hobe but error ache
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (flag1)
                {
                if(comboBox2.SelectedIndex == 0)
                    {
                    dataGridView1.DataSource = from E in UniversityData.Emps orderby E.Comm select E;
                    }
                else if (comboBox2.SelectedIndex == 1)
                    {
                    dataGridView1.DataSource = from E in UniversityData.Emps orderby E.Dept select E;
                    }
                else if (comboBox2.SelectedIndex == 2)
                    {
                    dataGridView1.DataSource = from E in UniversityData.Emps orderby E.Deptno select E;
                    }
                else if (comboBox2.SelectedIndex == 3)
                    {
                    dataGridView1.DataSource = from E in UniversityData.Emps orderby E.Emp1 select E;
                    }
                else if (comboBox2.SelectedIndex == 4)
                    {
                    dataGridView1.DataSource = from E in UniversityData.Emps orderby E.Empno select E;
                    }
                else if (comboBox2.SelectedIndex == 5)
                    {
                    dataGridView1.DataSource = from E in UniversityData.Emps orderby E.Emps select E;
                    }
                }
          } 
        */


        }
}
