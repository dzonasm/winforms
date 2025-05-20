namespace WF_job
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnOpenNewStudentForm = new Button();
            label5 = new Label();
            deleteStudentButton = new Button();
            label9 = new Label();
            updateStudentButton = new Button();
            label7 = new Label();
            textBox3 = new TextBox();
            label12 = new Label();
            label8 = new Label();
            updateStudentSurnameBox = new TextBox();
            updateStudentNameBox = new TextBox();
            EditSurnameLabel = new Label();
            EditNameLabel = new Label();
            dataGridViewStudentList = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            updateStudentLearningModulesList = new ListBox();
            tabPage2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            learningModuleDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ScoresDisplay = new DataGridViewTextBoxColumn();
            GPA = new DataGridViewTextBoxColumn();
            buttonSaveGrades = new Button();
            comboBoxModuleSelect = new ComboBox();
            label10 = new Label();
            tabPage3 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            textBoxNewLearningModuleName = new TextBox();
            label2 = new Label();
            listBoxNewLearningModuleStudents = new ListBox();
            label3 = new Label();
            btnSaveNewLearningModule = new Button();
            label4 = new Label();
            label11 = new Label();
            comboBoxEditLearningModuleSelect = new ComboBox();
            label13 = new Label();
            listBoxEditLearningModuleStudentSelect = new ListBox();
            btnEditLearningModuleSave = new Button();
            btnDeleteLearningModule = new Button();
            studentBindingSource1 = new BindingSource(components);
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)learningModuleDataGrid).BeginInit();
            tabPage3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(14, 15);
            tabControl.Margin = new Padding(4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(909, 705);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(901, 667);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Studentai";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 81);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnOpenNewStudentForm, 2, 9);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(deleteStudentButton, 3, 8);
            tableLayoutPanel2.Controls.Add(label9, 2, 0);
            tableLayoutPanel2.Controls.Add(updateStudentButton, 2, 8);
            tableLayoutPanel2.Controls.Add(label7, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox3, 0, 2);
            tableLayoutPanel2.Controls.Add(label12, 2, 3);
            tableLayoutPanel2.Controls.Add(label8, 0, 3);
            tableLayoutPanel2.Controls.Add(updateStudentSurnameBox, 3, 2);
            tableLayoutPanel2.Controls.Add(updateStudentNameBox, 2, 2);
            tableLayoutPanel2.Controls.Add(EditSurnameLabel, 3, 1);
            tableLayoutPanel2.Controls.Add(EditNameLabel, 2, 1);
            tableLayoutPanel2.Controls.Add(dataGridViewStudentList, 0, 5);
            tableLayoutPanel2.Controls.Add(updateStudentLearningModulesList, 2, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.Size = new Size(893, 659);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // btnOpenNewStudentForm
            // 
            tableLayoutPanel2.SetColumnSpan(btnOpenNewStudentForm, 2);
            btnOpenNewStudentForm.Dock = DockStyle.Fill;
            btnOpenNewStudentForm.Location = new Point(449, 618);
            btnOpenNewStudentForm.Margin = new Padding(4, 5, 4, 5);
            btnOpenNewStudentForm.Name = "btnOpenNewStudentForm";
            btnOpenNewStudentForm.Size = new Size(440, 36);
            btnOpenNewStudentForm.TabIndex = 24;
            btnOpenNewStudentForm.Text = "Naujas Studentas";
            btnOpenNewStudentForm.UseVisualStyleBackColor = true;
            btnOpenNewStudentForm.Click += btnOpenNewStudentForm_Click;
            // 
            // label5
            // 
            tableLayoutPanel2.SetColumnSpan(label5, 2);
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(437, 41);
            label5.TabIndex = 7;
            label5.Text = "Studentų paieška ir redagavimas";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.Dock = DockStyle.Fill;
            deleteStudentButton.Location = new Point(672, 568);
            deleteStudentButton.Margin = new Padding(4, 5, 4, 5);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(217, 40);
            deleteStudentButton.TabIndex = 23;
            deleteStudentButton.Text = "Ištrinti";
            deleteStudentButton.UseVisualStyleBackColor = true;
            deleteStudentButton.Click += deleteStudentButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Location = new Point(449, 0);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(117, 41);
            label9.TabIndex = 7;
            label9.Text = "Redagavimas";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updateStudentButton
            // 
            updateStudentButton.Dock = DockStyle.Fill;
            updateStudentButton.Location = new Point(449, 568);
            updateStudentButton.Margin = new Padding(4, 5, 4, 5);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(215, 40);
            updateStudentButton.TabIndex = 23;
            updateStudentButton.Text = "Atnaujinti";
            updateStudentButton.UseVisualStyleBackColor = true;
            updateStudentButton.Click += updateStudentButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Location = new Point(4, 41);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 34);
            label7.TabIndex = 10;
            label7.Text = "Tekstinė paieška";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            tableLayoutPanel2.SetColumnSpan(textBox3, 2);
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(4, 79);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(437, 31);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(449, 130);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(215, 51);
            label12.TabIndex = 19;
            label12.Text = "Pasirinkti modulius";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Location = new Point(4, 130);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 51);
            label8.TabIndex = 12;
            label8.Text = "Studentai";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updateStudentSurnameBox
            // 
            updateStudentSurnameBox.Dock = DockStyle.Fill;
            updateStudentSurnameBox.Location = new Point(672, 79);
            updateStudentSurnameBox.Margin = new Padding(4);
            updateStudentSurnameBox.Name = "updateStudentSurnameBox";
            updateStudentSurnameBox.Size = new Size(217, 31);
            updateStudentSurnameBox.TabIndex = 17;
            // 
            // updateStudentNameBox
            // 
            updateStudentNameBox.Dock = DockStyle.Fill;
            updateStudentNameBox.Location = new Point(449, 79);
            updateStudentNameBox.Margin = new Padding(4);
            updateStudentNameBox.Name = "updateStudentNameBox";
            updateStudentNameBox.Size = new Size(215, 31);
            updateStudentNameBox.TabIndex = 15;
            // 
            // EditSurnameLabel
            // 
            EditSurnameLabel.AutoSize = true;
            EditSurnameLabel.Dock = DockStyle.Fill;
            EditSurnameLabel.Location = new Point(672, 41);
            EditSurnameLabel.Margin = new Padding(4, 0, 4, 0);
            EditSurnameLabel.Name = "EditSurnameLabel";
            EditSurnameLabel.Size = new Size(217, 34);
            EditSurnameLabel.TabIndex = 16;
            EditSurnameLabel.Text = "Pavardė";
            EditSurnameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EditNameLabel
            // 
            EditNameLabel.AutoSize = true;
            EditNameLabel.Dock = DockStyle.Fill;
            EditNameLabel.Location = new Point(449, 41);
            EditNameLabel.Margin = new Padding(4, 0, 4, 0);
            EditNameLabel.Name = "EditNameLabel";
            EditNameLabel.Size = new Size(215, 34);
            EditNameLabel.TabIndex = 14;
            EditNameLabel.Text = "Vardas";
            EditNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewStudentList
            // 
            dataGridViewStudentList.AutoGenerateColumns = false;
            dataGridViewStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentList.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn });
            tableLayoutPanel2.SetColumnSpan(dataGridViewStudentList, 2);
            dataGridViewStudentList.DataSource = studentBindingSource;
            dataGridViewStudentList.Dock = DockStyle.Fill;
            dataGridViewStudentList.Location = new Point(4, 202);
            dataGridViewStudentList.Margin = new Padding(4, 5, 4, 5);
            dataGridViewStudentList.Name = "dataGridViewStudentList";
            dataGridViewStudentList.RowHeadersWidth = 51;
            tableLayoutPanel2.SetRowSpan(dataGridViewStudentList, 5);
            dataGridViewStudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudentList.Size = new Size(437, 452);
            dataGridViewStudentList.TabIndex = 13;
            dataGridViewStudentList.CellClick += dataGridView1_CellClick;
            dataGridViewStudentList.ColumnHeaderMouseClick += studentList_ColumnHeaderMouseClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Vardas";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Pavardė";
            surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            studentBindingSource.Sort = "Surname";
            // 
            // updateStudentLearningModulesList
            // 
            tableLayoutPanel2.SetColumnSpan(updateStudentLearningModulesList, 2);
            updateStudentLearningModulesList.Dock = DockStyle.Fill;
            updateStudentLearningModulesList.FormattingEnabled = true;
            updateStudentLearningModulesList.ItemHeight = 25;
            updateStudentLearningModulesList.Location = new Point(449, 202);
            updateStudentLearningModulesList.Margin = new Padding(4, 5, 4, 5);
            updateStudentLearningModulesList.Name = "updateStudentLearningModulesList";
            tableLayoutPanel2.SetRowSpan(updateStudentLearningModulesList, 3);
            updateStudentLearningModulesList.SelectionMode = SelectionMode.MultiSimple;
            updateStudentLearningModulesList.Size = new Size(440, 356);
            updateStudentLearningModulesList.TabIndex = 22;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(901, 667);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pažymiai";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.Controls.Add(learningModuleDataGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonSaveGrades, 2, 0);
            tableLayoutPanel1.Controls.Add(comboBoxModuleSelect, 1, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(893, 659);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // learningModuleDataGrid
            // 
            learningModuleDataGrid.AutoGenerateColumns = false;
            learningModuleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            learningModuleDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, surnameDataGridViewTextBoxColumn1, ScoresDisplay, GPA });
            tableLayoutPanel1.SetColumnSpan(learningModuleDataGrid, 3);
            learningModuleDataGrid.DataSource = studentBindingSource;
            learningModuleDataGrid.Dock = DockStyle.Fill;
            learningModuleDataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            learningModuleDataGrid.Location = new Point(4, 54);
            learningModuleDataGrid.Margin = new Padding(4, 5, 4, 5);
            learningModuleDataGrid.Name = "learningModuleDataGrid";
            learningModuleDataGrid.RowHeadersWidth = 51;
            learningModuleDataGrid.Size = new Size(885, 600);
            learningModuleDataGrid.TabIndex = 24;
            learningModuleDataGrid.CellValidating += learningModuleDataGrid_CellValidating;
            learningModuleDataGrid.ColumnHeaderMouseClick += learningModuleDataGrid_ColumnHeaderMouseClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Visible = false;
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.FillWeight = 50F;
            nameDataGridViewTextBoxColumn1.HeaderText = "Vardas";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            surnameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn1.FillWeight = 50F;
            surnameDataGridViewTextBoxColumn1.HeaderText = "Pavardė";
            surnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            surnameDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // ScoresDisplay
            // 
            ScoresDisplay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ScoresDisplay.DataPropertyName = "ScoresDisplay";
            ScoresDisplay.HeaderText = "Modulio pažymiai";
            ScoresDisplay.MinimumWidth = 6;
            ScoresDisplay.Name = "ScoresDisplay";
            // 
            // GPA
            // 
            GPA.DataPropertyName = "GPA";
            GPA.HeaderText = "Vidurkis";
            GPA.MinimumWidth = 6;
            GPA.Name = "GPA";
            GPA.ReadOnly = true;
            GPA.Width = 140;
            // 
            // buttonSaveGrades
            // 
            buttonSaveGrades.Dock = DockStyle.Fill;
            buttonSaveGrades.Location = new Point(677, 4);
            buttonSaveGrades.Margin = new Padding(4);
            buttonSaveGrades.Name = "buttonSaveGrades";
            buttonSaveGrades.Size = new Size(212, 41);
            buttonSaveGrades.TabIndex = 26;
            buttonSaveGrades.Text = "Išsaugoti pažymius";
            buttonSaveGrades.UseVisualStyleBackColor = true;
            buttonSaveGrades.Click += btnSaveGrades_Click;
            // 
            // comboBoxModuleSelect
            // 
            comboBoxModuleSelect.Dock = DockStyle.Fill;
            comboBoxModuleSelect.FormattingEnabled = true;
            comboBoxModuleSelect.Location = new Point(233, 4);
            comboBoxModuleSelect.Margin = new Padding(4);
            comboBoxModuleSelect.Name = "comboBoxModuleSelect";
            comboBoxModuleSelect.Size = new Size(436, 33);
            comboBoxModuleSelect.TabIndex = 25;
            comboBoxModuleSelect.SelectedIndexChanged += comboBoxModuleSelect_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(4, 0);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(221, 49);
            label10.TabIndex = 0;
            label10.Text = "Modulio Pasirinkimas";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel3);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new Size(901, 667);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Moduliai";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.5112534F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3279743F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4530163F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8976154F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxNewLearningModuleName, 0, 2);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(listBoxNewLearningModuleStudents, 0, 4);
            tableLayoutPanel3.Controls.Add(label3, 0, 3);
            tableLayoutPanel3.Controls.Add(btnSaveNewLearningModule, 0, 5);
            tableLayoutPanel3.Controls.Add(label4, 2, 0);
            tableLayoutPanel3.Controls.Add(label11, 2, 1);
            tableLayoutPanel3.Controls.Add(comboBoxEditLearningModuleSelect, 2, 2);
            tableLayoutPanel3.Controls.Add(label13, 2, 3);
            tableLayoutPanel3.Controls.Add(listBoxEditLearningModuleStudentSelect, 2, 4);
            tableLayoutPanel3.Controls.Add(btnEditLearningModuleSave, 2, 5);
            tableLayoutPanel3.Controls.Add(btnDeleteLearningModule, 3, 5);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 5);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 47.22222F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 52.77778F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 434F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel3.Size = new Size(893, 657);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 42);
            label1.TabIndex = 0;
            label1.Text = "Naujas modulis";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNewLearningModuleName
            // 
            textBoxNewLearningModuleName.Dock = DockStyle.Fill;
            textBoxNewLearningModuleName.Location = new Point(4, 94);
            textBoxNewLearningModuleName.Margin = new Padding(4, 5, 4, 5);
            textBoxNewLearningModuleName.Name = "textBoxNewLearningModuleName";
            textBoxNewLearningModuleName.Size = new Size(272, 31);
            textBoxNewLearningModuleName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(4, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 47);
            label2.TabIndex = 2;
            label2.Text = "Modulio pavadinimas";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBoxNewLearningModuleStudents
            // 
            listBoxNewLearningModuleStudents.Dock = DockStyle.Fill;
            listBoxNewLearningModuleStudents.FormattingEnabled = true;
            listBoxNewLearningModuleStudents.ItemHeight = 25;
            listBoxNewLearningModuleStudents.Location = new Point(4, 176);
            listBoxNewLearningModuleStudents.Margin = new Padding(4, 5, 4, 5);
            listBoxNewLearningModuleStudents.Name = "listBoxNewLearningModuleStudents";
            listBoxNewLearningModuleStudents.SelectionMode = SelectionMode.MultiSimple;
            listBoxNewLearningModuleStudents.Size = new Size(272, 424);
            listBoxNewLearningModuleStudents.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(4, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 36);
            label3.TabIndex = 4;
            label3.Text = "Pridėti studentus";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSaveNewLearningModule
            // 
            btnSaveNewLearningModule.Dock = DockStyle.Fill;
            btnSaveNewLearningModule.Location = new Point(4, 610);
            btnSaveNewLearningModule.Margin = new Padding(4, 5, 4, 5);
            btnSaveNewLearningModule.Name = "btnSaveNewLearningModule";
            btnSaveNewLearningModule.Size = new Size(272, 42);
            btnSaveNewLearningModule.TabIndex = 5;
            btnSaveNewLearningModule.Text = "Išsaugoti";
            btnSaveNewLearningModule.UseVisualStyleBackColor = true;
            btnSaveNewLearningModule.Click += btnSaveNewLearningModule_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(447, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(185, 42);
            label4.TabIndex = 6;
            label4.Text = "Modulio redagavimas";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Left;
            label11.Location = new Point(447, 42);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(142, 47);
            label11.TabIndex = 7;
            label11.Text = "Pasirinkti modulį";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxEditLearningModuleSelect
            // 
            comboBoxEditLearningModuleSelect.Dock = DockStyle.Fill;
            comboBoxEditLearningModuleSelect.FormattingEnabled = true;
            comboBoxEditLearningModuleSelect.Location = new Point(447, 94);
            comboBoxEditLearningModuleSelect.Margin = new Padding(4, 5, 4, 5);
            comboBoxEditLearningModuleSelect.Name = "comboBoxEditLearningModuleSelect";
            comboBoxEditLearningModuleSelect.Size = new Size(254, 33);
            comboBoxEditLearningModuleSelect.TabIndex = 8;
            comboBoxEditLearningModuleSelect.SelectedIndexChanged += comboBoxEditLearningModuleSelect_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Left;
            label13.Location = new Point(447, 135);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(157, 36);
            label13.TabIndex = 9;
            label13.Text = "Modulio studentai";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBoxEditLearningModuleStudentSelect
            // 
            listBoxEditLearningModuleStudentSelect.Dock = DockStyle.Fill;
            listBoxEditLearningModuleStudentSelect.FormattingEnabled = true;
            listBoxEditLearningModuleStudentSelect.ItemHeight = 25;
            listBoxEditLearningModuleStudentSelect.Location = new Point(447, 176);
            listBoxEditLearningModuleStudentSelect.Margin = new Padding(4, 5, 4, 5);
            listBoxEditLearningModuleStudentSelect.Name = "listBoxEditLearningModuleStudentSelect";
            listBoxEditLearningModuleStudentSelect.SelectionMode = SelectionMode.MultiSimple;
            listBoxEditLearningModuleStudentSelect.Size = new Size(254, 424);
            listBoxEditLearningModuleStudentSelect.TabIndex = 10;
            // 
            // btnEditLearningModuleSave
            // 
            btnEditLearningModuleSave.Dock = DockStyle.Fill;
            btnEditLearningModuleSave.Location = new Point(447, 610);
            btnEditLearningModuleSave.Margin = new Padding(4, 5, 4, 5);
            btnEditLearningModuleSave.Name = "btnEditLearningModuleSave";
            btnEditLearningModuleSave.Size = new Size(254, 42);
            btnEditLearningModuleSave.TabIndex = 11;
            btnEditLearningModuleSave.Text = "Atnaujinti";
            btnEditLearningModuleSave.UseVisualStyleBackColor = true;
            btnEditLearningModuleSave.Click += btnEditLearningModuleSave_Click;
            // 
            // btnDeleteLearningModule
            // 
            btnDeleteLearningModule.Dock = DockStyle.Fill;
            btnDeleteLearningModule.Location = new Point(709, 610);
            btnDeleteLearningModule.Margin = new Padding(4, 5, 4, 5);
            btnDeleteLearningModule.Name = "btnDeleteLearningModule";
            btnDeleteLearningModule.Size = new Size(180, 42);
            btnDeleteLearningModule.TabIndex = 12;
            btnDeleteLearningModule.Text = "Ištrinti";
            btnDeleteLearningModule.UseVisualStyleBackColor = true;
            btnDeleteLearningModule.Click += btnDeleteLearningModule_Click;
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Student);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 735);
            Controls.Add(tabControl);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "Student grades";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)learningModuleDataGrid).EndInit();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private DataGridView dataGridViewStudentList;
        private Label label9;
        private Label label12;
        private TextBox updateStudentSurnameBox;
        private Label EditSurnameLabel;
        private TextBox updateStudentNameBox;
        private Label EditNameLabel;
        private ListBox updateStudentLearningModulesList;
        private Button updateStudentButton;
        private Button deleteStudentButton;
        private Label label10;
        private DataGridView learningModuleDataGrid;
        private BindingSource studentBindingSource;
        private ComboBox comboBoxModuleSelect;
        private Button buttonSaveGrades;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnOpenNewStudentForm;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ScoresDisplay;
        private DataGridViewTextBoxColumn GPA;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TextBox textBoxNewLearningModuleName;
        private Label label2;
        private ListBox listBoxNewLearningModuleStudents;
        private Label label3;
        private BindingSource studentBindingSource1;
        private Button btnSaveNewLearningModule;
        private Label label4;
        private Label label11;
        private ComboBox comboBoxEditLearningModuleSelect;
        private Label label13;
        private ListBox listBoxEditLearningModuleStudentSelect;
        private Button btnEditLearningModuleSave;
        private Button btnDeleteLearningModule;
    }
}
