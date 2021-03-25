using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Services.SearchEngine.Bing
{
    interface IBing
    {
        Task LoadResponseBySearchValue(string searchValue);
        Task LoadHttpResponseBySearchValue(string searchValue);
        void LoadResultNumber();
    }
}
