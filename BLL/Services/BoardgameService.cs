using BLL.Entities;
using BLL.Mappers;
using Common.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
	public class BoardgameService : IBoardgameRepository<Boardgame>
	{
		// Service injection
		private readonly IBoardgameRepository<DAL.Entities.Boardgame> _boardgameService;

		public BoardgameService(IBoardgameRepository<DAL.Entities.Boardgame> boardgameService)
		{
			_boardgameService = boardgameService;
		}

		//Methods
		public IEnumerable<Boardgame> GetAll()
		{
			return _boardgameService.GetAll().Select(dal=>dal.ToBLL());
		}

		public Boardgame GetById(int id)
		{
			return _boardgameService.GetById(id).ToBLL();
		}

		public int Insert(Boardgame game)
		{
			return _boardgameService.Insert(game.ToDAL());
		}
	}
}
