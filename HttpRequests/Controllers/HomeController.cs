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


            // If form request type like'GET' we can get parametrs from QueryString
            string name = "", surname = "";            
            
               name = Request.QueryString["name"];
               surname = Request.QueryString["name"];


            rq.RequestInformation.Add(rqInfo);
            rq.SaveChanges();
            Write(rqInfo);
            ViewBag.Type = "GET";
            return View();
        }

        [HttpPost]       
        public ActionResult Index(string name, string surname)
        {
            //rinfo.Type = Request.HttpMethod;
            //rinfo.URL = Request.Url.ToString();
            //rinfo.Ip = Request.UserHostAddress; // ::1 is for localhost



            // data.RequestInformationId = 0;
            rqInfo.RequestInformationType = Request.HttpMethod;
            rqInfo.RequestInformationUrl = Request.Url.ToString();
            rqInfo.RequestInformationIp = Request.UserHostAddress;

            rq.RequestInformation.Add(rqInfo);
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
            ViewBag.Type = "POST";
            return View();
        }

        [HttpDelete]
        public ActionResult Index(string name, string surname, string smt)
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

            return View();
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