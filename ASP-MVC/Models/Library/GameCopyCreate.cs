using System.ComponentModel;

namespace ASP_MVC.Models.Library
{
	public class GameCopyCreate
	{
		[DisplayName("Game")]
		public int Game_Id { get; set; } //Change with GameName
		public string State { get; set; }
	}
}
