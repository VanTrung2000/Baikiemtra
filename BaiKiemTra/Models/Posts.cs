using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTra.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { set; get; }
        public string Content { set; get; }
        public int CategoryId { get; set; }
        public int TagId { get; set; }
        public Tags Tags { set; get; }
        public  Categories Categories { set; get; }
        public List<Pogtag> Pogtags { get; set; } = new List<Pogtag>();
    }
}
