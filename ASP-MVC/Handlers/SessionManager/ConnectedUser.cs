﻿namespace ASP_MVC.Handlers.SessionManager
{
	public class ConnectedUser
	{
		public Guid User_Id { get; set; }
		public string Pseudo { get; set; }
		public string Email { get; set; }
		public DateTime ConnectedAt { get; set; }
	}
}
