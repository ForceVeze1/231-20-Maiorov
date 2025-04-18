using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Image = System.Drawing.Image;

namespace StudentBook.Forms
{
	partial class MainForm
	{

		private DataGridView dataGridView;

		private TextBox txtSurname;
		private TextBox txtName;
		private TextBox txtPatronymic;
		private System.Windows.Forms.DateTimePicker BirthDate;
		private TextBox txtCourse;
		private TextBox txtGroup;
		private TextBox txtEmail;
		private TextBox txtPhone;

		private Button btnAdd;

		private Label labelSurname;
		private Label labelName;
		private Label labelPatronymic;
		private Label labelCourse;
		private Label labelGroup;
		private Label labelEmail;
		private Label labelPhone;
		private Label labelBirthDate;

		private ToolStrip toolStrip;
		private ToolStripButton toolStripButtonSort;
		private ToolStripButton toolStripButtonDelete;
		private ToolStrip toolStrip1;
		private ToolStripButton toolStripButtonEdit;
		private ToolStripButton toolStripButtonOpen;

		private ToolStripDropDownButton FileDropDown;
		private ToolStripMenuItem ToolStripMenuSave;
		private ToolStripMenuItem ToolStripMenuSaveHow;
		private ToolStripMenuItem ToolStripMenuImportCSV;
		private ToolStripMenuItem ToolStripMenuExportCSV;

		private ToolStripButton toolStripAdd;

		private System.ComponentModel.IContainer components = null;

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			dataGridView = new DataGridView();
			btnAdd = new Button();
			txtSurname = new TextBox();
			labelSurname = new Label();
			txtName = new TextBox();
			labelName = new Label();
			txtPatronymic = new TextBox();
			labelPatronymic = new Label();
			BirthDate = new DateTimePicker();
			labelBirthDate = new Label();
			txtCourse = new TextBox();
			labelCourse = new Label();
			txtGroup = new TextBox();
			labelGroup = new Label();
			txtEmail = new TextBox();
			labelEmail = new Label();
			txtPhone = new TextBox();
			labelPhone = new Label();
			toolStripButtonSort = new ToolStripButton();
			toolStripButtonDelete = new ToolStripButton();
			toolStrip1 = new ToolStrip();
			FileDropDown = new ToolStripDropDownButton();
			ToolStripMenuSave = new ToolStripMenuItem();
			ToolStripMenuSaveHow = new ToolStripMenuItem();
			ToolStripMenuImportCSV = new ToolStripMenuItem();
			ToolStripMenuExportCSV = new ToolStripMenuItem();
			toolStripButtonEdit = new ToolStripButton();
			toolStripButtonOpen = new ToolStripButton();
			toolStripAdd = new ToolStripButton();
			toolStripButton1 = new ToolStripButton();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView
			// 
			dataGridView.ColumnHeadersHeight = 46;
			dataGridView.Location = new Point(13, 28);
			dataGridView.Name = "dataGridView";
			dataGridView.RowHeadersWidth = 82;
			dataGridView.Size = new Size(960, 300);
			dataGridView.TabIndex = 0;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(650, 400);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(261, 36);
			btnAdd.TabIndex = 1;
			btnAdd.Text = "Добавить";
			btnAdd.Click += btnAdd_Click;
			// 
			// txtSurname
			// 
			txtSurname.Location = new Point(160, 350);
			txtSurname.Name = "txtSurname";
			txtSurname.Size = new Size(100, 39);
			txtSurname.TabIndex = 0;
			// 
			// labelSurname
			// 
			labelSurname.Location = new Point(85, 350);
			labelSurname.Name = "labelSurname";
			labelSurname.Size = new Size(100, 23);
			labelSurname.TabIndex = 1;
			labelSurname.Text = "Фамилия:";
			// 
			// txtName
			// 
			txtName.Location = new Point(160, 380);
			txtName.Name = "txtName";
			txtName.Size = new Size(100, 39);
			txtName.TabIndex = 1;
			// 
			// labelName
			// 
			labelName.Location = new Point(85, 380);
			labelName.Name = "labelName";
			labelName.Size = new Size(100, 23);
			labelName.TabIndex = 2;
			labelName.Text = "Имя:";
			// 
			// txtPatronymic
			// 
			txtPatronymic.Location = new Point(160, 410);
			txtPatronymic.Name = "txtPatronymic";
			txtPatronymic.Size = new Size(100, 39);
			txtPatronymic.TabIndex = 2;
			// 
			// labelPatronymic
			// 
			labelPatronymic.Location = new Point(85, 410);
			labelPatronymic.Name = "labelPatronymic";
			labelPatronymic.Size = new Size(100, 23);
			labelPatronymic.TabIndex = 3;
			labelPatronymic.Text = "Отчество:";
			// 
			// BirthDate
			// 
			BirthDate.Location = new Point(160, 440);
			BirthDate.Name = "BirthDate";
			BirthDate.Size = new Size(130, 39);
			BirthDate.TabIndex = 3;
			// 
			// labelBirthDate
			// 
			labelBirthDate.Location = new Point(60, 440);
			labelBirthDate.Name = "labelBirthDate";
			labelBirthDate.Size = new Size(100, 23);
			labelBirthDate.TabIndex = 4;
			labelBirthDate.Text = "День рождения:";
			// 
			// txtCourse
			// 
			txtCourse.Location = new Point(400, 350);
			txtCourse.Name = "txtCourse";
			txtCourse.Size = new Size(100, 39);
			txtCourse.TabIndex = 4;
			// 
			// labelCourse
			// 
			labelCourse.Location = new Point(350, 350);
			labelCourse.Name = "labelCourse";
			labelCourse.Size = new Size(100, 23);
			labelCourse.TabIndex = 5;
			labelCourse.Text = "Курс:";
			// 
			// txtGroup
			// 
			txtGroup.Location = new Point(400, 380);
			txtGroup.Name = "txtGroup";
			txtGroup.Size = new Size(100, 39);
			txtGroup.TabIndex = 5;
			// 
			// labelGroup
			// 
			labelGroup.Location = new Point(350, 380);
			labelGroup.Name = "labelGroup";
			labelGroup.Size = new Size(100, 23);
			labelGroup.TabIndex = 6;
			labelGroup.Text = "Группа:";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(400, 410);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(100, 39);
			txtEmail.TabIndex = 6;
			// 
			// labelEmail
			// 
			labelEmail.Location = new Point(350, 410);
			labelEmail.Name = "labelEmail";
			labelEmail.Size = new Size(100, 23);
			labelEmail.TabIndex = 7;
			labelEmail.Text = "Email:";
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(400, 440);
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(100, 39);
			txtPhone.TabIndex = 7;
			// 
			// labelPhone
			// 
			labelPhone.Location = new Point(350, 440);
			labelPhone.Name = "labelPhone";
			labelPhone.Size = new Size(100, 23);
			labelPhone.TabIndex = 8;
			labelPhone.Text = "Телефон:";
			// 
			// toolStripButtonSort
			// 
			toolStripButtonSort.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButtonSort.ImageTransparentColor = Color.Magenta;
			toolStripButtonSort.Name = "toolStripButtonSort";
			toolStripButtonSort.Size = new Size(150, 36);
			toolStripButtonSort.Text = "Сортировка";
			toolStripButtonSort.Click += toolStripButtonSort_Click;
			// 
			// toolStripButtonDelete
			// 
			toolStripButtonDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButtonDelete.ImageTransparentColor = Color.Magenta;
			toolStripButtonDelete.Name = "toolStripButtonDelete";
			toolStripButtonDelete.Size = new Size(124, 36);
			toolStripButtonDelete.Text = "Удаление";
			toolStripButtonDelete.Click += toolStripButtonDelete_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = SystemColors.Menu;
			toolStrip1.ImageScalingSize = new Size(32, 32);
			toolStrip1.Items.AddRange(new ToolStripItem[] { FileDropDown, toolStripButtonSort, toolStripButtonDelete, toolStripButtonEdit, toolStripButtonOpen, toolStripAdd, toolStripButton1 });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(975, 42);
			toolStrip1.TabIndex = 9;
			toolStrip1.ItemClicked += toolStrip1_ItemClicked_1;
			// 
			// FileDropDown
			// 
			FileDropDown.DisplayStyle = ToolStripItemDisplayStyle.Text;
			FileDropDown.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuSave, ToolStripMenuSaveHow, ToolStripMenuImportCSV, ToolStripMenuExportCSV });
			FileDropDown.Image = (Image)resources.GetObject("FileDropDown.Image");
			FileDropDown.ImageTransparentColor = Color.Magenta;
			FileDropDown.Name = "FileDropDown";
			FileDropDown.Size = new Size(92, 36);
			FileDropDown.Text = "Файл";
			// 
			// ToolStripMenuSave
			// 
			ToolStripMenuSave.Name = "ToolStripMenuSave";
			ToolStripMenuSave.Size = new Size(356, 44);
			ToolStripMenuSave.Text = "Сохранить";
			ToolStripMenuSave.Click += toolStripMenuSave_Click;
			// 
			// ToolStripMenuSaveHow
			// 
			ToolStripMenuSaveHow.Name = "ToolStripMenuSaveHow";
			ToolStripMenuSaveHow.Size = new Size(356, 44);
			ToolStripMenuSaveHow.Text = "Сохранить как";
			ToolStripMenuSaveHow.Click += toolStripMenuSaveAs_Click;
			// 
			// ToolStripMenuImportCSV
			// 
			ToolStripMenuImportCSV.Name = "ToolStripMenuImportCSV";
			ToolStripMenuImportCSV.Size = new Size(356, 44);
			ToolStripMenuImportCSV.Text = "Импорт .csv файла";
			ToolStripMenuImportCSV.Click += toolStripMenuImportCSV_Click;
			// 
			// ToolStripMenuExportCSV
			// 
			ToolStripMenuExportCSV.Name = "ToolStripMenuExportCSV";
			ToolStripMenuExportCSV.Size = new Size(356, 44);
			ToolStripMenuExportCSV.Text = "Экспорт .csv файла";
			ToolStripMenuExportCSV.Click += toolStripMenuExportCSV_Click;
			// 
			// toolStripButtonEdit
			// 
			toolStripButtonEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButtonEdit.ImageTransparentColor = Color.Magenta;
			toolStripButtonEdit.Name = "toolStripButtonEdit";
			toolStripButtonEdit.Size = new Size(199, 36);
			toolStripButtonEdit.Text = "Редактирование";
			toolStripButtonEdit.Click += toolStripButtonEdit_Click;
			// 
			// toolStripButtonOpen
			// 
			toolStripButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButtonOpen.ImageTransparentColor = Color.Magenta;
			toolStripButtonOpen.Name = "toolStripButtonOpen";
			toolStripButtonOpen.Size = new Size(111, 36);
			toolStripButtonOpen.Text = "Открыть";
			toolStripButtonOpen.Click += toolStripButtonOpen_Click;
			// 
			// toolStripAdd
			// 
			toolStripAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripAdd.Image = (Image)resources.GetObject("toolStripAdd.Image");
			toolStripAdd.ImageTransparentColor = Color.Magenta;
			toolStripAdd.Name = "toolStripAdd";
			toolStripAdd.Size = new Size(124, 36);
			toolStripAdd.Text = "Добавить";
			toolStripAdd.Click += btnAdd_Click;
			// 
			// toolStripButton1
			// 
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(150, 36);
			toolStripButton1.Text = "Сортировка";
			// 
			// MainForm
			// 
			BackColor = SystemColors.ButtonHighlight;
			ClientSize = new Size(975, 497);
			Controls.Add(toolStrip1);
			Controls.Add(dataGridView);
			MaximumSize = new Size(1001, 568);
			MinimumSize = new Size(1001, 568);
			Name = "MainForm";
			Text = "StudentBook";
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		private ToolStripButton toolStripButton1;
	}
}