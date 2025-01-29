using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Helper
{
    public class PageResultSet<T> where T : class
    {
        public int PageSize { get; set; }
        public int ItemCount { get; set; }
        public int PageCount { get; set; }

        public IEnumerable<T> Items { get; set; }

    }
}
