using System;
using System.Collections.Generic;
using System.Text;

namespace SWF.CA.Data.Models
{
    public class InsuranceOption
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int MinSquareMeter { get; set; }
        public int MaxSquareMeter { get; set; }
    }
}
