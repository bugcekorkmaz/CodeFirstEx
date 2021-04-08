using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEx.Models.Entity
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(Order = 2)] //Db'de deki sırasını ayarlar
        [MaxLength(250)]
        public string FirstName { get; set; }

        [Column(Order = 3)] //Db'de deki sırasını ayarlar
        [MaxLength(250)]
        public string LastName { get; set; }


        [Column(Order = 4)] //Db'de deki sırasını ayarlar
        [MaxLength(250)]
        public string Email { get; set; }


        [Column(Order = 5)] //Db'de deki sırasını ayarlar
        [MaxLength(250)]
        public string Mobile { get; set; }


        [Column(Order = 6)] //Db'de deki sırasını ayarlar
        [MaxLength(250)]
        public string Address { get; set; }


        [Column(Order = 7)] //Db'de deki sırasını ayarlar
        [MaxLength(250)]
        public string Department { get; set; }

        public bool Active { get; set; }
        public bool Deleted { get; set; }

    }
}
