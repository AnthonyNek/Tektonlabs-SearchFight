﻿using System;
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
            public static string USER_AGENT = GetFromConfiguration("UserAgent");


            public static int TIMEOUT = Convert.ToInt32(GetFromConfiguration("Timeout"));

            public static class Api
            {
                public static string CONTENT_TYPE = GetFromConfiguration("ContentTypeApi");
            }

            public static class Default
            {
                public static string CONTENT_TYPE = GetFromConfiguration("ContentTypeDefault");
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
                        public static string SEARCH = GetFromConfiguration("Bing.BaseUrl");
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
                        public static string SEARCH = GetFromConfiguration("Google.BaseUrl");
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
                        public static  string SEARCH = GetFromConfiguration("Yahoo.BaseUrl");
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
