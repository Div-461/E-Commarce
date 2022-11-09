using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothBazar.Web.ViewModels
{
    public class ProductWidgetViewModel
    {
        public List<Product> Products { get; set; }

        public bool isLatestProduct { get; set; }
    }
}