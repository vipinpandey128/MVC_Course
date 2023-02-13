using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVCourse.Core
{
    public class UserTask : BaseEntity
    {
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string? UserId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Priority { get; set; }
    }
}
