using MVCValidationTekrar_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCValidationTekrar_0.ViewModels
{
    public class CategoryVM
    {
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}