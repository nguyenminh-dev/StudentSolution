using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Student.Data.Entities
{
    [Table("SinhVien")]
    public class SinhVien
    {
        public int id { get; set; }
        public String name { get; set; }
        public String address { get; set; }
    }
}
