using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage ="The Company Name is Required")]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [Display(Name ="Contact Name")]
        [StringLength(30,ErrorMessage = "The Max number Characters is 30")]
        public string ContactName { get; set; }

        [Display(Name = "Contact Title")]
        [StringLength(30, ErrorMessage = "The Max number Characters is 30")]
        public string ContactTitle { get; set; }

        [Display(Name = "Address")]
        [StringLength(60, ErrorMessage = "The Max number Characters is 60")]
        public string Address { get; set; }

        [Display(Name = "City")]
        [StringLength(15, ErrorMessage = "The Max number Characters is 15")]
        public string City { get; set; }

        [Display(Name = "Region")]
        [StringLength(15, ErrorMessage = "The Max number Characters is 15")]
        public string Region { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(10, ErrorMessage = "The Max number Characters is 10")]
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        [StringLength(15, ErrorMessage = "The Max number Characters is 15")]
        public string Country { get; set; }

        [Display(Name = "Phone")]
        [StringLength(24, ErrorMessage = "The Max number Characters is 24")]
        public string Phone { get; set; }

        [Display(Name = "Fax")]
        [StringLength(24, ErrorMessage = "The Max number Characters is 24")]
        public string Fax { get; set; }
        
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
