using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchfight.Services
{
    public class Service
    {
        public static class WebRequest
        {
          //   public static string USER_AGENT = GetFromConfiguration("UserAgent");//Cuando se desarrolla o deploya descomentar

           public const string USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36";//Para pruebas unitarias
           //   public static int TIMEOUT = Convert.ToInt32(GetFromConfiguration("Timeout"));//Cuando se desarrolla o deploya descomentar
            public const int TIMEOUT = 10000;//Para pruebas
            public static class Api
            {
                //  public static string CONTENT_TYPE = GetFromConfiguration("ContentTypeApi");//Cuando se desarrolla o deploya descomentar
                public const string CONTENT_TYPE = "application/json";
            }

            public static class Default
            {
                // public static string CONTENT_TYPE = GetFromConfiguration("ContentTypeDefault");//Cuando se desarrolla o deploya descomentar
                public const string CONTENT_TYPE = "application/x-www-form-urlencoded";
            }
        }

        public static class Http
        {
            public static class Bing
            {
                public static class Response
                {
                    public static class ResultNumber
                    {
                        public const string REGEX_PATTERN = @"(?:<span)(?:[^>]*)(?:class=\""sb_count\"")(?:[^>]*)(?:>)(.*?)(?:</span>)";
                        public const string SPLIT_SEPARATOR = " ";
                    }
                }

                public static class Url
                {
                    public static class SearchEngine
                    {
                        //  public static string SEARCH = GetFromConfiguration("Bing.BaseUrl");//Cuando se desarrolla o deploya descomentar
                        public const string SEARCH = "https://www.bing.com/search";
                    }
                }
            }

            public static class Google
            {
                public static class Response
                {
                    public static class ResultNumber
                    {

                        public const string REGEX_PATTERN = @"(?:<div)(?:[^>]*)(?:id=\""resultStats\"")(?:[^>]*)(?:>)(.*?)(?:<nobr>)";

                        public const string SPLIT_SEPARATOR = " ";
                    }

                    public static class ResultTime
                    {
                        public const string REGEX_PATTERN = @"(?:<div)(?:[^>]*)(?:id=\""resultStats\"")(?:[^>]*)(?:>)(?:.*)(?:<nobr>)(.*?)(?:</nobr>)";
                        public const string SPLIT_SEPARATOR = " ";
                    }
                }

                public static class Url
                {
                    public static class SearchEngine
                    {
                        //   public static string SEARCH = GetFromConfiguration("Google.BaseUrl");//Cuando se desarrolla o deploya descomentar
                        public const string SEARCH = "https://www.google.com/search";
                    }
                }
            }

            public static class Yahoo
            {
                public static class Response
                {
                    public static class ResultNumber
                    {
                        public const string REGEX_PATTERN = @"(?:<div)(?:[^>]*)(?:class=\""compPagination\"")(?:.*?)(?:<span)(?:[^>]*)(?:>)(.*?)(?:</span>)";
                        public const string SPLIT_SEPARATOR = " ";
                    }
                }

                public static class Url
                {
                    public static class SearchEngine
                    {
                        // public static  string SEARCH = GetFromConfiguration("Yahoo.BaseUrl");//Cuando se desarrolla o deploya descomentar
                        public const string SEARCH = "https://search.yahoo.com/search";
                    }
                }
            }
        }
        private const string MISSING_CONFIGURATION = "There was an isue with the configuration file. (Missing Value: {Key})";

        public static string GetFromConfiguration(string key)
        {
            string configurationValue = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(configurationValue))
                throw new ConfigurationErrorsException(MISSING_CONFIGURATION.Replace("{Key}", key));

            return configurationValue;
        }
    }
}
