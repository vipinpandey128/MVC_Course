using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVCourse.Core
{
    public class TaskDocument : BaseEntity
    {
        public string? DocumentName { get; set; }
        public string? DocumentPath { get; set; }
    }
}
