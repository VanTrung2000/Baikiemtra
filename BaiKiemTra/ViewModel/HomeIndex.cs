using BaiKiemTra.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTra.ViewModel
{
    public class HomeIndex
    {
        public Posts Posts { get; set; }
        public IEnumerable<Categories> Categories { set; get; }
        public IEnumerable<SelectListItem> CategoriesSelectList { set; get; }
        public IEnumerable<Tags> Tags { set; get; }
        public IEnumerable<SelectListItem> TagsSelectList { set; get; }
    }
}
