using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebasDivWithName.Models;

namespace PruebasDivWithName.Controllers
{
    public class DefaultController : Controller
    {
        //Se crea un objeto de una clase cualquiera, este caso de tipo persona
        persona persona = new persona()
        {
            nombre = "Dawin"
        };
        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetData()
        {
            //Se envia el objeto convertido a Json
            return Json(persona) ;
        }
    }
}