using WindowsFormsMain.DBDataSet;
namespace WindowsFormsMain
{
    partial class DisciplinesMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxForSpeciality = new System.Windows.Forms.TextBox();
            this.textBoxForSemester = new System.Windows.Forms.TextBox();
            this.textBoxForCode = new System.Windows.Forms.TextBox();
            this.textBoxForName = new System.Windows.Forms.TextBox();
            this.labelForSpeciality = new System.Windows.Forms.Label();
            this.labelForSemester = new System.Windows.Forms.Label();
            this.labelForCode = new System.Windows.Forms.Label();
            this.labelForName = new System.Windows.Forms.Label();
            this.dataGridViewDIsciplines = new System.Windows.Forms.DataGridView();
            this.dIsciplinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationDBDataSetDisciplines = new EducationDBDataSetDisciplines();
            this.educationDBDataSet = new EducationDBDataSet();
            this.educationDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIsciplinesTableAdapter = new DBDataSet.EducationDBDataSetDisciplinesTableAdapters.DIsciplinesTableAdapter();
            this.disciplineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDIsciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIsciplinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSetDisciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(33, 243);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 40);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Violet;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(235, 243);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 40);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(134, 243);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 40);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxForSpeciality
            // 
            this.textBoxForSpeciality.Location = new System.Drawing.Point(155, 163);
            this.textBoxForSpeciality.Name = "textBoxForSpeciality";
            this.textBoxForSpeciality.Size = new System.Drawing.Size(156, 22);
            this.textBoxForSpeciality.TabIndex = 30;
            // 
            // textBoxForSemester
            // 
            this.textBoxForSemester.Location = new System.Drawing.Point(155, 135);
            this.textBoxForSemester.Name = "textBoxForSemester";
            this.textBoxForSemester.Size = new System.Drawing.Size(156, 22);
            this.textBoxForSemester.TabIndex = 29;
            // 
            // textBoxForCode
            // 
            this.textBoxForCode.Location = new System.Drawing.Point(155, 106);
            this.textBoxForCode.Name = "textBoxForCode";
            this.textBoxForCode.Size = new System.Drawing.Size(156, 22);
            this.textBoxForCode.TabIndex = 28;
            // 
            // textBoxForName
            // 
            this.textBoxForName.Location = new System.Drawing.Point(155, 76);
            this.textBoxForName.Name = "textBoxForName";
            this.textBoxForName.Size = new System.Drawing.Size(156, 22);
            this.textBoxForName.TabIndex = 21;
            // 
            // labelForSpeciality
            // 
            this.labelForSpeciality.AutoSize = true;
            this.labelForSpeciality.Location = new System.Drawing.Point(35, 163);
            this.labelForSpeciality.Name = "labelForSpeciality";
            this.labelForSpeciality.Size = new System.Drawing.Size(109, 17);
            this.labelForSpeciality.TabIndex = 27;
            this.labelForSpeciality.Text = "Специальность";
            // 
            // labelForSemester
            // 
            this.labelForSemester.AutoSize = true;
            this.labelForSemester.Location = new System.Drawing.Point(37, 135);
            this.labelForSemester.Name = "labelForSemester";
            this.labelForSemester.Size = new System.Drawing.Size(64, 17);
            this.labelForSemester.TabIndex = 26;
            this.labelForSemester.Text = "Семестр";
            // 
            // labelForCode
            // 
            this.labelForCode.AutoSize = true;
            this.labelForCode.Location = new System.Drawing.Point(37, 106);
            this.labelForCode.Name = "labelForCode";
            this.labelForCode.Size = new System.Drawing.Size(33, 17);
            this.labelForCode.TabIndex = 25;
            this.labelForCode.Text = "Код";
            // 
            // labelForName
            // 
            this.labelForName.AutoSize = true;
            this.labelForName.Location = new System.Drawing.Point(37, 79);
            this.labelForName.Name = "labelForName";
            this.labelForName.Size = new System.Drawing.Size(72, 17);
            this.labelForName.TabIndex = 20;
            this.labelForName.Text = "Название";
            // 
            // dataGridViewDIsciplines
            // 
            this.dataGridViewDIsciplines.AutoGenerateColumns = false;
            this.dataGridViewDIsciplines.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDIsciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDIsciplines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplineIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn});
            this.dataGridViewDIsciplines.DataSource = this.dIsciplinesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDIsciplines.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDIsciplines.Location = new System.Drawing.Point(348, 31);
            this.dataGridViewDIsciplines.Name = "dataGridViewDIsciplines";
            this.dataGridViewDIsciplines.RowHeadersWidth = 30;
            this.dataGridViewDIsciplines.RowTemplate.Height = 30;
            this.dataGridViewDIsciplines.Size = new System.Drawing.Size(720, 416);
            this.dataGridViewDIsciplines.TabIndex = 23;
            this.dataGridViewDIsciplines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDIsciplines_CellContentClick);
            // 
            // dIsciplinesBindingSource
            // 
            this.dIsciplinesBindingSource.DataMember = "DIsciplines";
            this.dIsciplinesBindingSource.DataSource = this.educationDBDataSetDisciplines;
            // 
            // educationDBDataSetDisciplines
            // 
            this.educationDBDataSetDisciplines.DataSetName = "EducationDBDataSetDisciplines";
            this.educationDBDataSetDisciplines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // educationDBDataSet
            // 
            this.educationDBDataSet.DataSetName = "EducationDBDataSet";
            this.educationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // educationDBDataSetBindingSource
            // 
            this.educationDBDataSetBindingSource.DataSource = this.educationDBDataSet;
            this.educationDBDataSetBindingSource.Position = 0;
            // 
            // dIsciplinesTableAdapter
            // 
            this.dIsciplinesTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineIdDataGridViewTextBoxColumn
            // 
            this.disciplineIdDataGridViewTextBoxColumn.DataPropertyName = "DisciplineId";
            this.disciplineIdDataGridViewTextBoxColumn.HeaderText = "DisciplineId";
            this.disciplineIdDataGridViewTextBoxColumn.Name = "disciplineIdDataGridViewTextBoxColumn";
            this.disciplineIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.disciplineIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 75;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Семестр";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 65;
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            // 
            // DisciplinesMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1080, 459);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxForSpeciality);
            this.Controls.Add(this.textBoxForSemester);
            this.Controls.Add(this.textBoxForCode);
            this.Controls.Add(this.textBoxForName);
            this.Controls.Add(this.labelForSpeciality);
            this.Controls.Add(this.labelForSemester);
            this.Controls.Add(this.labelForCode);
            this.Controls.Add(this.labelForName);
            this.Controls.Add(this.dataGridViewDIsciplines);
            this.Name = "DisciplinesMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.DisciplinesMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDIsciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIsciplinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSetDisciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxForSpeciality;
        private System.Windows.Forms.TextBox textBoxForSemester;
        private System.Windows.Forms.TextBox textBoxForCode;
        private System.Windows.Forms.TextBox textBoxForName;
        private System.Windows.Forms.Label labelForSpeciality;
        private System.Windows.Forms.Label labelForSemester;
        private System.Windows.Forms.Label labelForCode;
        private System.Windows.Forms.Label labelForName;
        private System.Windows.Forms.DataGridView dataGridViewDIsciplines;
        private System.Windows.Forms.BindingSource educationDBDataSetBindingSource;
        private EducationDBDataSet educationDBDataSet;
        private EducationDBDataSetDisciplines educationDBDataSetDisciplines;
        private System.Windows.Forms.BindingSource dIsciplinesBindingSource;
        private DBDataSet.EducationDBDataSetDisciplinesTableAdapters.DIsciplinesTableAdapter dIsciplinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
    }
}