using RadioClub.radioclub.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadioClub.Models
{
    public class MemberViewModel
    {
        [Key]
        public int member_id { get; set; }
        public string membership_no { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string persent_merital_status { get; set; }
        public string marriage_date { get; set; }
        public string nationality { get; set; }
        public string occupation { get; set; }
        public Nullable<System.DateTime> divorce_date { get; set; }
        public string pancard { get; set; }
        public string aadharcard { get; set; }
        public string spouse_full_name { get; set; }
        public Nullable<System.DateTime> spouse_dob { get; set; }
        public string spouse_nationality { get; set; }
        public string spouse_occupation { get; set; }
        public string spouse_pancard { get; set; }
        public string spouse_aadharcard { get; set; }
        public string residential_address { get; set; }
        public string residential_pincode { get; set; }
        public string company_name { get; set; }
        public string business_type { get; set; }
        public string position_held { get; set; }
        public string office_address { get; set; }
        public string office_pincode { get; set; }
        public string office_telep { get; set; }
        public string residential_tele { get; set; }
        public string mobile_no { get; set; }
        public string fax_no { get; set; }
        public string email_id { get; set; }
        public Nullable<bool> communi_by_email { get; set; }
        public Nullable<bool> communi_by_sms { get; set; }

        public string device_info { get; set; }
        public string ipaddress { get; set; }
        public byte[] member_image { get; set; }
        public byte[] spouse_image { get; set; }
        public byte[] marriage_certi_img { get; set; }
        public byte[] member_pan_image { get; set; }
        public byte[] spouse_pan_img { get; set; }
        public byte[] member_aadhar_img { get; set; }
        public byte[] spouse_aadhar_img { get; set; }
        public byte[] member_passport_img { get; set; }
        public byte[] spouse_passport_img { get; set; }
        public System.DateTime record_date { get; set; }
        public int data_processed { get; set; }
        public string processed_by { get; set; }
        public byte[] member_sign { get; set; }
        public byte[] spouse_sign { get; set; }
        public Nullable<System.DateTime> processed_on { get; set; }
        public byte[] divorce_certi_image { get; set; }

        [ForeignKey("member_id")]
        //public virtual ICollection<child_info> child_info { get; set; }
        public virtual ICollection<child_info> child_info { get; set; }


        public List<MemberViewModel> MemberViewModelList { get; set; }

        //public MemberViewModel()
        //{
            
        //}

        public MemberViewModel()
        {
            child_info = new HashSet<child_info>();
        }
    }

    public enum Marital_Status
    {
        Signle,
        Married, 
        Divorcee
    }

    public enum Gender
    {
        Male,
        Female,
        Transgender
    }
}