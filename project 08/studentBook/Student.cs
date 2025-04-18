public class Student
{
	public Guid Id { get; } = Guid.NewGuid();
	public string Surname { get; set; }
	public string Name { get; set; }
	// Добавьте остальные свойства по аналогии
	public DateTime BirthDate { get; set; }

	public Student() { }
}