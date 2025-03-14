using ASP_MVC.Models.Library;
using BLL.Entities;

namespace ASP_MVC.Mappers
{
	internal static class LibraryMapper
	{
		/// <summary>
		/// Convert Data from GameCopyCreate form to BLL GameCopy
		/// </summary>
		/// <param name="form">GameCopyCreate</param>
		/// <returns>BLL GameCopy</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static GameCopy ToBLL(this GameCopyCreate form)
		{
			if (form is null) throw new ArgumentNullException(nameof(form));
			return new GameCopy(
				0,
				form.Game_Id,
				form.User_Id,
				form.State
			);
		}

		/// <summary>
		/// We send Data to GameCopyCreate  from BLL.User for Select field
		/// </summary>
		/// <param name="game"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static GameCopyCreate ToCreate(this GameCopy game)
		{
			if (game is null) throw new ArgumentNullException(nameof(game));
			return new GameCopyCreate()
			{
				Game_Id = game.Game_Id,
				User_Id = game.User_Id,
				State = game.State.ToString(),
			};
		}

	}
}

		