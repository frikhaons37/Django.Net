using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using djaginet.Models;
using System.Collections.Generic;

namespace djaginet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;
        private string baseUrl = "https://onsfrikha1.pythonanywhere.com/";

        public HomeController(ILogger<HomeController> logger, HttpClient httpClient)
        {

            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            List<Categorie> categories = await _httpClient.GetFromJsonAsync<List<Categorie>>($"{baseUrl}magasin/api/category")
                                         ?? new();
            List<Product> products = await _httpClient.GetFromJsonAsync<List<Product>>($"{baseUrl}magasin/api/produits")
                                       ?? new();

            List<ProductViewModel> productViews = new();

            foreach (var product in products)
            {
                ProductViewModel productViewModel = new ProductViewModel()
                {
                    Id = product.Id,
                    Description = product.Description,
                    Libelle = product.Libelle,
                    Prix = product.Prix,
                    ImagePath = $"{baseUrl}{product.ImagePath}",
                    Categorie = categories.Where(e=>e.Id == product.CategorieId).FirstOrDefault() ?? new()
                };
                productViews.Add(productViewModel);
            }
            return View(productViews);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}