using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptimizationMethodsCP.UsersForms;

namespace OptimizationMethodsCP.ServiceForms
{
    public partial class LoginForm : Form
    {
        SQLiteDataAdapter adapter;
        SQLiteConnection Connect;
        string path = "OMCP.db";
        public LoginForm()
        {
            
            InitializeComponent();
            
            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
            }

            using (Connect = new SQLiteConnection(@"Data Source=" + path))
            {
                string commandText = "CREATE TABLE IF NOT EXISTS [Users] ([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [Type] VARCHAR(45) , [Password] VARCHAR(45))"; // создать таблицу, если её нет
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                Command.ExecuteNonQuery();
                Connect.Close();
            }
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Connect = new SQLiteConnection(@"Data Source=" + path))
            {
                string commandText = $"SELECT * FROM Users WHERE Type = '{comboBox1.Text}' AND Password = '{textBox1.Text}'"; // создать таблицу, если её нет
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                adapter = new SQLiteDataAdapter(commandText, Connect);
                Connect.Close();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    AutoUserForm autoUserForm;
                    if (comboBox1.Text == "Администратор")
                    {
                        autoUserForm = new AutoUserForm(true);
                    }
                    else
                    {
                        autoUserForm = new AutoUserForm(false);
                    }
                    autoUserForm.ShowDialog();
                }
                else {
                    MessageBox.Show("Введен неправильный пароль. Повторите попытку.");
                    textBox1.Text = "";
                }
            }
        }
    }
}

