using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestiónCRUDNorthwind
{
    public class _Supplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }

    }


    public class SupplierValid : AbstractValidator<_Supplier>
    {
        public SupplierValid()
        {
            RuleFor(x => x.CompanyName).NotEmpty();
            RuleFor(x => x.ContactName).NotEmpty();
            RuleFor(x => x.ContactTitle).NotEmpty();
            RuleFor(x => x.Address).Length(20, 250);
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.Region).NotEmpty();
            RuleFor(x => x.PostalCode).NotEmpty().MaximumLength(10);
            RuleFor(x => x.Country).NotEmpty();
            RuleFor(x => x.Phone).NotEmpty().MaximumLength(24);
            RuleFor(x => x.Fax).MaximumLength(24);
            // Regla personalizada para HomePage (ntext)
            RuleFor(x => x.HomePage).Custom((value, context) =>
            {
                // Implementa tu lógica de validación personalizada aquí
                // Por ejemplo, verifica si el valor cumple con ciertas condiciones.
                // Si no, agrega un mensaje de error al contexto.
            });
        }
    }

}
