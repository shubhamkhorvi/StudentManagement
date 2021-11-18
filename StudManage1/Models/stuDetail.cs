//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudManage1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class stuDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stuDetail()
        {
            this.eduDetails = new HashSet<eduDetail>();
            this.results = new HashSet<result>();
        }

        public int sid { get; set; }
        [Required(ErrorMessage = "please select your branch")]
        public Nullable<int> branchId { get; set; }
        [Required(ErrorMessage = "please enter your Rollnumber")]

        [Display(Name = "Roll Number")]
        [MaxLength(7)]
        [RegularExpression(@"DIT[0-9]{3}", ErrorMessage = "Please enter correct Roll Number")]
        [Remote("CheckUserNameExists", "reg", ErrorMessage = "Roll number already exists! Please enter your correct roll number")]

        public string rollNo { get; set; }
        [Required(ErrorMessage = "please enter your Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "please enter your age")]
        [Range(18, 20, ErrorMessage = "age must be between 18 to 20")]

        public Nullable<int> age { get; set; }
        [Required(ErrorMessage = "please enter your Address")]
        [MaxLength(25)]
        public string address { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [MaxLength(50)]
        [RegularExpression(@"^([+]\d{2}[ ])?\d{10}$", ErrorMessage = "Please enter correct phonenumber")]

        public string phoneNo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
                     ApplyFormatInEditMode = true)]

        public Nullable<System.DateTime> DOB { get; set; }
        [Required(ErrorMessage = "Please select your Gender")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Please select your City Name")]
        public string city { get; set; }
        public Nullable<int> cid { get; set; }

        public virtual branch branch { get; set; }
        public virtual company company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eduDetail> eduDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<result> results { get; set; }

    }
}