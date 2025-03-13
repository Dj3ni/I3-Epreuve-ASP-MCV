using ASP_MVC.Handlers.ActionFilters;
using ASP_MVC.Handlers.Managers;
using ASP_MVC.Mappers;
using ASP_MVC.Models.Library;
using BLL.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace ASP_MVC.Controllers
{
	public class LibraryController : Controller
	{
		//Service injection
		private readonly SessionManager _sessionManager;
		private readonly ILibraryRepository<GameCopy> _libraryService;

		public LibraryController(SessionManager sessionManager, ILibraryRepository<GameCopy> libraryService)
		{
			_sessionManager = sessionManager;
			_libraryService = libraryService;
		}

		// GET: LibraryController
		public ActionResult Index()
		{
			return View();
		}

		// GET: LibraryController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: LibraryController/Create
		[ConnectionNeeded]
		public ActionResult Create()
		{
			GameCopyCreate model = new GameCopyCreate()
			{
				States = Enum.GetValues(typeof(StateEnum))
			.Cast<StateEnum>()
			.Select(e => new SelectListItem 
			{ 
				Value = e.ToString(), 
				Text = e.ToString()
			}).ToList()
			};
			return View(model);
		}

		// POST: LibraryController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		[ConnectionNeeded]
		public ActionResult Create(GameCopyCreate form)
		{
			try
			{
				//Check Enum not modified with inspector
				if (!Enum.IsDefined(typeof(StateEnum), form.State)) ModelState.AddModelError("State", "State chosen not valid");
				
				if (!ModelState.IsValid) throw new ArgumentException(nameof(form));

				ConnectedUser user = _sessionManager.ConnectedUser;
				form.User_Id = user.User_Id;

				int id = _libraryService.Insert(form.ToBLL());

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: LibraryController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: LibraryController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: LibraryController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: LibraryController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
