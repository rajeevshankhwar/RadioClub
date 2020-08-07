using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using RadioClub.Models;
using RadioClub.radioclub.Entities;
using System.Data.Entity;
using System.Net;
using System.IO;
using System.Web.UI.WebControls;

namespace RadioClub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult _Details(int id)
        {
            MemberViewModel model = new MemberViewModel();
            radioclubEntities _entities = new radioclubEntities();
            var data = _entities.member_update.Where(x => x.member_id == id).FirstOrDefault();
            if (data != null)
            {
                model.member_id = data.member_id;
                model.membership_no = data.membership_no;
                model.first_name = data.first_name;
                model.middle_name = data.middle_name;
                model.last_name = data.last_name;
                model.dob = data.dob;
                model.persent_merital_status = data.persent_merital_status;
                model.marriage_date = data.marriage_date;
                model.nationality = data.nationality;
                model.occupation = data.occupation;
                model.divorce_date = data.divorce_date;
                model.pancard = data.pancard;
                model.aadharcard = data.aadharcard;
                model.spouse_full_name = data.spouse_full_name;
                model.spouse_dob = data.spouse_dob;
                model.spouse_nationality = data.spouse_nationality;
                model.spouse_occupation = data.spouse_occupation;
                model.spouse_pancard = data.spouse_pancard;
                model.spouse_aadharcard = data.spouse_aadharcard;
                model.residential_address = data.residential_address;
                model.residential_pincode = data.residential_pincode;
                model.company_name = data.company_name;
                model.business_type = data.business_type;
                model.position_held = data.position_held;
                model.office_address = data.office_address;
                model.office_pincode = data.office_pincode;
                model.office_telep = data.office_telep;
                model.residential_tele = data.residential_tele;
                model.mobile_no = data.mobile_no;
                model.fax_no = data.fax_no;
                model.email_id = data.email_id;
                model.communi_by_email = data.communi_by_email;
                model.device_info = data.device_info;
                model.ipaddress = data.ipaddress;
                model.member_image = data.member_image;
                model.spouse_image = data.spouse_image;
                model.marriage_certi_img = data.marriage_certi_img;
                model.member_pan_image = data.member_pan_image;
                model.spouse_pan_img = data.spouse_pan_img;
                model.member_aadhar_img = data.member_aadhar_img;
                model.spouse_aadhar_img = data.spouse_aadhar_img;
                model.member_passport_img = data.member_passport_img;
                model.spouse_passport_img = data.spouse_passport_img;
                model.spouse_passport_img = data.spouse_passport_img;
                model.spouse_passport_img = data.spouse_passport_img;
                //record_date = data.record_date;
                model.child_info = data.child_info;

            };
            return View(model);
        }
        public ActionResult _Create(string membershipno, string pan)
        {
            MemberViewModel model = new MemberViewModel();
            model.membership_no = membershipno;
            model.pancard = pan;
            return View(model);
        }

        // GET: Member/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member/Create
        [HttpPost]
        public ActionResult Create(MemberViewModel model)
        {
            try
            {
                //string hostName = Dns.GetHostName(); 
                //string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                string myIP = GetIPAddress();
                if (ModelState.IsValid)
                {
                    radioclubEntities _entities = new radioclubEntities();
                    member_update entititySetup = new member_update();

                    entititySetup.membership_no = model.membership_no;
                    entititySetup.first_name = model.first_name;
                    entititySetup.middle_name = model.middle_name;
                    entititySetup.last_name = model.last_name;
                    entititySetup.dob = model.dob;
                    entititySetup.persent_merital_status = model.persent_merital_status;
                    entititySetup.marriage_date = model.marriage_date;
                    entititySetup.nationality = model.nationality;
                    entititySetup.occupation = model.occupation;
                    entititySetup.divorce_date = model.divorce_date;
                    entititySetup.pancard = model.pancard;
                    entititySetup.aadharcard = model.aadharcard;
                    entititySetup.spouse_full_name = model.spouse_full_name;
                    entititySetup.spouse_dob = model.spouse_dob;
                    entititySetup.spouse_nationality = model.spouse_nationality;
                    entititySetup.spouse_occupation = model.spouse_occupation;
                    entititySetup.spouse_pancard = model.spouse_pancard;
                    entititySetup.spouse_aadharcard = model.spouse_aadharcard;
                    entititySetup.residential_address = model.residential_address;
                    entititySetup.residential_pincode = model.residential_pincode;
                    entititySetup.company_name = model.company_name;
                    entititySetup.business_type = model.business_type;
                    entititySetup.position_held = model.position_held;
                    entititySetup.office_address = model.office_address;
                    entititySetup.office_pincode = model.office_pincode;
                    entititySetup.office_telep = model.office_telep;
                    entititySetup.residential_tele = model.residential_tele;
                    entititySetup.mobile_no = model.mobile_no;
                    entititySetup.fax_no = model.fax_no;
                    entititySetup.email_id = model.email_id;
                    entititySetup.communi_by_email = model.communi_by_email;
                    entititySetup.device_info = model.device_info;
                    entititySetup.ipaddress = myIP;
                    entititySetup.member_image = model.member_image;
                    entititySetup.spouse_image = model.spouse_image;
                    entititySetup.marriage_certi_img = model.marriage_certi_img;
                    entititySetup.member_pan_image = model.member_pan_image;
                    entititySetup.spouse_pan_img = model.spouse_pan_img;
                    entititySetup.member_aadhar_img = model.member_aadhar_img;
                    entititySetup.spouse_aadhar_img = model.spouse_aadhar_img;
                    entititySetup.member_passport_img = model.member_passport_img;
                    entititySetup.spouse_passport_img = model.spouse_passport_img;
                    entititySetup.record_date = DateTime.Now;

                    entititySetup.member_sign = model.member_sign;
                    entititySetup.spouse_sign = model.spouse_sign;
                    entititySetup.divorce_certi_image = model.divorce_certi_image;

                    entititySetup.child_info = model.child_info;
                    _entities.Entry(entititySetup).State = EntityState.Added;
                    _entities.SaveChanges();
                    TempData["ResponseCssClass"] = "alert-success";
                    TempData["ResponseMessage"] = "Your request for updation of data is received.";
                    //return RedirectToAction("GetMemberInfo");
                    return RedirectToAction("GetMemberInfo", new
                    {
                        membership_no = model.membership_no,
                        pan_card = model.pancard
                    });

                }
                else
                {
                    return PartialView("_Create", model);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return PartialView("_Create", model);
            }


        }

        public ViewResult Add()
        {
            return View("_AddChild", new child_info());
        }
        static string GetIPAddress()
        {
            try
            {
                String address = "";
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    address = stream.ReadToEnd();
                }

                int first = address.IndexOf("Address: ") + 9;
                int last = address.LastIndexOf("</body>");
                address = address.Substring(first, last - first);
                return address;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public ActionResult GetMemberInfo(string membership_no, string pan_card)
        {

            MemberViewModel model = new MemberViewModel();
            member_info _model = new member_info();

            radioclubEntities _entities = new radioclubEntities();
            var data = _entities.member_info.Where(x => x.membership_no.ToLower() == membership_no.ToLower())
                .Where(x => x.pan_card.ToLower() == pan_card.ToLower()).FirstOrDefault();
            if (data != null)
            {
                model.MemberViewModelList = (from s in _entities.member_update
                                             where s.pancard == data.pan_card
                                             where s.membership_no == data.membership_no
                                             select new MemberViewModel
                                             {
                                                 member_id = s.member_id,
                                                 membership_no = s.membership_no,
                                                 first_name = s.first_name,
                                                 middle_name = s.middle_name,
                                                 last_name = s.last_name,
                                                 dob = s.dob,
                                                 persent_merital_status = s.persent_merital_status,
                                                 marriage_date = s.marriage_date,
                                                 nationality = s.nationality,
                                                 occupation = s.occupation,
                                                 divorce_date = s.divorce_date,
                                                 pancard = s.pancard,
                                                 aadharcard = s.aadharcard,
                                                 spouse_full_name = s.spouse_full_name,
                                                 spouse_dob = s.spouse_dob,
                                                 spouse_nationality = s.spouse_nationality,
                                                 spouse_occupation = s.spouse_occupation,
                                                 spouse_pancard = s.spouse_pancard,
                                                 spouse_aadharcard = s.spouse_aadharcard,
                                                 residential_address = s.residential_address,
                                                 residential_pincode = s.residential_pincode,
                                                 company_name = s.company_name,
                                                 business_type = s.business_type,
                                                 position_held = s.position_held,
                                                 office_address = s.office_address,
                                                 office_pincode = s.office_pincode,
                                                 office_telep = s.office_telep,
                                                 residential_tele = s.residential_tele,
                                                 mobile_no = s.mobile_no,
                                                 fax_no = s.fax_no,
                                                 email_id = s.email_id,
                                                 communi_by_email = s.communi_by_email,
                                                 device_info = s.device_info,
                                                 ipaddress = s.ipaddress,
                                                 member_image = s.member_image,
                                                 spouse_image = s.spouse_image,
                                                 marriage_certi_img = s.marriage_certi_img,
                                                 member_pan_image = s.member_pan_image,
                                                 spouse_pan_img = s.spouse_pan_img,
                                                 member_aadhar_img = s.member_aadhar_img,
                                                 spouse_aadhar_img = s.spouse_aadhar_img,
                                                 member_passport_img = s.member_passport_img,
                                                 spouse_passport_img = s.spouse_passport_img,
                                                 divorce_certi_image=s.divorce_certi_image,
                                                 record_date=s.record_date,
                                                 spouse_sign=s.spouse_sign,
                                                 member_sign=s.member_sign,
                                                 processed_by=s.processed_by,
                                                 data_processed=s.data_processed,
                                                 processed_on=s.processed_on,

                                                 child_info = s.child_info
                                             }).ToList();
                if (model.MemberViewModelList.Count > 0)
                {
                    return PartialView("_ListDetails", model);
                }
                else
                {
                    model.membership_no = data.membership_no;
                    model.pancard = data.pan_card;
                    _model.membership_no = data.membership_no;
                    _model.pan_card = data.pan_card;
                    return PartialView("_Create", model);
                }


            }
            else
            {
                TempData["cssClass"] = "alert-danger";
                TempData["UserMessage"] = "Your Membership Id or Pan Card is incorrect. If you don't remember contact admin.";
                return View("Index", _model);

            }

        }
    }
}