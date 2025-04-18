namespace studentBook
{
	partial class AddStudentForm
	{
		private TextBox txtSurname;
		private TextBox txtName;
		private TextBox txtPatronymic;
		private System.Windows.Forms.DateTimePicker BirthDate;
		private TextBox txtCourse;
		private TextBox txtGroup;
		private TextBox txtEmail;
		private TextBox txtPhone;

		private Button btnAdd;
		private Button btnCancel;

		private Label labelSurname;
		private Label labelName;
		private Label labelPatronymic;
		private Label labelCourse;
		private Label labelGroup;
		private Label labelEmail;
		private Label labelPhone;
		private Label labelBirthDate;
		private System.ComponentModel.IContainer components = null;



		private void InitializeComponent()
		{
			btnAdd = new Button();
			btnCancel = new Button();
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
			SuspendLayout();
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(100, 526);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(150, 80);
			btnAdd.TabIndex = 1;
			btnAdd.Text = "Добавить";
			btnAdd.Click += btnAdd_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(350, 526);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(150, 80);
			btnCancel.TabIndex = 0;
			btnCancel.Text = "Отмена";
			btnCancel.Click += btnCancel_Click;
			// 
			// txtSurname
			// 
			txtSurname.Location = new Point(203, 50);
			txtSurname.Name = "txtSurname";
			txtSurname.Size = new Size(200, 39);
			txtSurname.TabIndex = 0;
			txtSurname.TextChanged += txtSurname_TextChanged;
			// 
			// labelSurname
			// 
			labelSurname.Location = new Point(70, 49);
			labelSurname.Name = "labelSurname";
			labelSurname.Size = new Size(119, 40);
			labelSurname.TabIndex = 0;
			labelSurname.Text = "Фамилия:";
			// 
			// txtName
			// 
			txtName.Location = new Point(203, 100);
			txtName.Name = "txtName";
			txtName.Size = new Size(200, 39);
			txtName.TabIndex = 0;
			// 
			// labelName
			// 
			labelName.Location = new Point(121, 90);
			labelName.Name = "labelName";
			labelName.Size = new Size(68, 40);
			labelName.TabIndex = 0;
			labelName.Text = "Имя:";
			// 
			// txtPatronymic
			// 
			txtPatronymic.Location = new Point(203, 150);
			txtPatronymic.Name = "txtPatronymic";
			txtPatronymic.Size = new Size(200, 39);
			txtPatronymic.TabIndex = 0;
			// 
			// labelPatronymic
			// 
			labelPatronymic.Location = new Point(67, 150);
			labelPatronymic.Name = "labelPatronymic";
			labelPatronymic.Size = new Size(122, 40);
			labelPatronymic.TabIndex = 0;
			labelPatronymic.Text = "Отчество:";
			// 
			// BirthDate
			// 
			BirthDate.Location = new Point(203, 200);
			BirthDate.Name = "BirthDate";
			BirthDate.Size = new Size(289, 39);
			BirthDate.TabIndex = 0;
			// 
			// labelBirthDate
			// 
			labelBirthDate.Location = new Point(0, 200);
			labelBirthDate.Name = "labelBirthDate";
			labelBirthDate.Size = new Size(189, 40);
			labelBirthDate.TabIndex = 0;
			labelBirthDate.Text = "Дата рождения:";
			// 
			// txtCourse
			// 
			txtCourse.Location = new Point(203, 250);
			txtCourse.Name = "txtCourse";
			txtCourse.Size = new Size(200, 39);
			txtCourse.TabIndex = 0;
			// 
			// labelCourse
			// 
			labelCourse.Location = new Point(119, 249);
			labelCourse.Name = "labelCourse";
			labelCourse.Size = new Size(70, 40);
			labelCourse.TabIndex = 0;
			labelCourse.Text = "Курс:";
			// 
			// txtGroup
			// 
			txtGroup.Location = new Point(203, 300);
			txtGroup.Name = "txtGroup";
			txtGroup.Size = new Size(200, 39);
			txtGroup.TabIndex = 0;
			// 
			// labelGroup
			// 
			labelGroup.Location = new Point(92, 299);
			labelGroup.Name = "labelGroup";
			labelGroup.Size = new Size(97, 40);
			labelGroup.TabIndex = 0;
			labelGroup.Text = "Группа:";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(203, 350);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(200, 39);
			txtEmail.TabIndex = 0;
			// 
			// labelEmail
			// 
			labelEmail.Location = new Point(102, 349);
			labelEmail.Name = "labelEmail";
			labelEmail.Size = new Size(87, 40);
			labelEmail.TabIndex = 0;
			labelEmail.Text = "Почта:";
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(203, 400);
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(200, 39);
			txtPhone.TabIndex = 0;
			// 
			// labelPhone
			// 
			labelPhone.Location = new Point(70, 399);
			labelPhone.Name = "labelPhone";
			labelPhone.Size = new Size(115, 40);
			labelPhone.TabIndex = 0;
			labelPhone.Text = "Телефон:";
			// 
			// AddStudentForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(600, 650);
			Controls.Add(txtSurname);
			Controls.Add(labelSurname);
			Controls.Add(txtName);
			Controls.Add(labelName);
			Controls.Add(txtPatronymic);
			Controls.Add(labelPatronymic);
			Controls.Add(BirthDate);
			Controls.Add(labelBirthDate);
			Controls.Add(txtEmail);
			Controls.Add(labelEmail);
			Controls.Add(txtCourse);
			Controls.Add(labelCourse);
			Controls.Add(txtPhone);
			Controls.Add(labelPhone);
			Controls.Add(txtGroup);
			Controls.Add(labelGroup);
			Controls.Add(btnCancel);
			Controls.Add(btnAdd);
			Name = "AddStudentForm";
			Text = "AddStudentNewForm";
			Load += AddStudentForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}
	}
}