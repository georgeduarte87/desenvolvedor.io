using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("sobre-nos")]
        public ActionResult About()
        {
            return View();
        }

        [Route("institucional/entre-em-contato")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("content-result")]
        public ContentResult ContentResult()
        {
            return Content("Olá!");
        }

        [Route("downloads/meu-arquivo")]
        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/capa.png"));

            return File(foto, "image/png", "capa.png");
        }

        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }

        public JsonResult JsonResult()
        {
            return Json("teste:'Teste'", JsonRequestBehavior.AllowGet);
        }

        public RedirectResult RedirectResult()
        {
            return new RedirectResult("https://desenvolvedor.io");
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            //return RedirectToRoute(new
            //{
            //    controller = "Teste",
            //    action = "IndexTeste"
            //});

            return RedirectToAction("IndexTeste","Teste");
        }
    }
}