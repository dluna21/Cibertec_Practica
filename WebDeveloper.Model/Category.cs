using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Category
    {
        
        public Category()
        {
            //Products = new HashSet<Products>();
        }

        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="The Category Name is Required")]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [Display(Name ="Description")]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Display(Name = "Picture")]
        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }
        
        public virtual ICollection<Products> Products { get; set; }
    }
}
