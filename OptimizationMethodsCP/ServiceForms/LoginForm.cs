using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizationMethodsCP.ServiceForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            SQLiteDataAdapter adapter;
            SQLiteCommandBuilder commandBuilder;
            SQLiteConnection Connect;
            InitializeComponent();
            string path = "OMCP.db";
            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
            }

            using (Connect = new SQLiteConnection(@"Data Source=" + path))
            {
                string commandText = "CREATE TABLE IF NOT EXISTS [User] ([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [Type] VARCHAR(45) , [Password] VARCHAR(45))"; // создать таблицу, если её нет
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                Command.ExecuteNonQuery();
                Connect.Close();
            }
        }
    }
}

