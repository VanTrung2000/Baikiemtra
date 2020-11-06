using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTra.Models
{
    public class Categories
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public List<Posts> Posts { get; set; }
    }
}
