using System.Web.Optimization;

namespace webcv
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/Content/css")
                .Include("~/Content/assets/css/*.css"));

            bundles.Add(new ScriptBundle("~/bundles/webcvappscripts")
                .Include(
                    "~/Scripts/assets/js/main.js"));
        }
    }
}