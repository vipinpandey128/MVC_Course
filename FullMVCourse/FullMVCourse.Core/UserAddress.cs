using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVCourse.Core
{
    public class UserAddress : BaseEntity
    {
        [MaxLength(200)]
        public string? Address { get; set; }
        [MaxLength(10)]
        public string? HomeNumber { get; set; }
        [MaxLength(30)]
        public string? LandMark { get; set; }
        [MaxLength(10)]
        public string? PinCode { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        [MaxLength(50)]
        public string? State { get; set; }
    }
}
