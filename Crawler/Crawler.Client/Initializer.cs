﻿using System.Web.Mvc;
using System.Web.Routing;
using Crawler.Client.Configurations;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Data;

namespace Crawler.Client
{
    public class Initializer
    {
        public static void Start()
        {
            Bootstrapper.Initialized += Bootstrapper_Initialized;
        }

        private static void Bootstrapper_Initialized(object sender, ExecutedEventArgs e)
        {
            if (e.CommandName == "Bootstrapped")
            {
                CrawlerConfig.RegisterCrawler(GlobalFilters.Filters, RouteTable.Routes);
            }
        } 
    }
}