using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace POneTest2.Models
{
    [Table("Drbobs")]
    public class Drbob
    {
        [Key]
        //Controlls state
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string StaffFullName { get; set; }
    }
}