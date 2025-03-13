﻿using ASP_MVC.Mappers;
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
		public ActionResult Create()
		{
			return View();
		}

		// POST: BoardgameController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(BoardgameCreate form)
		{
			try
			{
				//Don't forget to add validators for age and players first
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
