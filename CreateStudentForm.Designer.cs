namespace WF_job
{
    partial class CreateStudentForm
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
            listBoxNewStudentModuleSelect = new ListBox();
            buttonSaveNewStudent = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxNewStudentName = new TextBox();
            textBoxNewStudentSurname = new TextBox();
            SuspendLayout();
            // 
            // listBoxNewStudentModuleSelect
            // 
            listBoxNewStudentModuleSelect.FormattingEnabled = true;
            listBoxNewStudentModuleSelect.Location = new Point(61, 173);
            listBoxNewStudentModuleSelect.Margin = new Padding(3, 4, 3, 4);
            listBoxNewStudentModuleSelect.Name = "listBoxNewStudentModuleSelect";
            listBoxNewStudentModuleSelect.SelectionMode = SelectionMode.MultiSimple;
            listBoxNewStudentModuleSelect.Size = new Size(343, 184);
            listBoxNewStudentModuleSelect.TabIndex = 29;
            // 
            // buttonSaveNewStudent
            // 
            buttonSaveNewStudent.Location = new Point(61, 376);
            buttonSaveNewStudent.Margin = new Padding(3, 4, 3, 4);
            buttonSaveNewStudent.Name = "buttonSaveNewStudent";
            buttonSaveNewStudent.Size = new Size(86, 31);
            buttonSaveNewStudent.TabIndex = 28;
            buttonSaveNewStudent.Text = "Išsaugoti";
            buttonSaveNewStudent.UseVisualStyleBackColor = true;
            buttonSaveNewStudent.Click += SaveNewStudentButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 80);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 26;
            label4.Text = "Pavardė";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 149);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 25;
            label3.Text = "Pasirinkti modulius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 43);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 24;
            label2.Text = "Naujas studentas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 80);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 22;
            label1.Text = "Vardas";
            // 
            // textBoxNewStudentName
            // 
            textBoxNewStudentName.Location = new Point(61, 103);
            textBoxNewStudentName.Name = "textBoxNewStudentName";
            textBoxNewStudentName.Size = new Size(125, 27);
            textBoxNewStudentName.TabIndex = 30;
            // 
            // textBoxNewStudentSurname
            // 
            textBoxNewStudentSurname.Location = new Point(208, 103);
            textBoxNewStudentSurname.Name = "textBoxNewStudentSurname";
            textBoxNewStudentSurname.Size = new Size(196, 27);
            textBoxNewStudentSurname.TabIndex = 31;
            // 
            // CreateStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 448);
            Controls.Add(textBoxNewStudentSurname);
            Controls.Add(textBoxNewStudentName);
            Controls.Add(listBoxNewStudentModuleSelect);
            Controls.Add(buttonSaveNewStudent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateStudentForm";
            Text = "New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxNewStudentModuleSelect;
        private Button buttonSaveNewStudent;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxNewStudentName;
        private TextBox textBoxNewStudentSurname;
    }
}