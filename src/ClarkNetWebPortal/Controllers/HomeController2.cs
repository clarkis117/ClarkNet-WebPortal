using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClarkNetWebPortal.ViewModels;

namespace ClarkNetWebPortal.Controllers
{
	public class HomeController2 : Controller
	{
		public async Task<IActionResult> Index()
		{
			var viewModel = new HomeViewModel();

			await viewModel.Initialize();

			return View(viewModel);
		}

		public IActionResult Error()
		{
			return View();
		}

		public IActionResult Aurelia()
		{
			return View();
		}
	}
}
