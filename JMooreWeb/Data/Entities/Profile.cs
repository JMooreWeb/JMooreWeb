using System;
using System.ComponentModel.DataAnnotations;

namespace JMooreWeb.Data.Entities
{
	public class Profile
	{
		public int Id { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Display(Name = "Date Created")]
		public DateTime CreateDate { get; set; }

		public int UserId { get; set; }
		public virtual User User { get; set; }
	}
}