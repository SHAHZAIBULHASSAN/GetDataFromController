using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetDataFromController.Models;

namespace GetDataFromController.Controllers
{
    public class HomeController : Controller
    {
       
        [HttpGet]
        public JsonResult Index()
        {
            JsonResult result = new JsonResult();
         
            // Load Data.  
            string jsonData = @"[{
     'id': 1001,
    'imageUrl': 'https://hub.dummyapis.com/Image?text=MW&height=120&width=120',
    'firstName': 'Martha',
    'lastName': 'Wiza',
    'email': 'Martha.Wiza@dummyapis.com',
    'contactNumber': '4147893578',
    'age': 58,
    'dob': '02/12/1964',
    'salary': 1.0,
    'address': 'Address1'},{
    'id': 1002,
    'imageUrl': 'https://hub.dummyapis.com/Image?text=CS&height=120&width=120',
    'firstName': 'Carole',
    'lastName': 'Sambireddy',
    'email': 'Carole.Sambireddy@dummyapis.com',
    'contactNumber': '4797693235',
    'age': 32,
    'dob': '05/12/1990',
    'salary': 2.0,
    'address': 'Address2'
  }
        ]";
            //


                 // Filter data with input query parameters.  

                 // Prepare Ajax JSON Data Result.  
                 result = this.Json(JsonConvert.SerializeObject(jsonData), JsonRequestBehavior.AllowGet);
            // return result;
            // Return info.  
            return result;

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        




    }
}