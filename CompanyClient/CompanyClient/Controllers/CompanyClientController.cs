using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyClient.Controllers
{
    public class CompanyClientController : Controller
    {
        //
        // GET: /CompanyClient/
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult GetPublicInformation(string submitButton)
        {
            CompanyService.CompanyPublicServiceClient client = new CompanyService.CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            return Content( client.GetPublicInformation());
        }
        public ContentResult GetConfidentialInformation(string submitButton)
        {
            CompanyService.CompanyConfidentialServiceClient client = new CompanyService.CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
            return Content(client.GetConfidentialInformation());
        }
	}
}