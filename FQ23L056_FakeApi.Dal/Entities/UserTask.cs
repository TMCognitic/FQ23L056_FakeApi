using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FQ23L056_FakeApi.Dal.Entities
{
#nullable disable
    public class UserTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
    }
}
