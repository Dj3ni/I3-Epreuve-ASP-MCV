using ASP_MVC.Models.Boardgame;
using BLL.Entities;

namespace ASP_MVC.Mappers
{
	internal static class BoardgameMapper
	{
		/// <summary>
		/// Convert BLL Boardgame to BoardgameListItem view model
		/// </summary>
		/// <param name="game">BLL Boardgame</param>
		/// <returns>BoardgameListItem</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static BoardgameListItem ToListItem(this Boardgame game)
		{
			if(game is null) throw new ArgumentNullException(nameof(game));
			return new BoardgameListItem()
			{
				Game_id = game.Game_id,
				Game_Title = game.Game_Title,
			};
		}

		/// <summary>
		/// Convert BLL Boardgame To BoardgameDetails view model
		/// </summary>
		/// <param name="game"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static BoardgameDetails ToDetails(this Boardgame game)
		{
			if( game is null) throw new ArgumentNullException( nameof(game));
			return new BoardgameDetails()
			{
				Game_id = game.Game_id,
				Game_Title = game.Game_Title,
				Game_Description = game.Game_Description,
				MinAge = game.MinAge,
				MaxAge = game.MaxAge,
				MinPlayers = game.MinPlayers,
				MaxPlayers = game.MaxPlayers,
				Duration = game.Duration,
				Registerer = game.Registerer,
			};
		}

		/// <summary>
		/// Convert data from BoardgameCreate form to a BLL Boardgame
		/// </summary>
		/// <param name="form">BoardgameCreate</param>
		/// <returns>BLL Boardgame</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static Boardgame ToBLL(this BoardgameCreate form)
		{
			if(form is null) throw new ArgumentNullException(nameof(form));
			return new Boardgame(
					-1,
					form.Game_Title,
					form.Game_Description,
					form.MinAge,
					form.MaxAge,
					form.MinPlayers,
					form.MaxPlayers,
					form.Duration,
					Guid.Empty //We will fill it in the BLL
				);
		}
	}
}
