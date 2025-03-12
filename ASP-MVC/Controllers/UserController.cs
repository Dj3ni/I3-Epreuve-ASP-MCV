using ASP_MVC.Mappers;
using ASP_MVC.Models.User;
using BLL.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
	public class UserController : Controller
	{
		//Services injection
		private readonly IUserRepository<User> _userService;

		public UserController(IUserRepository<User> userService)
		{
			_userService = userService;
		}


		// GET: UserController
		public ActionResult Index()
		{
			IEnumerable<UserListItem> model = _userService.GetAll().Select(bll=>bll.ToListItem());
			return View(model);
		}

		// GET: UserController/Details/5
		public ActionResult Details(Guid id)
		{
			UserDetails model = _userService.GetById(id).ToDetails();
			return View(model);
		}

		// GET: UserController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: UserController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(UserInsert form)
		{
			try
			{
				if (!ModelState.IsValid) throw new ArgumentException(nameof(form));
				Guid id = _userService.Insert(form.ToBLL());
				return RedirectToAction(nameof(Details), new {id});
			}
			catch
			{
				return View();
			}
		}

		// GET: UserController/Edit/5
		public ActionResult Edit(Guid id)
		{
			UserUpdate model = _userService.GetById(id).ToEdit();
			return View(model);
		}

		// POST: UserController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Guid id, UserUpdate form)
		{
			try
			{
				if(!ModelState.IsValid)throw new ArgumentException(nameof(form));
				_userService.Update(id, form.ToBLL());
				return RedirectToAction(nameof(Details), new {id});
			}
			catch
			{
				return View();
			}
		}

		// GET: UserController/Delete/5
		public ActionResult Unsubscribe(Guid id)
		{
			UserUnsubscribe model = _userService.GetById(id).ToUnsubscribe();
			return View(model);
		}

		// POST: UserController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Unsubscribe(Guid id, UserUnsubscribe form)
		{
			try
			{
				_userService.Update(id, form.ToBLL());
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
