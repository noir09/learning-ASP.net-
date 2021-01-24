using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewWebApplication.Services;
using Microsoft.AspNetCore.Hosting; // для IWebHostEnvironment
using System.IO; // для Path.Combine
using Microsoft.AspNetCore.Http;

namespace NewWebApplication.Controllers
{
    public class HomeController : Controller
    {

      
        private readonly IWebHostEnvironment _appEnvironment;
        public HomeController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public IActionResult Convector(double C, string txt)
        {
            Validate validate = new Validate();
            Services.File save= new Services.File();
            string file_path = Path.Combine(_appEnvironment.ContentRootPath, "File/F.txt");
            string file_name = "F.txt";
            string file_type = "text/txt";
            string errors;
            errors = validate.Check(C);
            if (errors != null)
            {
                return Content(errors);
            }
            double f;
            //Цельсий х 1,8 + 32 = Фаренгейт 
            f = C * 1.8 + 32;
            if(txt==null)
            return Content($" {f} Фаренгейта");
            save.save($" {f} Фаренгейта");
            return PhysicalFile(file_path, file_type, file_name);


        }
        public IActionResult ItAcademy()
        {
            return Redirect("https://www.it-academy.by");
        }
        


    }
}
