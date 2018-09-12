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
    public partial class DisciplinesMainForm : Form
    {
        DIsciplines model = new DIsciplines();

        public DisciplinesMainForm()
        {
            InitializeComponent();
        }

        private void DisciplinesMainForm_Load(object sender, EventArgs e)
        {
            this.dIsciplinesTableAdapter.Fill(this.educationDBDataSetDisciplines.DIsciplines);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            model.Name = textBoxForName.Text.Trim();
            model.Code = textBoxForCode.Text.Trim();
            model.Semester = Convert.ToInt32(textBoxForSemester.Text);
            model.Speciality = textBoxForSpeciality.Text.Trim();

            using (EducationDBEntities db = new EducationDBEntities())
            {
                if (model.DisciplineId == 0)
                {
                    db.DIsciplines.Add(model);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить элемент?", "Операция удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EducationDBEntities db = new EducationDBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.DIsciplines.Attach(model);
                    }
                    db.DIsciplines.Remove(model);
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
        private void Clear()
        {
            textBoxForName.Text = textBoxForCode.Text = textBoxForSemester.Text = textBoxForSpeciality.Text = "";
            buttonSave.Text = "Сохранить";
            buttonDelete.Enabled = false;
            model.DisciplineId = 0;
        }

        private void PopulateDataGridView()
        {
            dataGridViewDIsciplines.AutoGenerateColumns = false;
            using (EducationDBEntities db = new EducationDBEntities())
            {
                dataGridViewDIsciplines.DataSource = db.DIsciplines.ToList<DIsciplines>();
            }
        }

        private void dataGridViewDIsciplines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDIsciplines.CurrentRow.Index != -1)
            {
                model.DisciplineId = Convert.ToInt32(dataGridViewDIsciplines.CurrentRow.Cells["disciplineIdDataGridViewTextBoxColumn"].Value);

                using (EducationDBEntities db = new EducationDBEntities())
                {
                    model = db.DIsciplines.Where(discipline => discipline.DisciplineId == model.DisciplineId).FirstOrDefault();
                    textBoxForName.Text = model.Name;
                    textBoxForCode.Text = model.Code;
                    textBoxForSemester.Text = model.Semester.ToString();
                    textBoxForSpeciality.Text = model.Speciality;
                }
                buttonSave.Text = "Изменить";
                buttonDelete.Enabled = true;
            }
        }
    }
}
