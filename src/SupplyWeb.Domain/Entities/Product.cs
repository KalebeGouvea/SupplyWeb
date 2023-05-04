using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Número de Registro")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Fabricante")]
        public string Manufacturer { get; set; }
        [Display(Name = "Tipo")]
        public string Type { get; set; }
        [Display(Name = "Descrição")]
        public string Description { get; set; }
    }
}
