using Newtonsoft.Json;
using System;

namespace StudentBook.Models
{
	public class Student : ICloneable
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		[JsonProperty("Surname")]
		public string Surname { get; set; }
		[JsonProperty("Name")]
		public string Name { get; set; }
		[JsonProperty("Patronymic")]
		public string Patronymic { get; set; }
		[JsonProperty("Course")]
		public int Course { get; set; }
		[JsonProperty("Group")]
		public string Group { get; set; }
		[JsonProperty("BirthDate")]
		public DateTime BirthDate { get; set; }
		[JsonProperty("Email")]
		public string Email { get; set; }
		[JsonProperty("Phone")]
		public string Phone { get; set; }


		public object Clone()
		{
			return new Student
			{
				Id = this.Id,
				Surname = this.Surname,
				Name = this.Name,
				Patronymic = this.Patronymic,
				Course = this.Course,
				Group = this.Group,
				BirthDate = this.BirthDate,
				Email = this.Email,
				Phone = this.Phone
			};
		}
	}
}	