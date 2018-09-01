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
    public partial class TeachersMainForm : Form
    {
        Teachers model = new Teachers();

        public TeachersMainForm()
        {
            InitializeComponent();
        }

        private void TeachersMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationDBDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.educationDBDataSet.Teachers);
            Clear();
            PopulateDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите удалить элемент?","Операция удаления",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EducationDBEntities db = new EducationDBEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.Teachers.Attach(model);
                    }
                    db.Teachers.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    //MessageBox.Show("Удаление прошло успешно!");
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            model.TeacherName = textBox1.Text.Trim();
            model.Date = dateTimePicker.Value.Date;
            model.Position = textBox3.Text.Trim();
            model.Number = Int32.Parse(textBox4.Text);
            model.Department = textBox5.Text.Trim();
            model.Discipline = textBox6.Text.Trim();

            using (EducationDBEntities db = new EducationDBEntities())
            {
                if(model.TeacherId == 0)
                {
                    db.Teachers.Add(model);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridViewTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewTeachers.CurrentRow.Index != -1)
            {
                model.TeacherId = Convert.ToInt32(dataGridViewTeachers.CurrentRow.Cells["teacherIdDataGridViewTextBoxColumn"].Value);

                using (EducationDBEntities db = new EducationDBEntities())
                {
                    model = db.Teachers.Where(teacher => teacher.TeacherId == model.TeacherId).FirstOrDefault();
                    textBox1.Text = model.TeacherName;
                    dateTimePicker.Value = model.Date.Value;
                    textBox3.Text = model.Position;
                    textBox4.Text = model.Number.ToString();
                    textBox5.Text = model.Department;
                    textBox6.Text = model.Discipline;
                }
                buttonSave.Text = "Изменить";
                buttonDelete.Enabled = true;
            }
        }
        private void Clear()
        {
            textBox1.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
            dateTimePicker.Value = DateTime.Now;
            buttonSave.Text = "Сохранить";
            buttonDelete.Enabled = false;
            model.TeacherId = 0;
        }
        private void PopulateDataGridView()
        {
            dataGridViewTeachers.AutoGenerateColumns = false;
            using (EducationDBEntities db = new EducationDBEntities())
            {
                dataGridViewTeachers.DataSource = db.Teachers.ToList<Teachers>();
            }
        }

        private void buttonFilterDepartment_Click(object sender, EventArgs e)
        {
            Clear();
            textBox2_TextChanged(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string filterName = textBox2.Text;
            if (filterName != "")
            {
                using (EducationDBEntities db = new EducationDBEntities())
                {
                    dataGridViewTeachers.DataSource = db.Teachers.Where(teacher => teacher.Department == filterName).ToList();
                }
            }
            else
            {
                PopulateDataGridView();
            }
        }
    }
}
