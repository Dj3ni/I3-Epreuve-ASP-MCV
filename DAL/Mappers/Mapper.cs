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
		/// <summary>
		/// Convert IDataRecord to DAL User
		/// </summary>
		/// <param name="record">IDataRecord</param>
		/// <returns>DAL User</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static User ToUser(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			return new User()
			{
				User_Id = (Guid)record[nameof(User.User_Id)],
				Pseudo = (string)record[nameof(User.Pseudo)],
				Email = (string)record[nameof(User.Email)],
				Password = "********",
				Deactivation_Date = (record[nameof(User.Deactivation_Date)] is DBNull)? null : (DateTime)record[nameof(User.Deactivation_Date)]
			};
		}

		public static Boardgame ToBoardgame(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			return new Boardgame()
			{
				Game_id = (int)record[nameof(Boardgame.Game_id)],
				Game_Title = (string)record[nameof(Boardgame.Game_Title)],
				Game_Description = (string)record[nameof(Boardgame.Game_Description)],
				MinAge = (int)record[nameof (Boardgame.MinAge)],
				MaxAge = (int)record[nameof(Boardgame.MaxAge)],
				MinPlayers = (int)record[nameof(Boardgame.MinPlayers)],
				MaxPlayers = (int)record[nameof(Boardgame.MaxPlayers)],
				Duration = (record[nameof(Boardgame.Duration)] is DBNull)? null : (int)record[nameof(Boardgame.Duration)],
				Registerer = (Guid)record[nameof(Boardgame.Registerer)],

			};
		}
	}
}
