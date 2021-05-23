
namespace OptimizationMethodsCP.UsersForms
{
    partial class AutoUserForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.SolveOptimProblem = new System.Windows.Forms.Button();
            this.SolveBox = new System.Windows.Forms.GroupBox();
            this.Graph_definition_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.SolverMethod_combo = new System.Windows.Forms.ComboBox();
            this.TaskVariant_combo = new System.Windows.Forms.ComboBox();
            this.Variant_textbox = new System.Windows.Forms.TextBox();
            this.TaskBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Limit_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SolutionTarget = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Solve_diffention_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.T2_max_value_textBox = new System.Windows.Forms.TextBox();
            this.T1_max_value_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.T2_min_value_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.T1_min_value_textBox = new System.Windows.Forms.TextBox();
            this.TFunction_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.T2_ex_min_textBox = new System.Windows.Forms.TextBox();
            this.T1_ex_min_textBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.F_min_textbox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.T2_ex_max_textBox = new System.Windows.Forms.TextBox();
            this.T1_ex_max_textBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.F_max_textbox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SolutionText = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.points_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveNewData = new System.Windows.Forms.Button();
            this.Tables_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SolveBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_definition_numericUpDown)).BeginInit();
            this.TaskBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Solve_diffention_numericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.points_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 482);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.SolveOptimProblem);
            this.tabPage1.Controls.Add(this.SolveBox);
            this.tabPage1.Controls.Add(this.TaskVariant_combo);
            this.tabPage1.Controls.Add(this.Variant_textbox);
            this.tabPage1.Controls.Add(this.TaskBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 33);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 13);
            this.label26.TabIndex = 17;
            this.label26.Text = "Текст задачи:";
            // 
            // SolveOptimProblem
            // 
            this.SolveOptimProblem.Location = new System.Drawing.Point(635, 419);
            this.SolveOptimProblem.Name = "SolveOptimProblem";
            this.SolveOptimProblem.Size = new System.Drawing.Size(168, 31);
            this.SolveOptimProblem.TabIndex = 3;
            this.SolveOptimProblem.Text = "Решить задачу оптимизации";
            this.SolveOptimProblem.UseVisualStyleBackColor = true;
            this.SolveOptimProblem.Click += new System.EventHandler(this.SolveOptimProblem_Click);
            // 
            // SolveBox
            // 
            this.SolveBox.Controls.Add(this.Graph_definition_numericUpDown);
            this.SolveBox.Controls.Add(this.label9);
            this.SolveBox.Controls.Add(this.SolverMethod_combo);
            this.SolveBox.Location = new System.Drawing.Point(401, 300);
            this.SolveBox.Name = "SolveBox";
            this.SolveBox.Size = new System.Drawing.Size(402, 113);
            this.SolveBox.TabIndex = 16;
            this.SolveBox.TabStop = false;
            this.SolveBox.Text = "Параметры решения";
            // 
            // Graph_definition_numericUpDown
            // 
            this.Graph_definition_numericUpDown.DecimalPlaces = 2;
            this.Graph_definition_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Graph_definition_numericUpDown.Location = new System.Drawing.Point(200, 46);
            this.Graph_definition_numericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Graph_definition_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Graph_definition_numericUpDown.Name = "Graph_definition_numericUpDown";
            this.Graph_definition_numericUpDown.Size = new System.Drawing.Size(67, 20);
            this.Graph_definition_numericUpDown.TabIndex = 2;
            this.Graph_definition_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Точность отображения графиков:";
            // 
            // SolverMethod_combo
            // 
            this.SolverMethod_combo.FormattingEnabled = true;
            this.SolverMethod_combo.Items.AddRange(new object[] {
            "Метод сканирования"});
            this.SolverMethod_combo.Location = new System.Drawing.Point(12, 20);
            this.SolverMethod_combo.Name = "SolverMethod_combo";
            this.SolverMethod_combo.Size = new System.Drawing.Size(161, 21);
            this.SolverMethod_combo.TabIndex = 0;
            this.SolverMethod_combo.Text = "Выберите метод решения";
            // 
            // TaskVariant_combo
            // 
            this.TaskVariant_combo.FormattingEnabled = true;
            this.TaskVariant_combo.Location = new System.Drawing.Point(9, 7);
            this.TaskVariant_combo.Name = "TaskVariant_combo";
            this.TaskVariant_combo.Size = new System.Drawing.Size(161, 21);
            this.TaskVariant_combo.TabIndex = 1;
            this.TaskVariant_combo.Text = "Выберите вариант задачи";
            this.TaskVariant_combo.SelectedIndexChanged += new System.EventHandler(this.TaskVariant_combo_SelectedIndexChanged);
            // 
            // Variant_textbox
            // 
            this.Variant_textbox.Location = new System.Drawing.Point(9, 49);
            this.Variant_textbox.Multiline = true;
            this.Variant_textbox.Name = "Variant_textbox";
            this.Variant_textbox.ReadOnly = true;
            this.Variant_textbox.Size = new System.Drawing.Size(377, 364);
            this.Variant_textbox.TabIndex = 0;
            // 
            // TaskBox
            // 
            this.TaskBox.Controls.Add(this.label13);
            this.TaskBox.Controls.Add(this.Limit_richTextBox);
            this.TaskBox.Controls.Add(this.SolutionTarget);
            this.TaskBox.Controls.Add(this.label12);
            this.TaskBox.Controls.Add(this.Solve_diffention_numericUpDown);
            this.TaskBox.Controls.Add(this.label6);
            this.TaskBox.Controls.Add(this.T2_max_value_textBox);
            this.TaskBox.Controls.Add(this.T1_max_value_textBox);
            this.TaskBox.Controls.Add(this.label1);
            this.TaskBox.Controls.Add(this.label7);
            this.TaskBox.Controls.Add(this.label2);
            this.TaskBox.Controls.Add(this.label8);
            this.TaskBox.Controls.Add(this.label3);
            this.TaskBox.Controls.Add(this.T2_min_value_textBox);
            this.TaskBox.Controls.Add(this.label4);
            this.TaskBox.Controls.Add(this.T1_min_value_textBox);
            this.TaskBox.Controls.Add(this.TFunction_richTextBox);
            this.TaskBox.Controls.Add(this.label5);
            this.TaskBox.Location = new System.Drawing.Point(401, 31);
            this.TaskBox.Name = "TaskBox";
            this.TaskBox.Size = new System.Drawing.Size(402, 263);
            this.TaskBox.TabIndex = 15;
            this.TaskBox.TabStop = false;
            this.TaskBox.Text = "Параметры задачи";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "F = ";
            // 
            // Limit_richTextBox
            // 
            this.Limit_richTextBox.Location = new System.Drawing.Point(12, 177);
            this.Limit_richTextBox.Multiline = false;
            this.Limit_richTextBox.Name = "Limit_richTextBox";
            this.Limit_richTextBox.ReadOnly = true;
            this.Limit_richTextBox.Size = new System.Drawing.Size(161, 27);
            this.Limit_richTextBox.TabIndex = 20;
            this.Limit_richTextBox.Text = "";
            // 
            // SolutionTarget
            // 
            this.SolutionTarget.AutoSize = true;
            this.SolutionTarget.Location = new System.Drawing.Point(89, 69);
            this.SolutionTarget.Name = "SolutionTarget";
            this.SolutionTarget.Size = new System.Drawing.Size(280, 13);
            this.SolutionTarget.TabIndex = 19;
            this.SolutionTarget.Text = "Минимум себестомости фильтрата за смену 8 часов ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Определить:";
            // 
            // Solve_diffention_numericUpDown
            // 
            this.Solve_diffention_numericUpDown.DecimalPlaces = 2;
            this.Solve_diffention_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Solve_diffention_numericUpDown.Location = new System.Drawing.Point(12, 231);
            this.Solve_diffention_numericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Solve_diffention_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Solve_diffention_numericUpDown.Name = "Solve_diffention_numericUpDown";
            this.Solve_diffention_numericUpDown.Size = new System.Drawing.Size(67, 20);
            this.Solve_diffention_numericUpDown.TabIndex = 17;
            this.Solve_diffention_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "T2 min:";
            // 
            // T2_max_value_textBox
            // 
            this.T2_max_value_textBox.Location = new System.Drawing.Point(290, 132);
            this.T2_max_value_textBox.Name = "T2_max_value_textBox";
            this.T2_max_value_textBox.Size = new System.Drawing.Size(61, 20);
            this.T2_max_value_textBox.TabIndex = 14;
            // 
            // T1_max_value_textBox
            // 
            this.T1_max_value_textBox.Location = new System.Drawing.Point(290, 106);
            this.T1_max_value_textBox.Name = "T1_max_value_textBox";
            this.T1_max_value_textBox.Size = new System.Drawing.Size(61, 20);
            this.T1_max_value_textBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ограничения первого рода:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "T2 max:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ограничение второго рода:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "T1 max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Точность нахождения:";
            // 
            // T2_min_value_textBox
            // 
            this.T2_min_value_textBox.Location = new System.Drawing.Point(69, 132);
            this.T2_min_value_textBox.Name = "T2_min_value_textBox";
            this.T2_min_value_textBox.Size = new System.Drawing.Size(61, 20);
            this.T2_min_value_textBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Целевая функция:";
            // 
            // T1_min_value_textBox
            // 
            this.T1_min_value_textBox.Location = new System.Drawing.Point(69, 106);
            this.T1_min_value_textBox.Name = "T1_min_value_textBox";
            this.T1_min_value_textBox.Size = new System.Drawing.Size(61, 20);
            this.T1_min_value_textBox.TabIndex = 9;
            // 
            // TFunction_richTextBox
            // 
            this.TFunction_richTextBox.Location = new System.Drawing.Point(38, 34);
            this.TFunction_richTextBox.Multiline = false;
            this.TFunction_richTextBox.Name = "TFunction_richTextBox";
            this.TFunction_richTextBox.ReadOnly = true;
            this.TFunction_richTextBox.Size = new System.Drawing.Size(277, 28);
            this.TFunction_richTextBox.TabIndex = 6;
            this.TFunction_richTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "T1 min:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.T2_ex_min_textBox);
            this.tabPage2.Controls.Add(this.T1_ex_min_textBox);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.F_min_textbox);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.T2_ex_max_textBox);
            this.tabPage2.Controls.Add(this.T1_ex_max_textBox);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.F_max_textbox);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.SolutionText);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.points_dataGridView);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблица результатов и 2D-график";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // T2_ex_min_textBox
            // 
            this.T2_ex_min_textBox.Location = new System.Drawing.Point(363, 420);
            this.T2_ex_min_textBox.Name = "T2_ex_min_textBox";
            this.T2_ex_min_textBox.ReadOnly = true;
            this.T2_ex_min_textBox.Size = new System.Drawing.Size(55, 20);
            this.T2_ex_min_textBox.TabIndex = 23;
            // 
            // T1_ex_min_textBox
            // 
            this.T1_ex_min_textBox.Location = new System.Drawing.Point(266, 420);
            this.T1_ex_min_textBox.Name = "T1_ex_min_textBox";
            this.T1_ex_min_textBox.ReadOnly = true;
            this.T1_ex_min_textBox.Size = new System.Drawing.Size(55, 20);
            this.T1_ex_min_textBox.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(327, 424);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "и T2 = ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(239, 423);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "T1 = ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(156, 423);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "При значениях";
            // 
            // F_min_textbox
            // 
            this.F_min_textbox.Location = new System.Drawing.Point(87, 420);
            this.F_min_textbox.Name = "F_min_textbox";
            this.F_min_textbox.ReadOnly = true;
            this.F_min_textbox.Size = new System.Drawing.Size(63, 20);
            this.F_min_textbox.TabIndex = 18;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(37, 424);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 17;
            this.label25.Text = "F min = ";
            // 
            // T2_ex_max_textBox
            // 
            this.T2_ex_max_textBox.Location = new System.Drawing.Point(363, 375);
            this.T2_ex_max_textBox.Name = "T2_ex_max_textBox";
            this.T2_ex_max_textBox.ReadOnly = true;
            this.T2_ex_max_textBox.Size = new System.Drawing.Size(55, 20);
            this.T2_ex_max_textBox.TabIndex = 16;
            // 
            // T1_ex_max_textBox
            // 
            this.T1_ex_max_textBox.Location = new System.Drawing.Point(266, 375);
            this.T1_ex_max_textBox.Name = "T1_ex_max_textBox";
            this.T1_ex_max_textBox.ReadOnly = true;
            this.T1_ex_max_textBox.Size = new System.Drawing.Size(55, 20);
            this.T1_ex_max_textBox.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(327, 379);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "и T2 = ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(239, 378);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "T1 = ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(156, 378);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "При значениях";
            // 
            // F_max_textbox
            // 
            this.F_max_textbox.Location = new System.Drawing.Point(87, 375);
            this.F_max_textbox.Name = "F_max_textbox";
            this.F_max_textbox.ReadOnly = true;
            this.F_max_textbox.Size = new System.Drawing.Size(63, 20);
            this.F_max_textbox.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 379);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "F max = ";
            // 
            // SolutionText
            // 
            this.SolutionText.AutoSize = true;
            this.SolutionText.Location = new System.Drawing.Point(537, 379);
            this.SolutionText.Name = "SolutionText";
            this.SolutionText.Size = new System.Drawing.Size(196, 39);
            this.SolutionText.TabIndex = 7;
            this.SolutionText.Text = "Минимум себестоимости фильтрата \r\nсоставляет 0 у.е.\r\n при T1 = 0 и T2 = 0 ";
            this.SolutionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(488, 352);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Заключение:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Минимум целевой функции:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Максимум целевой функции:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Таблица значений целевой функции:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Линии равных значений выбранной целевой функции:";
            // 
            // points_dataGridView
            // 
            this.points_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.points_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.points_dataGridView.Location = new System.Drawing.Point(488, 54);
            this.points_dataGridView.Name = "points_dataGridView";
            this.points_dataGridView.ReadOnly = true;
            this.points_dataGridView.RowHeadersVisible = false;
            this.points_dataGridView.Size = new System.Drawing.Size(297, 282);
            this.points_dataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "T1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "T2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "F";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(8, 34);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(424, 332);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(809, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3D-график";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveNewData);
            this.groupBox1.Controls.Add(this.Tables_comboBox);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Интерфейс администратора";
            // 
            // SaveNewData
            // 
            this.SaveNewData.Location = new System.Drawing.Point(9, 222);
            this.SaveNewData.Name = "SaveNewData";
            this.SaveNewData.Size = new System.Drawing.Size(75, 23);
            this.SaveNewData.TabIndex = 2;
            this.SaveNewData.Text = "сохранить";
            this.SaveNewData.UseVisualStyleBackColor = true;
            this.SaveNewData.Click += new System.EventHandler(this.SaveNewData_Click);
            // 
            // Tables_comboBox
            // 
            this.Tables_comboBox.FormattingEnabled = true;
            this.Tables_comboBox.Items.AddRange(new object[] {
            "Задания",
            "Пользователи"});
            this.Tables_comboBox.Location = new System.Drawing.Point(9, 20);
            this.Tables_comboBox.Name = "Tables_comboBox";
            this.Tables_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Tables_comboBox.TabIndex = 1;
            this.Tables_comboBox.SelectedIndexChanged += new System.EventHandler(this.Tables_comboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // AutoUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 767);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AutoUserForm";
            this.Text = "Researcher";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SolveBox.ResumeLayout(false);
            this.SolveBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_definition_numericUpDown)).EndInit();
            this.TaskBox.ResumeLayout(false);
            this.TaskBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Solve_diffention_numericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.points_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SolveOptimProblem;
        private System.Windows.Forms.GroupBox SolveBox;
        private System.Windows.Forms.NumericUpDown Graph_definition_numericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SolverMethod_combo;
        private System.Windows.Forms.ComboBox TaskVariant_combo;
        private System.Windows.Forms.TextBox Variant_textbox;
        private System.Windows.Forms.GroupBox TaskBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox Limit_richTextBox;
        private System.Windows.Forms.Label SolutionTarget;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown Solve_diffention_numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox T2_max_value_textBox;
        private System.Windows.Forms.TextBox T1_max_value_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T2_min_value_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox T1_min_value_textBox;
        private System.Windows.Forms.RichTextBox TFunction_richTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox T2_ex_min_textBox;
        private System.Windows.Forms.TextBox T1_ex_min_textBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox F_min_textbox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox T2_ex_max_textBox;
        private System.Windows.Forms.TextBox T1_ex_max_textBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox F_max_textbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label SolutionText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView points_dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveNewData;
        private System.Windows.Forms.ComboBox Tables_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}