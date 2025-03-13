using BLL.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models.Library
{
	public class GameCopyCreate
	{
		[DisplayName("Game")]
		[Required]
		public int Game_Id { get; set; } //Change with GameName

		[DisplayName("State of the game:'New', 'Incomplete', 'Damaged'")]
		[Required(ErrorMessage = "You have to inform the state of your game")]
		public string State { get; set; } //User Choice

		public IEnumerable<SelectListItem> States { get; set; }

		public Guid User_Id { get; set; }
	}
}
