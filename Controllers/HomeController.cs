using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _20_02_2024Ev.Models;

namespace _20_02_2024Ev.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Contact()
    {
        ViewData["Name"]="Burak Tarakçılar";
        return View();
    }
    public IActionResult Numbers()
    {
      
    
        Random rnd = new Random();
        ViewBag.Numara = rnd.Next(1, 100);
    
    
        
        return View();
    }
  
    public IActionResult Lessons()
    {
       string [] lessonList =  { "Mobil Uygulamalar","Veri Tabanlı İçerik Yönetimi","Web Tabanlı İçerik Yönetimi","Oyun  programlama"};
       ViewBag.lessons=lessonList;
       
       
        

        return View();
    }
    

   
}
