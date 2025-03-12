using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Boardgame
	{
		public string Game_Title { get; set; }
		public string Game_Description { get; set; }

		public short MinAge {  get; set; }
		public short MaxAge { get; set; }
		public short MinPlayers { get; set; }
		public short MaxPlayers { get; set; }
		public int? Duration { get; set; }
		public Guid Registerer {  get; set; }
	}
}
