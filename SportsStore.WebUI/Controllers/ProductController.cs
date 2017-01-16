using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Repository;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController()
        {
            this.repository = new ProductRepository();
        }

        public ViewResult List(int page = 1)
        {
            return View(repository.Products
                        .OrderBy(p => p.ProductID)
                        .Skip((page -1) * PageSize)
                        .Take(PageSize));
        }
    }
}