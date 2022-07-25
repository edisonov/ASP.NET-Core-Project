namespace Recepti.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Recepti.Data;
    using Recepti.Data.Common.Repositories;
    using Recepti.Data.Models;
    using Recepti.Services.Data;
    using Recepti.Web.ViewModels;
    using Recepti.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountService countsService;

        public HomeController(IGetCountService countsService)
        {
            this.countsService = countsService;
        }

        public IActionResult Index()
        {
            var viewModel = this.countsService.GetCount();

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
