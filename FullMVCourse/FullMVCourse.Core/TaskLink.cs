using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVCourse.Core
{
    public class TaskLink : BaseEntity
    {
        public string? LinkName { get; set; }
        public string? LinkUrl { get; set; }
    }
}
