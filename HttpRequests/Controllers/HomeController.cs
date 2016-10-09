using HttpRequests.Context;
using HttpRequests.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace HttpRequests.Controllers
{
    //public class RequestInfo
    //{
    //    public string Type;
    //    public string Ip;
    //    public string URL;
    //}
    public class HomeController : Controller
    {
        //RequestInfo rinfo = new RequestInfo();
        public RequestContext rq = new RequestContext();
        RequestInformation rqInfo = new RequestInformation();
        MovieHouse mhInfo = new MovieHouse();

        public static void Write(RequestInformation requestInfo)
        {
            string reqInfo = "Type:" + requestInfo.RequestInformationType + "  " + "Ip:"  + requestInfo.RequestInformationIp + "  " + "Url:"  + requestInfo.RequestInformationUrl + ";";

            //System.IO.File.AppendAllText(@"D:\1\ApriorIT\HttpRequests\HttpRequests\Content\HttpRequests.txt", reqInfo + "\n");
             //System.IO.File.AppendAllText(Server.MapPath(@"~/Content/HttpRequests.txt"), reqInfo + "\n");
            System.IO.File.AppendAllText(HostingEnvironment.MapPath(@"~/Content/HttpRequests.txt"), reqInfo + "\n");
        }


        public ActionResult Index()
        {
            rqInfo.RequestInformationType = Request.HttpMethod;

            try
            {
                rqInfo.RequestInformationUrl = Request.UrlReferrer.ToString();
            }
            catch
            {
                rqInfo.RequestInformationUrl = "First application start";
            }

            rqInfo.RequestInformationIp = Request.UserHostAddress;
            // Write request info to DB
            rq.RequestInformation.Add(rqInfo);
            rq.SaveChanges();

            // If form request type like'GET' we can get parametrs from QueryString

            if(Request.QueryString["name"]!=null )
            {
                mhInfo.MovieHouseName = Request.QueryString["name"];
                mhInfo.MovieHouseTelephone = Request.QueryString["telephone"];
                mhInfo.MovieHouseAdress = Request.QueryString["adress"];
                mhInfo.MovieHouseId = 0;

                // Write movie house info to DB
                rq.MovieHouses.Add(mhInfo);
                rq.SaveChanges();
                ViewBag.Additional = "with new one";
            }
            

            

            // Write request info to file
            Write(rqInfo);

            ViewBag.Type = "GET method"; 
            ViewBag.Response = "home page and list of movie houses ";
           // ViewBag.Additional = "with new one";
            return View(rq.MovieHouses.ToList());
       
        }

        [HttpPost]       
        public ActionResult Index(string name, string telephone, string adress)
        {
            
            // data.RequestInformationId = 0;
            rqInfo.RequestInformationType = Request.HttpMethod;
            rqInfo.RequestInformationUrl = Request.Url.ToString();
            rqInfo.RequestInformationIp = Request.UserHostAddress;

            rq.RequestInformation.Add(rqInfo);
            rq.SaveChanges();


            mhInfo.MovieHouseName = name;
            mhInfo.MovieHouseId = 0;
            mhInfo.MovieHouseTelephone = telephone;
            mhInfo.MovieHouseAdress = adress;

            
                rq.MovieHouses.Add(mhInfo);
                rq.SaveChanges();
               

            Write(rqInfo);


            //The HTTP_X_FORWARDED_FOR header gets the IP address behind proxy servers.
            //string SourceIP = String.IsNullOrEmpty(Request.ServerVariables["HTTP_X_FORWARDED_FOR"]) ? Request.ServerVariables["REMOTE_ADDR"] : Request.ServerVariables["HTTP_X_FORWARDED_FOR"].Split(',')[0];

            //if we do not know count of parameters

            //string[] keys = Request.Form.AllKeys;
            //for (int i = 0; i < keys.Length; i++)
            //{
            // Response.Write(keys[i] + ": " + Request.Form[keys[i]] + "<br>");
            //}

            ViewBag.Type = "POST method";
            ViewBag.Response = "home page and list of movie houses with new one ";
            return View(rq.MovieHouses.ToList());
        }

        [HttpDelete]
        public JsonResult Index(int id)
        {
            //rinfo.Type = Request.HttpMethod;
            //rinfo.URL = Request.Url.ToString();
            //rinfo.Ip = Request.UserHostAddress; // ::1 is for localhost

            //The HTTP_X_FORWARDED_FOR header gets the IP address behind proxy servers.
            //string SourceIP = String.IsNullOrEmpty(Request.ServerVariables["HTTP_X_FORWARDED_FOR"]) ? Request.ServerVariables["REMOTE_ADDR"] : Request.ServerVariables["HTTP_X_FORWARDED_FOR"].Split(',')[0];

            //if we do not know count of parameters

            //string[] keys = Request.Form.AllKeys;
            //for (int i = 0; i < keys.Length; i++)
            //{
            // Response.Write(keys[i] + ": " + Request.Form[keys[i]] + "<br>");
            //}

            return Json("Response from Delete");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
			string filename = HostingEnvironment.MapPath(@"~/Content/HttpRequests.txt");
			string contentType = MimeMapping.GetMimeMapping(filename); ;
            string downLoadName = null;
            return File(filename,contentType, downLoadName);
        }
    }
}