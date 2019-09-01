using System;
using System.Collections.Generic;
using System.Text;
using static Finances.App.Helpers.Enum;

namespace Finances.App.Models
{
    public class Favored
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BelongToUserId { get; set; }
        public string TaxNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public Account Account { get; set; }
    }
}
