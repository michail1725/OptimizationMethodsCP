using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using OptimizationMethodsCP.Methods;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using OptimizationMethodsCP.Entities;
using System.IO;
using OpenControls.Wpf.SurfacePlot;

namespace OptimizationMethodsCP.UsersForms
{
    public partial class AutoUserForm : Form
    {
        DataSet ds;
        DataTable table;
        SQLiteDataAdapter adapter;
        SQLiteCommandBuilder commandBuilder;
        SQLiteConnection Connect;
        SQLiteCommand cmd;
        string path = "OMCP.db";
        OpenControls.Wpf.SurfacePlot.SurfacePlotControl _surfacePlotControl = new OpenControls.Wpf.SurfacePlot.SurfacePlotControl();
        OpenControls.Wpf.SurfacePlot.Model.Configuration _configuration;
        
        public AutoUserForm(bool IsAdmin)
        {
            InitializeComponent();
            Controls.Add(_surfacePlotControl);
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
            }
            if (IsAdmin)
            {
                groupBox1.Enabled = true;
                Text = "Администратор программного комплекса";
            }
            else {
                Text = "Пользователь программного комплекса";
            }
            using (Connect = new SQLiteConnection(@"Data Source=" + path))
            {
                Connect.Open();
                
                string commandText = "CREATE TABLE IF NOT EXISTS [Tasks] ([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,[Name] VARCHAR(45),[DescriptionPath] VARCHAR(100)," +
                    "[Function] VARCHAR(100),[T1_min] REAL,[T1_max] REAL, [T2_min] REAL,[T2_max] REAL, [Target] VARCHAR(100), [Deffinition] REAL, [Limit] VARCHAR(45), [IsMax] BOOLEAN)";
                cmd = new SQLiteCommand(commandText, Connect);
                cmd.ExecuteNonQuery();
                Connect.Close();
                Connect.Open();
                commandText = "CREATE TABLE IF NOT EXISTS [Methods] ([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,[Name] VARCHAR(45))";
                cmd = new SQLiteCommand(commandText, Connect);
                cmd.ExecuteNonQuery();
                Connect.Close();
                Connect.Open();
                commandText = "SELECT Name FROM Tasks";
                adapter = new SQLiteDataAdapter(commandText, Connect);
                Connect.Close();
                table = new DataTable();
                adapter.Fill(table);
                TaskVariant_combo.DataSource = table;
                TaskVariant_combo.DisplayMember = "name";
                Connect.Close();
                TaskVariant_combo.SelectedIndex = -1;
                TaskVariant_combo.Text = "Выберите вариант задачи";
                Connect.Open();
                commandText = "SELECT Name FROM Methods";
                adapter = new SQLiteDataAdapter(commandText, Connect);
                Connect.Close();
                table = new DataTable();
                adapter.Fill(table);
                SolverMethod_combo.DataSource = table;
                SolverMethod_combo.DisplayMember = "name";
                Connect.Close();
                SolverMethod_combo.SelectedIndex = -1;
                SolverMethod_combo.Text = "Выберите метод решения";
            }
            
            Tables_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void TaskVariant_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TaskVariant_combo.Text.Contains("Вариант"))
            {
                using (Connect = new SQLiteConnection(@"Data Source=" + path))
                {
                    string commandText = $"SELECT * FROM Tasks Where name = '{TaskVariant_combo.Text}'";
                    Connect.Open();
                    adapter = new SQLiteDataAdapter(commandText, Connect);
                    Connect.Close();
                    table = new DataTable();
                    adapter.Fill(table);
                }
                string file_path = Directory.GetCurrentDirectory() + table.Rows[0].ItemArray[2].ToString();
                Variant_textbox.Text = File.ReadAllText(file_path);
                TFunction_richTextBox.Text = table.Rows[0].ItemArray[3].ToString();
                T1_min_value_textBox.Text = table.Rows[0].ItemArray[4].ToString();
                T1_max_value_textBox.Text = table.Rows[0].ItemArray[5].ToString();
                T2_min_value_textBox.Text = table.Rows[0].ItemArray[6].ToString();
                T2_max_value_textBox.Text = table.Rows[0].ItemArray[7].ToString();
                SolutionTarget.Text = table.Rows[0].ItemArray[8].ToString();
                Solve_diffention_numericUpDown.Value = Convert.ToDecimal(table.Rows[0].ItemArray[9]);
                Limit_richTextBox.Text = table.Rows[0].ItemArray[10].ToString();
                OptimizationTask.is_max = Convert.ToBoolean(Convert.ToString(table.Rows[0].ItemArray[11]));
                  if (SolverMethod_combo.SelectedIndex >= 0)
                  {
                      SolveOptimProblem.Enabled = true;
                  }
                }
            else
            {
                SolveOptimProblem.Enabled = false;
            }
        }

        private void SolveOptimProblem_Click(object sender, EventArgs e)
        {
            if (TaskVariant_combo.Text != "Вариант №11") {
                MessageBox.Show("Решение для данного варианта находится в разработке. Выберите другой вариант.");
                return;
            }
            else if (SolverMethod_combo.Text != "Метод сканирования") {
                MessageBox.Show("Данный метод решения находится в разработке. Выберите другой метод.");
                return;
            }
            tabPage2.Enabled = true;
            tabPage3.Enabled = true;
            OptimizationTask.solution_target = SolutionTarget.Text;
            OptimizationTask.is_max = false;
            OptimizationTask.diffenition = (float)Convert.ToDouble(Solve_diffention_numericUpDown.Value);
            OptimizationTask.solution_method = SolverMethod_combo.Text;
            OptimizationTask.T1_min = (float)Convert.ToDouble(T1_min_value_textBox.Text);
            OptimizationTask.T1_max = (float)Convert.ToDouble(T1_max_value_textBox.Text);
            OptimizationTask.T2_min = (float)Convert.ToDouble(T2_min_value_textBox.Text);
            OptimizationTask.T2_max = (float)Convert.ToDouble(T2_max_value_textBox.Text);
            Scaning.Body();
            //points_dataGridView.Columns.Add("T1", "T1");
            //points_dataGridView.Columns.Add("T2", "T2");
            //points_dataGridView.Columns.Add("F", "F");
            points_dataGridView.DataSource = Scaning.dt;
            foreach (OptimizationTask.point p in Scaning.points) {
                
                //points_dataGridView.Rows.Add(p.t1_value, p.t2_value, p.f_value);
                double S = p.f_value;
                S = S >= 1000 ? Math.Round(S / 100, 0) * 100 : Math.Round(S / 10, 0) * 10;
                if (S == 50)
                {
                    chart1.Series[0].Points.AddXY(p.t1_value, p.t2_value);
                }
                else if (S == 250)
                {
                    chart1.Series[0].Points.AddXY(p.t1_value, p.t2_value);
                }
                else if (S == 500)
                {
                    chart1.Series[0].Points.AddXY(p.t1_value, p.t2_value);
                }
                else if (S == 1000)
                {
                    chart1.Series[0].Points.AddXY(p.t1_value, p.t2_value);
                }
                else if (S == 2000)
                {
                    chart1.Series[0].Points.AddXY(p.t1_value, p.t2_value);
                }
                else if (S == 3000)
                {
                    chart1.Series[0].Points.AddXY(p.t1_value, p.t2_value);
                }
                else if (S == 5000)
                {
                    chart1.Series[0].Points.AddXY(p.t1_value, p.t2_value);
                }
            }
            chart1.ChartAreas[0].AxisX.Minimum = OptimizationTask.T1_min;
            chart1.ChartAreas[0].AxisX.Maximum = OptimizationTask.T1_max;
            chart1.ChartAreas[0].AxisY.Minimum = OptimizationTask.T2_min;
            chart1.ChartAreas[0].AxisY.Maximum = OptimizationTask.T2_max;
            F_max_textbox.Text = Scaning.p_max.f_value.ToString();
            F_min_textbox.Text = Scaning.p_min.f_value.ToString();
            T1_ex_max_textBox.Text = Scaning.p_max.t1_value.ToString();
            T2_ex_max_textBox.Text = Scaning.p_max.t2_value.ToString();
            T1_ex_min_textBox.Text = Scaning.p_min.t1_value.ToString();
            T2_ex_min_textBox.Text = Scaning.p_min.t2_value.ToString();
            if (OptimizationTask.is_max == true) { 
                SolutionText.Text = OptimizationTask.solution_target + Environment.NewLine + "составляет " + Scaning.p_max.f_value.ToString() + " у.е. " + Environment.NewLine + "при значениях T1 = " +
                Scaning.p_max.t1_value.ToString() + " и T2 = " + Scaning.p_max.t2_value.ToString();
            }
            else {
                SolutionText.Text = OptimizationTask.solution_target + Environment.NewLine + "составляет " + Scaning.p_min.f_value.ToString() + " у.е. " + Environment.NewLine + "при значениях T1 = " +
                Scaning.p_min.t1_value.ToString() + " и T2 = " + Scaning.p_min.t2_value.ToString();
            }
            tabControl1.SelectedTab = tabPage2;
        }

       
        private void Tables_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (Tables_comboBox.Text == "Задания")
            {
                sql = "SELECT * FROM Tasks";

            }
            else if (Tables_comboBox.Text == "Пользователи")
            {
                sql = "SELECT * FROM Users";
            }
            else {
                sql = "SELECT * FROM Methods";
            }
            using (Connect = new SQLiteConnection(@"Data Source=" + path))
            {
                Connect.Open();
                adapter = new SQLiteDataAdapter(sql, Connect);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["Id"].ReadOnly = true;
            }
        }

        private void SaveNewData_Click(object sender, EventArgs e)
        {
            using (Connect = new SQLiteConnection(@"Data Source=" + path))
            {
                try
                {
                    Connect.Open();
                    cmd = Connect.CreateCommand();
                    if (Tables_comboBox.Text == "Задания")
                    {
                        cmd.CommandText = "SELECT * FROM Tasks";

                    }
                    else if (Tables_comboBox.Text == "Пользователи")
                    {
                        cmd.CommandText = "SELECT * FROM Users";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM Methods";
                    }                    
                    adapter = new SQLiteDataAdapter(cmd);
                    commandBuilder = new SQLiteCommandBuilder(adapter);
                    adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                    adapter.Update(ds.Tables[0]);
                    Connect.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Tables_comboBox_SelectedIndexChanged(sender, e);
        }

        private void IsAllowToSelectTab(object sender, TabControlCancelEventArgs e)
        {
            if (tabPage2.Enabled == false || tabPage3.Enabled == false) {
                e.Cancel = true;
            }
        }

        private void SolverMethod_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SolverMethod_combo.SelectedIndex >= 0) {
                if (TaskVariant_combo.Text.Contains("Вариант"))
                {
                    SolveOptimProblem.Enabled = true;
                }
            }
            else {
                SolveOptimProblem.Enabled = false;    
            }
        }

        private void AutoUserForm_Load(object sender, EventArgs e)
        {
            _configuration = new OpenControls.Wpf.SurfacePlot.Model.Configuration();
            _surfacePlotControl.Initialise(_configuration);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_surfacePlotControl != null)
            {
                _surfacePlotControl.SetBounds(
                    ClientRectangle.X,
                    ClientRectangle.Y,
                    ClientRectangle.Width,
                    ClientRectangle.Height);
            }
        }
        private void Run()
        {
            float YStep = (OptimizationTask.T2_max - OptimizationTask.T2_min) / 50;
            float XStep = (OptimizationTask.T1_max - OptimizationTask.T1_min) / 50;
            float zMin = float.MaxValue;
            float zMax = float.MinValue;
            List<List<float>> srcData = new List<List<float>>();
            for (float i = OptimizationTask.T1_min; i < OptimizationTask.T1_max; i += XStep)
            {
                if (srcData.Count >= 50)
                    break;
                List<float> list = new List<float>();
                srcData.Add(list);
                for (float j = OptimizationTask.T2_min; j < OptimizationTask.T2_max; j += YStep) {
                    if (list.Count >= 50)
                        break;
                            
                    float z = Variant11_math.GetFunctionValue(i, j);
                    if (z < 0) {
                        z = 0;
                    }
                    else if(Variant11_math.IsLimit(i, j)){
                        z = 0;
                    }
                    if (z > zMax)
                        zMax = z;
                    if (z < zMin)
                        zMin = z;
                    list.Add(z);
                }
            } _surfacePlotControl.Height = 410;
            _surfacePlotControl.Width = 800;
            _configuration.BackgroundColour = "White";
            _configuration.LabelColour = "Black";
            _configuration.LabelFontSize = 18;
            _surfacePlotControl.Location = new System.Drawing.Point(12, 24);
            _surfacePlotControl.SetData(srcData, OptimizationTask.T1_min, OptimizationTask.T1_max, 50, OptimizationTask.T2_min, OptimizationTask.T2_max, 50,0, 50,50);
            _surfacePlotControl.BringToFront();
            _surfacePlotControl.Visible = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                Run();
            }
            else {
                _surfacePlotControl.Visible = false;
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            SaveNewData_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
