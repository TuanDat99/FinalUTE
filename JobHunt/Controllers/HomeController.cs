using JobHunt.BU.DTO;
using JobHunt.BU.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobHunt.Controllers
{
    public class HomeController : Controller
    {
        ProfessionManage ProfessionManage = new ProfessionManage();
        CityManage cityManage = new CityManage();
        RecruitJobManage recruitjobManage = new RecruitJobManage();
        NewManage newManage = new NewManage();
        SignUpNewsletterManage signupManage = new SignUpNewsletterManage();
        public ActionResult Index()
        {
            //Lấy ra danh sách tất cả danh mục công việc
            ViewBag.ListProfesstions = new SelectList(ProfessionManage.GetAllProfessions(), "ProfessionId", "PFName");

            //Lấy danh sách tỉnh
            ViewBag.ListCities = new SelectList(cityManage.GetAllCities(), "CityId", "CName");


            //Lấy danh sách recruit đăng job - nổi bật: type = 1;
            ViewBag.ListJobsHot = recruitjobManage.GetListRecruitJobsByType((int?)BU.Common.Enum.EnumTypeJob.Hot);

            //Lấy danh sách recruit đăng job - gần đây: status = 2;
            ViewBag.ListJobsRecent = recruitjobManage.GetListRecruitJobsByTime();



            //Lấy danh sách list categories of career
            ViewBag.Careers = new CareerManage().GetAllCareers();

            //Đếm số việc làm đã đăng -- typeChoose = 1;
            ViewBag.CountJobsPosted = recruitjobManage.Statistical(1);

           
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


        //Show list category
        public ActionResult ShowListCategories()
        {
            var model = new CareerManage().GetAllCareers();
            return View(model);
        }

        public ActionResult ShowDetailCategory(int? id)
        {
            return View();
        }

        //Register receive
        public JsonResult RegisterReceive(SignUpNewsletterDTO rrdto)
        {
            return Json(signupManage.Insert(rrdto), JsonRequestBehavior.AllowGet);
        }
    }
}