using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{

    public partial class Employees
    {
        
        public Employees()
        {
            Employees1 = new HashSet<Employees>();
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "The Last Name is required")]
        [Display(Name ="Last Name")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage ="The First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(10)]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [StringLength(25)]
        [Display(Name = "Title of Courtesy")]
        public string TitleOfCourtesy { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? HireDate { get; set; }

        [Display(Name = "Address")]
        [StringLength(60)]
        public string Address { get; set; }

        [Display(Name = "City")]
        [StringLength(15)]
        public string City { get; set; }

        [Display(Name = "Region")]
        [StringLength(15)]
        public string Region { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        [StringLength(15)]
        public string Country { get; set; }

        [Display(Name = "Home Phone")]
        [StringLength(24)]
        public string HomePhone { get; set; }

        [Display(Name = "Extension")]
        [StringLength(4)]
        public string Extension { get; set; }

        [Display(Name = "Photo")]
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [Display(Name = "Notas")]
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Display(Name = "Reports")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int? ReportsTo { get; set; }

        [Display(Name = "Photo Path")]
        [StringLength(255)]
        public string PhotoPath { get; set; }
        
        public virtual ICollection<Employees> Employees1 { get; set; }

        public virtual Employees Employees2 { get; set; }
        
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
