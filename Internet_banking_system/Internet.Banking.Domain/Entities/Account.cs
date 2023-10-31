using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet.Banking.Domain.Entities
{
    public class Account: Entity<int>
    {
        public string TypeOfAccount { get; set; }
        public double Balance  { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public string AccountNumber { get; set; }

    }
}
