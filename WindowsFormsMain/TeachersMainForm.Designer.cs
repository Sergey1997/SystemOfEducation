namespace WindowsFormsMain
{
    partial class TeachersMainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelForName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationDBDataSet = new WindowsFormsMain.EducationDBDataSet();
            this.labelForDate = new System.Windows.Forms.Label();
            this.labelForPosition = new System.Windows.Forms.Label();
            this.labelForNumber = new System.Windows.Forms.Label();
            this.labelForDepartmentName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelForFilter = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelForDiscipline = new System.Windows.Forms.Label();
            this.teachersTableAdapter = new WindowsFormsMain.EducationDBDataSetTableAdapters.TeachersTableAdapter();
            this.teacherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelForName
            // 
            this.labelForName.AutoSize = true;
            this.labelForName.Location = new System.Drawing.Point(30, 15);
            this.labelForName.Name = "labelForName";
            this.labelForName.Size = new System.Drawing.Size(42, 17);
            this.labelForName.TabIndex = 0;
            this.labelForName.Text = "ФИО";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(15, 222);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 40);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.AutoGenerateColumns = false;
            this.dataGridViewTeachers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherIdDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewTeachers.DataSource = this.teachersBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTeachers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(330, 10);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RowHeadersWidth = 30;
            this.dataGridViewTeachers.RowTemplate.Height = 30;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(811, 481);
            this.dataGridViewTeachers.TabIndex = 3;
            this.dataGridViewTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeachers_CellContentClick);
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.educationDBDataSet;
            // 
            // educationDBDataSet
            // 
            this.educationDBDataSet.DataSetName = "EducationDBDataSet";
            this.educationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelForDate
            // 
            this.labelForDate.AutoSize = true;
            this.labelForDate.Location = new System.Drawing.Point(28, 42);
            this.labelForDate.Name = "labelForDate";
            this.labelForDate.Size = new System.Drawing.Size(95, 17);
            this.labelForDate.TabIndex = 4;
            this.labelForDate.Text = "Дата приёма";
            this.labelForDate.UseWaitCursor = true;
            // 
            // labelForPosition
            // 
            this.labelForPosition.AutoSize = true;
            this.labelForPosition.Location = new System.Drawing.Point(28, 70);
            this.labelForPosition.Name = "labelForPosition";
            this.labelForPosition.Size = new System.Drawing.Size(81, 17);
            this.labelForPosition.TabIndex = 5;
            this.labelForPosition.Text = "Должность";
            // 
            // labelForNumber
            // 
            this.labelForNumber.AutoSize = true;
            this.labelForNumber.Location = new System.Drawing.Point(28, 99);
            this.labelForNumber.Name = "labelForNumber";
            this.labelForNumber.Size = new System.Drawing.Size(51, 17);
            this.labelForNumber.TabIndex = 6;
            this.labelForNumber.Text = "Номер";
            // 
            // labelForDepartmentName
            // 
            this.labelForDepartmentName.AutoSize = true;
            this.labelForDepartmentName.Location = new System.Drawing.Point(28, 126);
            this.labelForDepartmentName.Name = "labelForDepartmentName";
            this.labelForDepartmentName.Size = new System.Drawing.Size(68, 17);
            this.labelForDepartmentName.TabIndex = 7;
            this.labelForDepartmentName.Text = "Кафедра";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(132, 127);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 22);
            this.textBox5.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(116, 222);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 40);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Violet;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(217, 222);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 40);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(132, 42);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(156, 22);
            this.dateTimePicker.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 309);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelForFilter
            // 
            this.labelForFilter.AutoSize = true;
            this.labelForFilter.Location = new System.Drawing.Point(12, 289);
            this.labelForFilter.Name = "labelForFilter";
            this.labelForFilter.Size = new System.Drawing.Size(141, 17);
            this.labelForFilter.TabIndex = 17;
            this.labelForFilter.Text = "Фильтр по кафедре";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 155);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(156, 22);
            this.textBox6.TabIndex = 18;
            // 
            // labelForDiscipline
            // 
            this.labelForDiscipline.AutoSize = true;
            this.labelForDiscipline.Location = new System.Drawing.Point(30, 158);
            this.labelForDiscipline.Name = "labelForDiscipline";
            this.labelForDiscipline.Size = new System.Drawing.Size(90, 17);
            this.labelForDiscipline.TabIndex = 19;
            this.labelForDiscipline.Text = "Дисциплина";
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // teacherIdDataGridViewTextBoxColumn
            // 
            this.teacherIdDataGridViewTextBoxColumn.DataPropertyName = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.HeaderText = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.Name = "teacherIdDataGridViewTextBoxColumn";
            this.teacherIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherIdDataGridViewTextBoxColumn.Visible = false;
            this.teacherIdDataGridViewTextBoxColumn.Width = 5;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            this.teacherNameDataGridViewTextBoxColumn.Width = 150;
            this.teacherIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 70;
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 85;
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 60;
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Discipline";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дисциплина";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;

            // 
            // TeachersMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1153, 501);
            this.Controls.Add(this.labelForFilter);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.labelForDiscipline);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelForDepartmentName);
            this.Controls.Add(this.labelForNumber);
            this.Controls.Add(this.labelForPosition);
            this.Controls.Add(this.labelForDate);
            this.Controls.Add(this.labelForName);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Name = "TeachersMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преподаватели";
            this.Load += new System.EventHandler(this.TeachersMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.DataGridView dataGridViewTeachers;

        private System.Windows.Forms.Label labelForName;
        private System.Windows.Forms.Label labelForDate;
        private System.Windows.Forms.Label labelForPosition;
        private System.Windows.Forms.Label labelForNumber;
        private System.Windows.Forms.Label labelForDepartmentName;
        private System.Windows.Forms.Label labelForDiscipline;
        private System.Windows.Forms.Label labelForFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;

        private EducationDBDataSet educationDBDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private EducationDBDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}