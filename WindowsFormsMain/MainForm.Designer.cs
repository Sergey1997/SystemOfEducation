namespace WindowsFormsMain
{
    partial class FormSystem
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
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonDepartments = new System.Windows.Forms.Button();
            this.buttonDisciplines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTeachers.Location = new System.Drawing.Point(20, 130);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(200, 80);
            this.buttonTeachers.TabIndex = 0;
            this.buttonTeachers.Text = "Преподаватели";
            this.buttonTeachers.UseVisualStyleBackColor = false;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonDepartments
            // 
            this.buttonDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDepartments.Location = new System.Drawing.Point(250, 130);
            this.buttonDepartments.Name = "buttonDepartments";
            this.buttonDepartments.Size = new System.Drawing.Size(200, 80);
            this.buttonDepartments.TabIndex = 1;
            this.buttonDepartments.Text = "Кафедры";
            this.buttonDepartments.UseVisualStyleBackColor = false;
            this.buttonDepartments.Click += new System.EventHandler(this.buttonDepartments_Click);
            // 
            // buttonDisciplines
            // 
            this.buttonDisciplines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonDisciplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisciplines.Location = new System.Drawing.Point(480, 130);
            this.buttonDisciplines.Name = "buttonDisciplines";
            this.buttonDisciplines.Size = new System.Drawing.Size(200, 80);
            this.buttonDisciplines.TabIndex = 2;
            this.buttonDisciplines.Text = "Дисциплины";
            this.buttonDisciplines.UseVisualStyleBackColor = false;
            this.buttonDisciplines.Click += new System.EventHandler(this.buttonDisciplines_Click);
            // 
            // FormSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 368);
            this.Controls.Add(this.buttonDisciplines);
            this.Controls.Add(this.buttonDepartments);
            this.Controls.Add(this.buttonTeachers);
            this.Name = "FormSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебный процесс";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonDepartments;
        private System.Windows.Forms.Button buttonDisciplines;
    }
}

