using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
	internal static class Mapper
	{
		/// <summary>
		/// Convert DAL User to BLL User
		/// </summary>
		/// <param name="user">DAL User</param>
		/// <returns>BLL User</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static User ToBll(this DAL.Entities.User user)
		{
			if(user is null) throw new ArgumentNullException(nameof(user));
			return new User(
					user.User_Id,
					user.Pseudo,
					user.Password,
					user.Email,
					user.Deactivation_Date
				);
		}

		/// <summary>
		/// Convert BLL User to DAL User
		/// </summary>
		/// <param name="user">BLL User</param>
		/// <returns>DAL User</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static DAL.Entities.User ToDAL(this User user)
		{
			if (user is null) throw new ArgumentNullException(nameof(user));
			return new DAL.Entities.User()
			{
				User_Id = user.User_Id,
				Pseudo = user.Pseudo,
				Password = user.Password,
				Email = user.Email,
				Deactivation_Date = user.Deactivation_Date
			};
		}
	}
}
