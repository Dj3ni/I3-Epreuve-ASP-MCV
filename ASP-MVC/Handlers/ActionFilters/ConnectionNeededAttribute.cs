using ASP_MVC.Handlers.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ASP_MVC.Handlers.ActionFilters
{
	[AttributeUsage(AttributeTargets.Method)]
	public class ConnectionNeededAttribute : Attribute, IAuthorizationFilter
	{
		private string _action;
		private string _controller;
		private bool _getRouteValue;

		// Injecte TempData
		private readonly ITempDataDictionaryFactory _tempDataFactory;

		//Constructor
		public ConnectionNeededAttribute() : this("Login", "Auth")
		{
			//_tempDataFactory = tempDataFactory;
		}
		public ConnectionNeededAttribute(string action, string controller, bool getRouteValue = false)
		{
			_action = action;
			_controller = controller;
			_getRouteValue = getRouteValue;
		}

		//Implement Interface
		public void OnAuthorization(AuthorizationFilterContext context)
		{
			//Si user non connecté
			if (context.HttpContext.Session.GetString(nameof(SessionManager.ConnectedUser)) is null)
			{
				// Récupérer l'URL demandée avant redirection et la stocker dans la session
				string? returnUrl = context.HttpContext.Request.Path + context.HttpContext.Request.QueryString;
				context.HttpContext.Session.SetString("ReturnUrl", returnUrl);

				//_tempDataFactory.GetTempData(context.HttpContext)["RedirectMessage"] = "You need to be connected to view this page.";


				object? routeValue = null;
				//Si route à paramètres
				if (_getRouteValue)
				{
					routeValue = context.RouteData.Values;
				}
				context.Result = new RedirectToActionResult(_action, _controller, routeValue);
			}
		}
	}
}
