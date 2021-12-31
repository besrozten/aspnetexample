using stajdeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stajdeneme.ViewModel
{
    public class BasvuruViewModel
    {
        public List<tbl_basvuru> Tbl_Basvurus { get; set; } 
        public List<tbl_yetkinlik> Tbl_Yetkinliks { get; set; } 
    }
}