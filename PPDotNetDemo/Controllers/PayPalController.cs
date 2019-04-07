using System.Collections.Generic;
using System.Web.Helpers;
using System.Web.Mvc;

namespace PPDotNetDemo.Controllers
{
	public class PayPalController : Controller
	{
		// GET: PP
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Success(string orderId, string givenName, string surName)
		{
			ViewBag.OrderId = orderId;
			ViewBag.GivenName = givenName;
			ViewBag.SurName = surName;
			return View("Success");
		}
	}
}