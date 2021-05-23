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
        public AutoUserForm()
        {
            InitializeComponent();
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
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
            }

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
            }
        }

        private void SolveOptimProblem_Click(object sender, EventArgs e)
        {
            tabPage2.Enabled = true;
            tabPage3.Enabled = true;
            OptimizationTask.solution_target = SolutionTarget.Text;
            OptimizationTask.is_max = false;
            OptimizationTask.diffenition = Convert.ToDouble(Solve_diffention_numericUpDown.Value);
            OptimizationTask.graph_diffenition = Convert.ToDouble(Graph_definition_numericUpDown.Value);
            OptimizationTask.solution_method = SolverMethod_combo.Text;
            OptimizationTask.T1_min = Convert.ToDouble(T1_min_value_textBox.Text);
            OptimizationTask.T1_max = Convert.ToDouble(T1_max_value_textBox.Text);
            OptimizationTask.T2_min = Convert.ToDouble(T2_min_value_textBox.Text);
            OptimizationTask.T2_max = Convert.ToDouble(T2_max_value_textBox.Text);
            Scaning.Body();
            foreach (OptimizationTask.point p in Scaning.points) {
                points_dataGridView.Rows.Add(p.t1_value,p.t2_value,p.f_value);
            }
            F_max_textbox.Text = Scaning.p_max.f_value.ToString();
            F_min_textbox.Text = Scaning.p_min.f_value.ToString();
            T1_ex_max_textBox.Text = Scaning.p_max.t1_value.ToString();
            T2_ex_max_textBox.Text = Scaning.p_max.t2_value.ToString();
            T1_ex_min_textBox.Text = Scaning.p_min.t1_value.ToString();
            T2_ex_min_textBox.Text = Scaning.p_min.t2_value.ToString();
            if (OptimizationTask.is_max == true) {
                SolutionText.Text = OptimizationTask.solution_target + "составляет" + Scaning.p_max.f_value.ToString() + "у.е. при значениях T1 = " +
                Scaning.p_max.t1_value.ToString() + " и T2 = " + Scaning.p_max.t2_value.ToString();
            }
            else {
                SolutionText.Text = OptimizationTask.solution_target + "составляет" + Scaning.p_min.f_value.ToString() + "у.е. при значениях T1 = " +
                Scaning.p_min.t1_value.ToString() + " и T2 = " + Scaning.p_min.t2_value.ToString();
            }
        }

        private void Tables_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (Tables_comboBox.Text == "Задания")
            {
                sql = "SELECT * FROM Tasks";

            }
            else
            {
                sql = "SELECT * FROM Users";
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
                    else
                    {
                        cmd.CommandText = "SELECT * FROM Users";
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

      
    }
}
