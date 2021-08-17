using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Student.Data.Entities
{
    [Table("Lop")]
    public class Lop
    {
        public int id { get; set; }
        public String name { get; set; }
        public int number_student { get; set; }
    }
}
