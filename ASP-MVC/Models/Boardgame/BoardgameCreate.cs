using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models.Boardgame
{
	public class BoardgameCreate
	{
		[DisplayName("Title: ")]
		[Required(ErrorMessage ="A game without title? No way!")]
		public string Game_Title { get; set; }

		[DisplayName("Description")]
		[Required(ErrorMessage = "Invite people to play this game please, write something about it!")]
		public string Game_Description { get; set; }

		[DisplayName("Start playing : ")]
		[Required(ErrorMessage = "")]
		public int MinAge { get; set; }


		[DisplayName("Over that you'r too old to play this: ")]
		[Required(ErrorMessage ="Maximum age was asked by the PM and it's compulsory, sorry")]
		public int MaxAge { get; set; }

		[DisplayName("Minimum friends around the table: ")]
		[Required(ErrorMessage ="How can you skip this? Minimum players is compulsory!")]
		public int MinPlayers { get; set; }

		[DisplayName("Maximum players: ")]
		[Required(ErrorMessage ="We know, it's hard to set a player limit but you have to.")]
		public int MaxPlayers { get; set; }

		[DisplayName("Fun part duration, without rules explanation: ")]
		public int? Duration { get; set; }

	}
}
