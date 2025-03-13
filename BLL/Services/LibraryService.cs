using BLL.Entities;
using BLL.Mappers;
using Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
	public class LibraryService : ILibraryRepository<GameCopy>
	{
		//Service injection
		private readonly ILibraryRepository<DAL.Entities.GameCopy> _libraryService;

		public LibraryService(ILibraryRepository<DAL.Entities.GameCopy> libraryService)
		{
			_libraryService = libraryService;
		}

		//Methods

		//For Debug
		public IEnumerable<GameCopy> GetAll()
		{
			return _libraryService.GetAll().Select(dal => dal.ToBLL());
		}

		public IEnumerable<GameCopy> GetByGameId(int game_id)
		{
			return _libraryService.GetByGameId(game_id).Select(dal=>dal.ToBLL());
		}

		public GameCopy GetById(int id)
		{
			return _libraryService.GetById(id).ToBLL();
		}

		public IEnumerable<GameCopy> GetByUserId(Guid user_id)
		{
			return _libraryService.GetByUserId(user_id).Select(dal => dal.ToBLL());
		}

		public int Insert(GameCopy gameCopy)
		{
			return _libraryService.Insert(gameCopy.ToDAL());
		}

		public void Update(int id, GameCopy gameCopy)
		{
			_libraryService.Update(id, gameCopy.ToDAL());
		}

		public void Delete(int id)
		{
			_libraryService.Delete(id);
		}
	}
}
