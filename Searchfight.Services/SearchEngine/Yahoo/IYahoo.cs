using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Services.SearchEngine.Yahoo
{
    interface IYahoo
    {
        Task LoadResponseBySearchValue(string searchValue);
        Task LoadHttpResponseBySearchValue(string searchValue);
        void LoadResultNumber();
    }
}
