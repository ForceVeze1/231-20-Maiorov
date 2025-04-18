using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using studentBook;
using StudentBook.Models;
using StudentBook.Utilities;


namespace StudentBook.Forms
{
	public partial class MainForm : Form
	{
		private BindingList<Student> students = new BindingList<Student>();
		private bool hasUnsavedChanges = false;
		// Добавьте в начало класса
		private readonly string savePath = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
			"StudentBook",
			"students.json");
		public MainForm()
		{
			InitializeComponent();
			ConfigureDataGridView();

		}
		private void ConfigureDataGridView()
		{
			dataGridView.ReadOnly = true; // Запрет редактирования
			dataGridView.AllowUserToAddRows = false; // Запрет добавления строк
			dataGridView.AllowUserToDeleteRows = false; // Запрет удаления строк
			dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically; // Редактирование только через код

			// Дополнительные настройки
			dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Выделение всей строки
			dataGridView.MultiSelect = false; // Запрет множественного выбора
			dataGridView.DataSource = students;
			dataGridView.AutoGenerateColumns = false;

			// Убедитесь, что все колонки правильно привязаны
			foreach (DataGridViewColumn column in dataGridView.Columns)
			{
				column.DataPropertyName = column.HeaderText switch
				{
					"Фамилия" => nameof(Student.Surname),
					"Имя" => nameof(Student.Name),
					"Отчество" => nameof(Student.Patronymic),
					"Курс" => nameof(Student.Course),
					"Группа" => nameof(Student.Group),
					"Дата рождения" => nameof(Student.BirthDate),
					"Электронная почта" => nameof(Student.Email),
					"Телефон" => nameof(Student.Phone),
					_ => column.DataPropertyName
				};
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (var addForm = new AddStudentForm())
			{
				if (addForm.ShowDialog() == DialogResult.OK)
				{
					students.Add(addForm.NewStudent);
					hasUnsavedChanges = true;
					dataGridView.Refresh();
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				// 1. Проверка наличия данных для сохранения
				if (students == null || students.Count == 0)
				{
					MessageBox.Show("Нет данных для сохранения!", "Информация",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				// 2. Создание директории при необходимости
				var directory = Path.GetDirectoryName(savePath);
				if (!Directory.Exists(directory))
				{
					Directory.CreateDirectory(directory);
					Console.WriteLine($"Создана директория: {directory}");
				}

				// 3. Сериализация данных
				var jsonData = JsonConvert.SerializeObject(students.ToList(), Formatting.Indented);

				// 4. Запись в файл с проверкой
				File.WriteAllText(savePath, jsonData, Encoding.UTF8);

				// 5. Обновление статуса
				hasUnsavedChanges = false;

				// 6. Уведомление пользователя
				MessageBox.Show($"Данные успешно сохранены в:\n{savePath}", "Сохранение",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

				// 7. Логирование успеха
				Console.WriteLine($"Успешное сохранение в {DateTime.Now}");
			}
			catch (Exception ex)
			{
				// Подробная диагностика ошибок
				string errorDetails = $"Тип ошибки: {ex.GetType().Name}\n" +
									  $"Сообщение: {ex.Message}\n" +
									  $"Стек вызовов: {ex.StackTrace}";

				MessageBox.Show($"Ошибка сохранения:\n{errorDetails}", "Критическая ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Логирование ошибки
				File.AppendAllText("error.log", $"[{DateTime.Now}] ERROR: {errorDetails}\n");
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (hasUnsavedChanges)
			{
				var result = MessageBox.Show("Сохранить изменения?", "Внимание",
				  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

				if (result == DialogResult.Yes) btnSave_Click(null, null);
				else if (result == DialogResult.Cancel) e.Cancel = true;
			}
			base.OnFormClosing(e);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{


			if (dataGridView.CurrentRow == null)
			{
				MessageBox.Show("Выберите студента для удаления!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var student = dataGridView.CurrentRow.DataBoundItem as Student;
			if (student != null)
			{
				students.Remove(student);
				hasUnsavedChanges = true;
			}

		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			if (students.Count == 0)
			{
				MessageBox.Show("Список студентов пуст!", "Информация",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// Сортировка по фамилии и имени
			var sorted = new BindingList<Student>(
				students.OrderBy(s => s.Surname)
						.ThenBy(s => s.Name)
						.ToList());

			students.Clear();
			foreach (var student in sorted)
			{
				students.Add(student);
			}

			dataGridView.Refresh();
			hasUnsavedChanges = true;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dataGridView.CurrentRow == null)
			{
				MessageBox.Show("Выберите студента для редактирования!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var selectedStudent = dataGridView.CurrentRow.DataBoundItem as Student;
			if (selectedStudent == null) return;

			using (var editForm = new AddStudentForm(selectedStudent))
			{
				if (editForm.ShowDialog() == DialogResult.OK)
				{
					// Обновляем данные студента
					var index = students.IndexOf(selectedStudent);
					students[index] = editForm.NewStudent;

					dataGridView.Refresh();
					hasUnsavedChanges = true;
				}
			}
		}
		private void btnSaveAs_Click(object sender, EventArgs e)
		{
			try
			{
				if (students == null || students.Count == 0)
				{
					MessageBox.Show("Нет данных для сохранения!", "Информация",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				using (SaveFileDialog saveDialog = new SaveFileDialog())
				{
					saveDialog.Filter = "JSON файлы (*.json)|*.json|CSV файлы (*.csv)|*.csv";
					saveDialog.Title = "Сохранить как...";
					saveDialog.OverwritePrompt = true;
					saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

					if (saveDialog.ShowDialog() == DialogResult.OK)
					{
						switch (Path.GetExtension(saveDialog.FileName).ToLower())
						{
							case ".json":
								SaveAsJson(saveDialog.FileName);
								break;
							case ".csv":
								SaveAsCsv(saveDialog.FileName);
								break;
							default:
								throw new NotSupportedException("Выбран неподдерживаемый формат файла");
						}

						MessageBox.Show($"Файл успешно сохранен:\n{saveDialog.FileName}", "Сохранение",
							MessageBoxButtons.OK, MessageBoxIcon.Information);

						hasUnsavedChanges = false;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка сохранения файла:\n{ex.Message}", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private void SaveAsJson(string path)
		{
			string json = JsonConvert.SerializeObject(students.ToList(), Formatting.Indented);
			File.WriteAllText(path, json, Encoding.UTF8);
		}
		private void SaveAsCsv(string path)
		{
			var csvContent = new StringBuilder();

			// Заголовки CSV
			csvContent.AppendLine("Surname;Name;Patronymic;Course;Group;BirthDate;Email;Phone");

			foreach (var student in students)
			{
				csvContent.AppendLine(
					$"{EscapeCsv(student.Surname)};" +
					$"{EscapeCsv(student.Name)};" +
					$"{EscapeCsv(student.Patronymic)};" +
					$"{student.Course};" +
					$"{EscapeCsv(student.Group)};" +
					$"{student.BirthDate:dd.MM.yyyy};" +
					$"{EscapeCsv(student.Email)};" +
					$"{EscapeCsv(student.Phone)}");
			}

			File.WriteAllText(path, csvContent.ToString(), Encoding.UTF8);
		}
		private string EscapeCsv(string value)
		{
			if (string.IsNullOrEmpty(value)) return string.Empty;
			return value.Contains(";") ? $"\"{value}\"" : value;
		}
		// Для кнопки удаления
		private void toolStripButtonDelete_Click(object sender, EventArgs e)
		{
			btnDelete_Click(sender, e);
		}

		private void btnExportCSV_Click(object sender, EventArgs e)
		{
			try
			{
				if (students == null || students.Count == 0)
				{
					MessageBox.Show("Нет данных для сохранения!", "Информация",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				using (SaveFileDialog saveDialog = new SaveFileDialog())
				{
					saveDialog.Filter = "CSV файлы (*.csv)|*.csv";
					saveDialog.Title = "Export .csv";
					saveDialog.OverwritePrompt = true;
					saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

					if (saveDialog.ShowDialog() == DialogResult.OK)
					{
						switch (Path.GetExtension(saveDialog.FileName).ToLower())
						{
							case ".csv":
								SaveAsCsv(saveDialog.FileName);
								break;
							default:
								throw new NotSupportedException("Выбран неподдерживаемый формат файла");
						}

						MessageBox.Show($"Файл успешно сохранен:\n{saveDialog.FileName}", "Сохранение",
							MessageBoxButtons.OK, MessageBoxIcon.Information);

						hasUnsavedChanges = false;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка сохранения файла:\n{ex.Message}", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnImportCSV_Click(object sender, EventArgs e)
		{
			try
			{
				// Проверка несохраненных изменений
				if (hasUnsavedChanges)
				{
					var result = MessageBox.Show("Сохранить текущие изменения перед импортом?",
						"Несохраненные изменения",
						MessageBoxButtons.YesNoCancel,
						MessageBoxIcon.Warning);

					if (result == DialogResult.Yes) btnSave_Click(sender, e);
					else if (result == DialogResult.Cancel) return;
				}

				using (OpenFileDialog openDialog = new OpenFileDialog())
				{
					openDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
					openDialog.Title = "Импорт CSV файла";

					if (openDialog.ShowDialog() == DialogResult.OK)
					{
						var importedStudents = new List<Student>();
						var errors = new List<string>();
						int lineNumber = 1;

						using (var reader = new StreamReader(openDialog.FileName))
						using (var csv = new CsvReader(reader,
							new CsvConfiguration(CultureInfo.InvariantCulture)
							{
								Delimiter = ";",
								MissingFieldFound = null,
								HeaderValidated = null
							}))
						{
							csv.Context.RegisterClassMap<StudentMap>();

							while (csv.Read())
							{
								lineNumber++;
								try
								{
									var record = csv.GetRecord<Student>();
									Validators.ValidateStudent(record);
									importedStudents.Add(record);
								}
								catch (Exception ex)
								{
									errors.Add($"Строка {lineNumber}: {ex.Message}");
								}
							}
						}

						// Очищаем текущие данные
						students.Clear();

						// Добавляем новых студентов
						foreach (var student in importedStudents)
						{
							students.Add(student);
						}

						// Обновляем интерфейс
						dataGridView.Refresh();
						hasUnsavedChanges = true;

						// Показываем результаты импорта
						string message = $"Успешно импортировано: {importedStudents.Count} записей";
						if (errors.Count > 0)
						{
							message += $"\nОшибки ({errors.Count}):\n" +
									  string.Join("\n", errors.Take(5));
							if (errors.Count > 5) message += "\n...";
						}

						MessageBox.Show(message, "Результат импорта",
							MessageBoxButtons.OK,
							errors.Count > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка импорта: {ex.Message}", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		public sealed class StudentMap : ClassMap<Student>
		{
			public StudentMap()
			{
				Map(m => m.Surname).Name("Surname");
				Map(m => m.Name).Name("Name");
				Map(m => m.Patronymic).Name("Patronymic");
				Map(m => m.Course).Name("Course");
				Map(m => m.Group).Name("Group");
				Map(m => m.BirthDate).Name("BirthDate")
					.TypeConverterOption.Format("dd.MM.yyyy");
				Map(m => m.Email).Name("Email");
				Map(m => m.Phone).Name("Phone");
			}
		}

		// Для кнопки сортировки
		private void toolStripButtonSort_Click(object sender, EventArgs e)
		{
			btnSort_Click(sender, e);
		}

		// Для кнопки редактирования
		private void toolStripButtonEdit_Click(object sender, EventArgs e)
		{
			btnEdit_Click(sender, e);
		}
		// Для кнопки сохранения
		private void toolStripButtonSave_Click(object sender, EventArgs e)
		{
			btnSave_Click(sender, e); // Вызываем существующий метод сохранения
		}

		private void toolStripButtonOpen_Click(object sender, EventArgs e)
		{
			try
			{
				// Проверка несохраненных изменений
				if (hasUnsavedChanges)
				{
					var result = MessageBox.Show("Сохранить текущие изменения перед открытием нового файла?",
						"Несохраненные изменения",
						MessageBoxButtons.YesNoCancel,
						MessageBoxIcon.Warning);

					if (result == DialogResult.Yes) btnSave_Click(sender, e);
					else if (result == DialogResult.Cancel) return;
				}

				using (OpenFileDialog openDialog = new OpenFileDialog())
				{
					openDialog.Filter = "JSON files|*.json|All files|*.*";
					openDialog.Title = "Выберите файл данных студентов";
					openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

					if (openDialog.ShowDialog() == DialogResult.OK)
					{
						// Чтение и десериализация файла
						string json = File.ReadAllText(openDialog.FileName, Encoding.UTF8);
						List<Student> loadedStudents = JsonConvert.DeserializeObject<List<Student>>(json);

						// Обновление данных
						students.Clear();
						foreach (var student in loadedStudents)
						{
							students.Add(student);
						}

						// Обновление интерфейса
						dataGridView.Refresh();
						hasUnsavedChanges = false;
						MessageBox.Show($"Успешно загружено {loadedStudents.Count} записей", "Открытие файла",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (JsonException jsonEx)
			{
				MessageBox.Show($"Ошибка формата файла: {jsonEx.Message}", "Ошибка JSON",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}



		private void toolStripMenuSave_Click(object sender, EventArgs e)
		{
			btnSave_Click(sender, e);
		}

		private void toolStripMenuSaveAs_Click(object sender, EventArgs e)
		{
			btnSaveAs_Click(sender, e);
		}

		private void toolStripMenuExportCSV_Click(object sender, EventArgs e)
		{
			btnExportCSV_Click(sender, e);
		}
		private void toolStripMenuImportCSV_Click(object sender, EventArgs e)
		{
			btnImportCSV_Click(sender, e);
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}