using Searchfight.Models.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Services.Base
{
    public abstract  class BaseWeb: IBaseWeb
    {
        protected Request request;
        protected Response response;
        public BaseWeb()
        {
        }

        public Response GetReponse()
        {
            throw new NotImplementedException();
        }

        public Request GetRequest()
        {
            return request;
        }
        public Response GetResponse()
        {
            return response;
        }
        public async Task LoadResponse(HttpWebRequest httpWebRequest)
        {
            using var response = await httpWebRequest.GetResponseAsync();
            using var responseStream = response.GetResponseStream();
            using var streamReader = new StreamReader(responseStream);
            this.response = new Response
            {
                Characters = await streamReader.ReadToEndAsync(),
                Encoding = streamReader.CurrentEncoding,
                Uri = httpWebRequest.RequestUri
            };
        }
    }
}
