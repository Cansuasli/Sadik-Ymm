using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Sadik_Ymm.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
  
            bundles.Add(new StyleBundle("~/yazarStyles").IncludeDirectory("~/Areas/Yazar/Contents","*.css"));

            bundles.Add(new ScriptBundle("~/yazarScripts").IncludeDirectory("~/Areas/Yazar/Scripts", "*.js"));

            bundles.Add(new ScriptBundle("~/stringToSlug").Include("~/Areas/Yazar/Scripts/plugins/stringToSlug.js"));


        }
        }
    }
