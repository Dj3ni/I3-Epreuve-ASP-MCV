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
	public class UserService : IUserRepository<User>
	{
		//Service injection
		private readonly IUserRepository<DAL.Entities.User> _userService;
		private readonly ILibraryRepository<GameCopy> _libraryService;

		public UserService(IUserRepository<DAL.Entities.User> userService, ILibraryRepository<GameCopy> libraryService)
		{
			_userService = userService;
			_libraryService = libraryService;
		}

		//Methods

		public IEnumerable<User> GetAll()
		{
			return _userService.GetAll().Select(dal=>dal.ToBll());
		}

		public User GetById(Guid id)
		{
			User user = _userService.GetById(id).ToBll();
			IEnumerable<GameCopy> library = _libraryService.GetByUserId(id);
			user.AddGameCopies(library);

			return user;
		}

		public Guid Insert(User user)
		{
			return _userService.Insert(user.ToDAL());
		}

		public void Update(Guid id, User user)
		{
			_userService.Update(id, user.ToDAL());
		}

		public Guid CheckPassword(string email, string password)
		{
			return _userService.CheckPassword(email, password);
		}
	}
}
