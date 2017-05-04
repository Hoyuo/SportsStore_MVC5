using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductRepository repository;

		public ProductController(IProductRepository productRepository)
		{
			repository = productRepository;
		}

		public ViewResult List()
		{
			return View(repository.Products);
		}
	}
}