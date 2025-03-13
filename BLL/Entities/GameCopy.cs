using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
	public enum StateEnum
	{
		New,
		Incomplete,
		Damaged
	};
	public class GameCopy
	{

		public int Game_Copy_Id { get; set; }
		public int Game_Id { get; set; }
		public Guid User_Id { get; set; }
		public StateEnum State { get; set; }

		public GameCopy(int game_Copy_Id, int game_Id, Guid user_Id, string state)
		{
			Game_Copy_Id = game_Copy_Id;
			Game_Id = game_Id;
			User_Id = user_Id;
			State = Enum.Parse<StateEnum>(state);
		}
	}
}
