using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMain
{
    public partial class FormSystem : Form
    {
        public FormSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            TeachersMainForm teachersForm = new TeachersMainForm();
            teachersForm.Show();
        }

        private void buttonDepartments_Click(object sender, EventArgs e)
        {
            DepartmentsMainForm departmentsForm = new DepartmentsMainForm();
            departmentsForm.Show();
        }

        private void buttonDisciplines_Click(object sender, EventArgs e)
        {
            DisciplinesMainForm disciplinesForm = new DisciplinesMainForm();
            disciplinesForm.Show();
        }
    }
}
