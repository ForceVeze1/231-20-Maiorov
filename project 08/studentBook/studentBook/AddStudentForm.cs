using StudentBook.Models;
using StudentBook.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentBook
{
	public partial class AddStudentForm : Form
	{
		public Student NewStudent { get; private set; }
		private bool isEditMode = false;
		public AddStudentForm()
		{
			InitializeComponent();
			BirthDate.Value = DateTime.Today;
		}
		public AddStudentForm(Student studentToEdit)
		{
			InitializeComponent();
			isEditMode = true;
			NewStudent = (Student)studentToEdit.Clone(); // Клонируем объект
			LoadStudentData(NewStudent); // Загружаем данные в форму
			btnAdd.Text = "Сохранить изменения";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				Student student;

				if (isEditMode)
				{
					// Используем существующий объект
					student = NewStudent ?? throw new InvalidOperationException("Режим редактирования без объекта студента");
				}
				else
				{
					// Создаем новый объект
					student = new Student();
				}

				// Заполняем/обновляем данные
				student.Surname = txtSurname.Text.Trim();
				student.Name = txtName.Text.Trim();
				student.Patronymic = txtPatronymic.Text.Trim();
				student.Course = int.Parse(txtCourse.Text);
				student.Group = txtGroup.Text.Trim();
				student.BirthDate = BirthDate.Value;
				student.Email = txtEmail.Text.Trim();
				student.Phone = txtPhone.Text.Trim();

				Validators.ValidateStudent(student);

				if (!isEditMode)
				{
					NewStudent = student; // Для нового студента
				}

				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadStudentData(Student student)
		{
			txtSurname.Text = student.Surname;
			txtName.Text = student.Name;
			txtPatronymic.Text = student.Patronymic;
			BirthDate.Value = student.BirthDate;
			txtCourse.Text = student.Course.ToString();
			txtGroup.Text = student.Group;
			txtEmail.Text = student.Email;
			txtPhone.Text = student.Phone;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddStudentForm_Load(object sender, EventArgs e)
		{

		}


		private void labelBirthDate_Click(object sender, EventArgs e)
		{

		}

		private void txtSurname_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
