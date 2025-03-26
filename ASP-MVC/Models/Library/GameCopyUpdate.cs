using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BLL.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP_MVC.Models.Library
{
	public class GameCopyUpdate
	{
		[ScaffoldColumn(false)]
		public int Game_Copy_Id { get; set; }
				
		public int Game_Id { get; set; } //Change with GameName

		[DisplayName("Game")]
		public string Game_Title { get; set; }

		[ScaffoldColumn(false)]
		public Guid User_Id { get; set; }

		[DisplayName("Select the state of your game:'New', 'Incomplete', 'Damaged'")]
		[Required(ErrorMessage = "You have to inform the state of your game")]
		public string State { get; set; } //User Choice

		public List<SelectListItem> States { get; set; }
	}
}
