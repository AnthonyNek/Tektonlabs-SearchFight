using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Models.SearchEngine
{
    public class Result
    {
        public long Number { get; set; } = 0L;
        public string Text { get; set; }
        public TimeSpan Time { get; set; }
    }
}
