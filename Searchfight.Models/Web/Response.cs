using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Models.Web
{
     public  class Response
    {
        public string Characters { get; set; }
        public Encoding Encoding { get; set; }
        public Uri Uri { get; set; }
    }
}
