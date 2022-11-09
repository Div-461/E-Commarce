using ClothBazar.Services;
using ClothBazar.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class WidgetsController : Controller
    {
        // GET: Widgets
        public ActionResult Products(bool isLatestProduct, int? CategoryID = 0)
        {
            ProductWidgetViewModel model = new ProductWidgetViewModel();
            model.isLatestProduct = isLatestProduct;

            if (isLatestProduct)
            {
                model.Products = ProductsService.Instance.GetLatestProducts(4);
            }
            else if(CategoryID.HasValue && CategoryID.Value > 0)
            {
                model.Products = ProductsService.Instance.GetProductsByCategory(CategoryID.Value,4);
            }
            else
            {
                model.Products = ProductsService.Instance.GetProducts(1, 8);
            }
            return PartialView(model);
        }
    }
}