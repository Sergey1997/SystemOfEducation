using WindowsFormsMain.DBDataSet;
using System.Windows.Forms;

using WindowsFormsMain.DBDataSet.EducationDBDataSetDepartmentsTableAdapters;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsMain
{
    partial class DepartmentsMainForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxForFaculty = new System.Windows.Forms.TextBox();
            this.textBoxForManager = new System.Windows.Forms.TextBox();
            this.textBoxForNumber = new System.Windows.Forms.TextBox();
            this.textBoxForName = new System.Windows.Forms.TextBox();
            this.labelForFaculty = new System.Windows.Forms.Label();
            this.labelForManager = new System.Windows.Forms.Label();
            this.labelForNumber = new System.Windows.Forms.Label();
            this.labelForName = new System.Windows.Forms.Label();
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationDBDataSetDepartments = new WindowsFormsMain.DBDataSet.EducationDBDataSetDepartments();
            this.departmentsTableAdapter = new WindowsFormsMain.DBDataSet.EducationDBDataSetDepartmentsTableAdapters.DepartmentsTableAdapter();
            this.labelForFilter = new System.Windows.Forms.Label();
            this.buttonToDepartment = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSetDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(39, 236);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 40);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Violet;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(241, 236);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 40);
            this.buttonCancel.TabIndex = 44;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(140, 236);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 40);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxForFaculty
            // 
            this.textBoxForFaculty.Location = new System.Drawing.Point(161, 156);
            this.textBoxForFaculty.Name = "textBoxForFaculty";
            this.textBoxForFaculty.Size = new System.Drawing.Size(156, 22);
            this.textBoxForFaculty.TabIndex = 42;
            // 
            // textBoxForManager
            // 
            this.textBoxForManager.Location = new System.Drawing.Point(161, 128);
            this.textBoxForManager.Name = "textBoxForManager";
            this.textBoxForManager.Size = new System.Drawing.Size(156, 22);
            this.textBoxForManager.TabIndex = 41;
            // 
            // textBoxForNumber
            // 
            this.textBoxForNumber.Location = new System.Drawing.Point(161, 99);
            this.textBoxForNumber.Name = "textBoxForNumber";
            this.textBoxForNumber.Size = new System.Drawing.Size(156, 22);
            this.textBoxForNumber.TabIndex = 40;
            // 
            // textBoxForName
            // 
            this.textBoxForName.Location = new System.Drawing.Point(161, 69);
            this.textBoxForName.Name = "textBoxForName";
            this.textBoxForName.Size = new System.Drawing.Size(156, 22);
            this.textBoxForName.TabIndex = 34;
            // 
            // labelForFaculty
            // 
            this.labelForFaculty.AutoSize = true;
            this.labelForFaculty.Location = new System.Drawing.Point(41, 156);
            this.labelForFaculty.Name = "labelForFaculty";
            this.labelForFaculty.Size = new System.Drawing.Size(80, 17);
            this.labelForFaculty.TabIndex = 39;
            this.labelForFaculty.Text = "Факультет";
            // 
            // labelForManager
            // 
            this.labelForManager.AutoSize = true;
            this.labelForManager.Location = new System.Drawing.Point(43, 128);
            this.labelForManager.Name = "labelForManager";
            this.labelForManager.Size = new System.Drawing.Size(92, 17);
            this.labelForManager.TabIndex = 38;
            this.labelForManager.Text = "Заведующий";
            // 
            // labelForNumber
            // 
            this.labelForNumber.AutoSize = true;
            this.labelForNumber.Location = new System.Drawing.Point(43, 99);
            this.labelForNumber.Name = "labelForNumber";
            this.labelForNumber.Size = new System.Drawing.Size(51, 17);
            this.labelForNumber.TabIndex = 37;
            this.labelForNumber.Text = "Номер";
            // 
            // labelForName
            // 
            this.labelForName.AutoSize = true;
            this.labelForName.Location = new System.Drawing.Point(43, 72);
            this.labelForName.Name = "labelForName";
            this.labelForName.Size = new System.Drawing.Size(72, 17);
            this.labelForName.TabIndex = 33;
            this.labelForName.Text = "Название";
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.AutoGenerateColumns = false;
            this.dataGridViewDepartments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.facultyDataGridViewTextBoxColumn});
            this.dataGridViewDepartments.DataSource = this.departmentsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDepartments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(354, 24);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.RowHeadersWidth = 30;
            this.dataGridViewDepartments.RowTemplate.Height = 30;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(644, 521);
            this.dataGridViewDepartments.TabIndex = 36;
            this.dataGridViewDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartments_CellContentClick);
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 70;
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "Manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "Зав. Кафедры";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.Width = 150;
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            this.facultyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.facultyDataGridViewTextBoxColumn.DataPropertyName = "Faculty";
            this.facultyDataGridViewTextBoxColumn.HeaderText = "Факультет";
            this.facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.educationDBDataSetDepartments;
            // 
            // educationDBDataSetDepartments
            // 
            this.educationDBDataSetDepartments.DataSetName = "EducationDBDataSetDepartments";
            this.educationDBDataSetDepartments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // labelForFilter
            // 
            this.labelForFilter.AutoSize = true;
            this.labelForFilter.Location = new System.Drawing.Point(36, 331);
            this.labelForFilter.Name = "labelForFilter";
            this.labelForFilter.Size = new System.Drawing.Size(135, 17);
            this.labelForFilter.TabIndex = 46;
            this.labelForFilter.Text = "Выберите кафедру";
            // 
            // buttonToDepartment
            // 
            this.buttonToDepartment.BackColor = System.Drawing.Color.Lime;
            this.buttonToDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToDepartment.Location = new System.Drawing.Point(38, 379);
            this.buttonToDepartment.Name = "buttonToDepartment";
            this.buttonToDepartment.Size = new System.Drawing.Size(197, 56);
            this.buttonToDepartment.TabIndex = 47;
            this.buttonToDepartment.Text = "Показать дисциплины";
            this.buttonToDepartment.UseVisualStyleBackColor = false;
            this.buttonToDepartment.Click += new System.EventHandler(this.buttonToDepartment_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DataSource = this.departmentsBindingSource1;
            this.comboBoxFilter.DisplayMember = "Name";
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(39, 351);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(196, 24);
            this.comboBoxFilter.TabIndex = 48;
            this.comboBoxFilter.ValueMember = "Name";
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // departmentsBindingSource1
            // 
            this.departmentsBindingSource1.DataMember = "Departments";
            this.departmentsBindingSource1.DataSource = this.educationDBDataSetDepartments;
            // 
            // DepartmentsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 557);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.buttonToDepartment);
            this.Controls.Add(this.labelForFilter);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxForFaculty);
            this.Controls.Add(this.textBoxForManager);
            this.Controls.Add(this.textBoxForNumber);
            this.Controls.Add(this.textBoxForName);
            this.Controls.Add(this.labelForFaculty);
            this.Controls.Add(this.labelForManager);
            this.Controls.Add(this.labelForNumber);
            this.Controls.Add(this.labelForName);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Name = "DepartmentsMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кафедры";
            this.Load += new System.EventHandler(this.DepartmentsMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDBDataSetDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private Button buttonDelete;
        private TextBox textBoxForFaculty;
        private TextBox textBoxForManager;
        private TextBox textBoxForNumber;
        private TextBox textBoxForName;
        private Label labelForFaculty;
        private Label labelForManager;
        private Label labelForNumber;
        private Label labelForName;
        private DataGridView dataGridViewDepartments;
        private EducationDBDataSetDepartments educationDBDataSetDepartments;
        private BindingSource departmentsBindingSource;
        private DBDataSet.EducationDBDataSetDepartmentsTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private Label labelForFilter;
        private Button buttonToDepartment;
        private ComboBox comboBoxFilter;
        private BindingSource departmentsBindingSource1;
    }
}