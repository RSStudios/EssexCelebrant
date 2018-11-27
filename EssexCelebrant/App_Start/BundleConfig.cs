using System.Web.Optimization;

namespace EssexCelebrant
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Scripts/3rdParty/jQuery/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/Scripts/3rdParty/modernizr-*"));

            // This is who the HTML template is from
            bundles.Add(new ScriptBundle("~/bundles/Introspect")
                .Include("~/Content/Scripts/3rdParty/Introspect/skel.min.js")
                  //.Include("~/Content/Scripts/3rdParty/Introspect/util.js")
                  .Include("~/Content/Scripts/3rdParty/Introspect/util.js"));
                //.Include("~/Content/Scripts/3rdParty/Introspect/main.js"));

            bundles.Add(new StyleBundle("~/Content/the-css")
                .Include("~/Content/CSS/main.css")
                .Include("~/Content/CSS/EssexCelebrant.css"));

            bundles.Add(new StyleBundle("~/Content/minified-css")
               .Include("~/Content/CSS/main.min.css")
               .Include("~/Content/CSS/EssexCelebrant.min.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
