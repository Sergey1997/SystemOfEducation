using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsMain.Data;

namespace WindowsFormsMain
{
    public partial class DepartmentsMainForm : Form
    {

        Departments model = new Departments();

        public DepartmentsMainForm()
        {
            InitializeComponent();
        }

        private void DepartmentsMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationDBDataSetDepartments.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.educationDBDataSetDepartments.Departments);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            model.Name = textBoxForName.Text.Trim();
            model.Number = Convert.ToInt32(textBoxForNumber.Text);
            model.Manager = textBoxForManager.Text.Trim();
            model.Faculty = textBoxForFaculty.Text.Trim();

            using (EducationDBEntities db = new EducationDBEntities())
            {
                if (model.DepartmentId == 0)
                {
                    db.Departments.Add(model);
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                }

                db.SaveChanges();
            }

            Clear();
            PopulateDataGridView();
            MessageBox.Show("Отправлено успешно!");
        }
        private void Clear()
        {
            textBoxForName.Text = textBoxForNumber.Text = textBoxForFaculty.Text = textBoxForManager.Text = "";
            buttonSave.Text = "Сохранить";
            buttonDelete.Enabled = false;
            model.DepartmentId = 0;
        }

        private void PopulateDataGridView()
        {
            dataGridViewDepartments.AutoGenerateColumns = false;
            using (EducationDBEntities db = new EducationDBEntities())
            {
                dataGridViewDepartments.DataSource = db.Departments.ToList();
            }
        }

        private void dataGridViewDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDepartments.CurrentRow.Index != -1)
            {
                model.DepartmentId = Convert.ToInt32(dataGridViewDepartments.CurrentRow.Cells["departmentIdDataGridViewTextBoxColumn"].Value);

                using (EducationDBEntities db = new EducationDBEntities())
                {
                    model = db.Departments.Where(department => department.DepartmentId == model.DepartmentId).FirstOrDefault();
                    textBoxForName.Text = model.Name;
                    textBoxForNumber.Text = model.Number.ToString();
                    textBoxForManager.Text = model.Manager;
                    textBoxForFaculty.Text = model.Faculty;
                }
                buttonSave.Text = "Изменить";
                buttonDelete.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить элемент?", "Операция удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EducationDBEntities db = new EducationDBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Departments.Attach(model);
                    }
                    db.Departments.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    //MessageBox.Show("Удаление прошло успешно!");
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonToDepartment_Click(object sender, EventArgs e)
        {
            string department = comboBoxFilter.Text;
            List<string> disciplines = null;
            using (EducationDBEntities db = new EducationDBEntities())
            {
                var teachers = db.Teachers.Where(teacher => teacher.Department == department);
                disciplines = teachers.Select(x => x.Discipline).ToList();
            }
            if(disciplines == null)
            {
                MessageBox.Show("Дисциплин нет");

            }
            else
            {
                MessageBox.Show(string.Join("\n",disciplines), "Кафедра " + department);
            }
        } 

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
