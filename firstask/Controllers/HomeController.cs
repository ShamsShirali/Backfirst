using Microsoft.AspNetCore.Mvc;

namespace firstask.Controllers
{
    public class HomeController:Controller
    {
        //public JsonResult Index()
        //{
        //    JsonResult jsonResult = new JsonResult("Salam");
        //    jsonResult.StatusCode = 505;

        //    return jsonResult;
        //}

        //public ContentResult Index()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "P138 Salam";
        //    result.ContentType= "test";
        //    return result;
        //}

        public ViewResult Index()
        {
            ViewResult viewResult= new ViewResult();
            viewResult.ViewName = "test";

            return viewResult;
        }
    }
}
