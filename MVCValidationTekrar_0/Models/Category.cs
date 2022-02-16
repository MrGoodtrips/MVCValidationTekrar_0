﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCValidationTekrar_0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
    


        public int CategoryID { get; set; }

        [Required(ErrorMessage = "{0} girilmesi zorunludur")]
        [Display(Name = "Kategori ismi")]
        [MinLength(5, ErrorMessage = "{0} minimum {1} karakter alabilir")]
        [MaxLength(15, ErrorMessage = "{0} maksimum {1} karakter alabilir")]
        public string CategoryName { get; set; }

        [Display(Name = "Açıklama")]
        [MinLength(10, ErrorMessage = "{0} minimum {1} karakter alabilir")]
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<bool> Isdeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
