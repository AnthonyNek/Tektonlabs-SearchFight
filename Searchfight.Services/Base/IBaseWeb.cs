using Searchfight.Models.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Services.Base
{
    interface IBaseWeb
    {
        Request GetRequest();
        Response GetResponse();
        Task LoadResponse(HttpWebRequest httpWebRequest);
    }
}
