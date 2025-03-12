using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
	internal static class Mapper
	{
		public static User ToUser(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			return new User()
			{
				User_Id = (Guid)record[nameof(User.User_Id)],
				Pseudo = (string)record[nameof(User.Pseudo)],
				Email = (string)record[nameof(User.Email)],
				Password = (string)record[nameof(User.Password)],
				Deactivation_Date = (record[nameof(User.Deactivation_Date)] is DBNull)? null : (DateTime)record[nameof(User.Deactivation_Date)]
			};
		}
	}
}
