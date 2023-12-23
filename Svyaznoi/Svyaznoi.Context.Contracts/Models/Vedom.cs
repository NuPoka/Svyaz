using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svyaznoi.Context.Contracts.Models
{
    public class Vedom : BaseEntyty
    {
        public Guid TovarId { get; set; }
        
        public Guid PostavshikId { get; set; }

        public Guid PlatelshikId { get; set; }
    }
}
