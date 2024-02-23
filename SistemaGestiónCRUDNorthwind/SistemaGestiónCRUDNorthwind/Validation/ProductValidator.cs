using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestiónCRUDNorthwind
{
    public class _ProductValidator
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
    public class Product : AbstractValidator<_ProductValidator>
    {
        public Product()
        {


            RuleFor(p => p.ProductName).NotEmpty().WithMessage("El nombre del producto es obligatorio.");
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("El precio debe ser mayor que cero.");
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.UnitsOnOrder).NotEmpty();



        }
    }
}
