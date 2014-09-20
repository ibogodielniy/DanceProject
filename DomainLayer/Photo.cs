using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Photo
    {
        public int Id { get; set; }

        public Profile ProfileId { get; set; }

        public string Thumb { get; set; }

        public string Avatar { get; set; }

        public string BigSize { get; set; }
    }
}
