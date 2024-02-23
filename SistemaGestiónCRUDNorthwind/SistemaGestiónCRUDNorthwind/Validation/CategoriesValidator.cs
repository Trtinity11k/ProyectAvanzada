using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaGestiónCRUDNorthwind
{
    public class _Categories
    {
        public string CategoryID { get; set; }

        public string CategoryName { get; set; }
        public string Description { get; set; } = null;

        public byte[] Picture { get; set; }
    }

  
      
    
    public class CategoriesValidator : AbstractValidator<_Categories>
    {
        public CategoriesValidator()
        {
            
            RuleFor(a => a.CategoryName).NotEmpty().MaximumLength(15);
            RuleFor(a => a.CategoryName).Matches(@"^[a-zA-Z\s]+$");
            //RuleFor(a => a.Description).MinimumLength(15).MaximumLength(100);



        }
    }

}
