using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    internal class Book // DTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}
