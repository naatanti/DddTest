using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Web_App.Controllers
{
    public class EnviarArquivoXMLController : Controller
    {
        // GET: EnviarArquivoXML
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Enviar(HttpPostedFileBase arquivo)
        {
            XmlDocument xml = new XmlDocument();

            return View();
        }
    }
}