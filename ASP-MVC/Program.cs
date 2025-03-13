using Common.Repositories;

namespace ASP_MVC
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			// Personalized Services
				//User
				builder.Services.AddScoped<IUserRepository<DAL.Entities.User>,DAL.Services.UserService>();
				builder.Services.AddScoped<IUserRepository<BLL.Entities.User>,BLL.Services.UserService>();
			
				//Boardgame
				builder.Services.AddScoped<IBoardgameRepository<DAL.Entities.Boardgame>,DAL.Services.BoardgameService>();
				builder.Services.AddScoped<IBoardgameRepository<BLL.Entities.Boardgame>,BLL.Services.BoardgameService>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
