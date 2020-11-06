using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTra.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Title { set; get; }
        public string Description { set; get; }
        public List<Pogtag> pogtags { set; get; }
        public List<Posts> posts { set; get; }
    }
}
