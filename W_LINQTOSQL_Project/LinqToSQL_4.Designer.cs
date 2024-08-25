namespace LINQTOSQL
    {
    partial class LinqToSQL_4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEname = new System.Windows.Forms.Button();
            this.GetJobSal = new System.Windows.Forms.Button();
            this.groupbyDep = new System.Windows.Forms.Button();
            this.groupbyJob = new System.Windows.Forms.Button();
            this.groupbydep5 = new System.Windows.Forms.Button();
            this.mulclause = new System.Windows.Forms.Button();
            this.mulQuerySalDep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.comboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(475, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "LINQ Syntexes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Job";
            // 
            // buttonEname
            // 
            this.buttonEname.BackColor = System.Drawing.Color.Yellow;
            this.buttonEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEname.Location = new System.Drawing.Point(15, 389);
            this.buttonEname.Name = "buttonEname";
            this.buttonEname.Size = new System.Drawing.Size(240, 30);
            this.buttonEname.TabIndex = 4;
            this.buttonEname.Text = "Ordered By Ename";
            this.buttonEname.UseVisualStyleBackColor = false;
            this.buttonEname.Click += new System.EventHandler(this.buttonEname_Click);
            // 
            // GetJobSal
            // 
            this.GetJobSal.BackColor = System.Drawing.Color.Yellow;
            this.GetJobSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetJobSal.Location = new System.Drawing.Point(15, 425);
            this.GetJobSal.Name = "GetJobSal";
            this.GetJobSal.Size = new System.Drawing.Size(240, 30);
            this.GetJobSal.TabIndex = 5;
            this.GetJobSal.Text = "Get Job-Salary";
            this.GetJobSal.UseVisualStyleBackColor = false;
            this.GetJobSal.Click += new System.EventHandler(this.GetJobSal_Click);
            // 
            // groupbyDep
            // 
            this.groupbyDep.BackColor = System.Drawing.Color.Yellow;
            this.groupbyDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbyDep.Location = new System.Drawing.Point(292, 389);
            this.groupbyDep.Name = "groupbyDep";
            this.groupbyDep.Size = new System.Drawing.Size(191, 30);
            this.groupbyDep.TabIndex = 6;
            this.groupbyDep.Text = "Emp No by Dep";
            this.groupbyDep.UseVisualStyleBackColor = false;
            this.groupbyDep.Click += new System.EventHandler(this.groupbyDep_Click);
            // 
            // groupbyJob
            // 
            this.groupbyJob.BackColor = System.Drawing.Color.Yellow;
            this.groupbyJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbyJob.Location = new System.Drawing.Point(292, 425);
            this.groupbyJob.Name = "groupbyJob";
            this.groupbyJob.Size = new System.Drawing.Size(191, 30);
            this.groupbyJob.TabIndex = 7;
            this.groupbyJob.Text = "Emp No by Job";
            this.groupbyJob.UseVisualStyleBackColor = false;
            this.groupbyJob.Click += new System.EventHandler(this.groupbyJob_Click);
            // 
            // groupbydep5
            // 
            this.groupbydep5.BackColor = System.Drawing.Color.Yellow;
            this.groupbydep5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbydep5.Location = new System.Drawing.Point(521, 406);
            this.groupbydep5.Name = "groupbydep5";
            this.groupbydep5.Size = new System.Drawing.Size(223, 30);
            this.groupbydep5.TabIndex = 8;
            this.groupbydep5.Text = "Emp No > 4 by Job";
            this.groupbydep5.UseVisualStyleBackColor = false;
            this.groupbydep5.Click += new System.EventHandler(this.groupbydep5_Click);
            // 
            // mulclause
            // 
            this.mulclause.BackColor = System.Drawing.Color.Yellow;
            this.mulclause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulclause.Location = new System.Drawing.Point(794, 389);
            this.mulclause.Name = "mulclause";
            this.mulclause.Size = new System.Drawing.Size(306, 30);
            this.mulclause.TabIndex = 9;
            this.mulclause.Text = "Multiple Clauses in a Query";
            this.mulclause.UseVisualStyleBackColor = false;
            this.mulclause.Click += new System.EventHandler(this.mulclause_Click);
            // 
            // mulQuerySalDep
            // 
            this.mulQuerySalDep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mulQuerySalDep.BackColor = System.Drawing.Color.Yellow;
            this.mulQuerySalDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulQuerySalDep.Location = new System.Drawing.Point(794, 425);
            this.mulQuerySalDep.Name = "mulQuerySalDep";
            this.mulQuerySalDep.Size = new System.Drawing.Size(306, 30);
            this.mulQuerySalDep.TabIndex = 11;
            this.mulQuerySalDep.Text = "Max Salary Group by DeptNo";
            this.mulQuerySalDep.UseVisualStyleBackColor = false;
            this.mulQuerySalDep.Click += new System.EventHandler(this.mulQuerySalDep_Click);
            // 
            // LinqToSQL_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1185, 459);
            this.Controls.Add(this.mulQuerySalDep);
            this.Controls.Add(this.mulclause);
            this.Controls.Add(this.groupbydep5);
            this.Controls.Add(this.groupbyJob);
            this.Controls.Add(this.groupbyDep);
            this.Controls.Add(this.GetJobSal);
            this.Controls.Add(this.buttonEname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LinqToSQL_4";
            this.Text = "LinqToSQL_4";
            this.Load += new System.EventHandler(this.LinqToSQL_4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEname;
        private System.Windows.Forms.Button GetJobSal;
        private System.Windows.Forms.Button groupbyDep;
        private System.Windows.Forms.Button groupbyJob;
        private System.Windows.Forms.Button groupbydep5;
        private System.Windows.Forms.Button mulclause;
        private System.Windows.Forms.Button mulQuerySalDep;
        }
    }