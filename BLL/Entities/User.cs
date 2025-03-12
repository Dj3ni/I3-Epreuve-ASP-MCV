using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
	public class User
	{
		public Guid User_Id { get; set; }
		public string Pseudo { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime? Deactivation_Date { get; set; }

		public User(Guid user_id, string pseudo, string email, string password, DateTime? deactivation_date)
		{
			User_Id = user_id;
			Pseudo = pseudo;
			Email = email;
			Password = password;
			Deactivation_Date = deactivation_date;
		}

		public User(Guid user_id, string pseudo, string email, string password) :this(user_id, pseudo, email, password, null){ }
	}
}
