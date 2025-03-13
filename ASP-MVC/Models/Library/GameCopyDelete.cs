using BLL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Library
{
	public class GameCopyDelete
	{
		[ScaffoldColumn(false)]
		public int Game_Copy_Id { get; set; }

		[DisplayName("Game:")]
		public int Game_Id { get; set; } //Change with GameName

		[ScaffoldColumn(false)]
		public Guid User_Id { get; set; }

		[DisplayName("State of the game:")]
		public StateEnum State { get; set; }
	}
}
