using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTra.Models
{
    public class Pogtag
    {
        public int PostId { get; set; }
        public Posts Posts { get; set; }

        public int TagId { get; set; }
        public Tags Tags { get; set; }
    }
}
