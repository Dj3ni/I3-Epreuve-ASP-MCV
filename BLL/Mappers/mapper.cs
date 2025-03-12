﻿using BLL.Entities;
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
					user.Email,
					user.Password,
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

		/// <summary>
		/// Convert DAL Boardgame to BLL Boardgame
		/// </summary>
		/// <param name="game">DAL Boardgame</param>
		/// <returns>BLL Boardgame</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static Boardgame ToBLL(this DAL.Entities.Boardgame game)
		{
			if(game is null) throw new ArgumentNullException( nameof(game));
			return new Boardgame(
				game.Game_id,
				game.Game_Title,
				game.Game_Description,
				game.MinAge,
				game.MaxAge,
				game.MinPlayers,
				game.MaxPlayers,
				game.Duration,
				game.Registerer
				);
		}

		/// <summary>
		/// Convert BLL Boardgame to DAL Boardgame
		/// </summary>
		/// <param name="game">BLL Boardgame</param>
		/// <returns>DAL Boardgame</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static DAL.Entities.Boardgame ToDAL(this Boardgame game)
		{
			if (game is null) throw new ArgumentNullException(nameof(game));
			return new DAL.Entities.Boardgame()
			{
				Game_id = game.Game_id,
				Game_Title = game.Game_Title,
				Game_Description = game.Game_Description,
				MinAge = game.MinAge,
				MaxAge = game.MaxAge,
				MinPlayers = game.MinPlayers,
				MaxPlayers = game.MaxPlayers,
				Duration = game.Duration,
				Registerer = game.Registerer
			};
		}
	}
}
