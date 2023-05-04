using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SupplyWeb.Domain.Entities
{
    public class Outbound
    {
        public int Id { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }
        [Display(Name = "Data e Hora")]
        public DateTime Date { get; set; }
        [Display(Name = "Local")]
        public string Location { get; set; }
        public int ProductId { get; set; }
    }
}
