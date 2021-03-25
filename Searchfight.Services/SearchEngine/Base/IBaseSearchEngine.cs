using Searchfight.Models.SearchEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Services.SearchEngine.Base
{
    interface IBaseSearchEngine
    {
        Result GetCurrentResult();
        Result GetTopResult();
        void LoadResultNumber(string regexPattern, string splitSeparator = " ");
        void LoadResultTime(string regexPattern, string splitSeparator = " ");
        Task LoadHttpResponse(Uri uri);
    }
}
