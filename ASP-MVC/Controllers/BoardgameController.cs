using ASP_MVC.Handlers;
using ASP_MVC.Handlers.ActionFilters;
using ASP_MVC.Mappers;
using ASP_MVC.Models.Boardgame;
using BLL.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{
	public class BoardgameController : Controller
	{
		// Service injection
		private readonly IBoardgameRepository<Boardgame> _boardgameService;

		public BoardgameController(IBoardgameRepository<Boardgame> boardgameService)
		{
			_boardgameService = boardgameService;
		}

		// GET: BoardgameController
		public ActionResult Index()
		{
			IEnumerable<BoardgameListItem> model = _boardgameService.GetAll().Select(bll=>bll.ToListItem());
			return View(model);
		}

		// GET: BoardgameController/Details/5
		public ActionResult Details(int id)
		{
			BoardgameDetails model = _boardgameService.GetById(id).ToDetails();
			return View(model);
		}

		// GET: BoardgameController/Create
		[ConnectionNeeded]
		public ActionResult Create()
		{
			return View();
		}

		// POST: BoardgameController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		[ConnectionNeeded]
		public ActionResult Create(BoardgameCreate form)
		{
			try
			{
				//Custom validations
				ModelState.MinMaxValidation(form.MinAge,form.MaxAge, nameof(form.MinAge), nameof(form.MaxAge));
				ModelState.MinMaxValidation(form.MinPlayers, form.MaxPlayers, nameof(form.MinPlayers), nameof(form.MaxPlayers));
				//FormValidation
				if(!ModelState.IsValid) throw new ArgumentException(nameof(form));
				int id = _boardgameService.Insert(form.ToBLL());
				return RedirectToAction(nameof(Details), new {id});
			}
			catch
			{
				return View();
			}
		}

	}
}
