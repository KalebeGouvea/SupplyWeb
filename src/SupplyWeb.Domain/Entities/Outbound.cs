using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Domain.Entities
{
    public class Outbound
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int ProductId { get; set; }
    }
}
