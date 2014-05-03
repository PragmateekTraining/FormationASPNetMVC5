using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using io = System.IO;

namespace FormationASPNetMVC5.Controllers
{
    public class ChuckNorrisFactsController : Controller
    {
        //
        // GET: /ChuckNorrisFacts/{language}
        public ActionResult Get(string language)
        {
            string basePath = Server.MapPath("~");

            if (language == null)
            {
                return Content(@"{ ""languages"": [ ""en"", ""fr"" ] }");
            }            

            string filePath = string.Format("{0}/Content/CNF_{1}.json", basePath, language);

            if (!io.File.Exists(filePath))
            {
                return Content("");
            }

            return Content(io.File.ReadAllText(filePath));
        }
	}
}