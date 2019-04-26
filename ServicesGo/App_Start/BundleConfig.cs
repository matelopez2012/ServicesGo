using System.Web;
using System.Web.Optimization;

namespace ServicesGo
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/vendor/jquery-3.2.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/vendor/bootstrap-4.1/popper.min.js",
                      "~/vendor/bootstrap-4.1/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/vector").Include(
                      "~/vendor/slick/slick.min.js",
                      "~/vendor/wow/wow.min.js",
                      "~/vendor/animsition/animsition.min.js",
                      "~/vendor/bootstrap-progressbar/bootstrap-progressbar.min.js",
                      "~/vendor/counter-up/jquery.waypoints.min.js",
                      "~/vendor/counter-up/jquery.counterup.min.js",
                      "~/vendor/circle-progress/circle-progress.min.js",
                      "~/vendor/perfect-scrollbar/perfect-scrollbar.js",
                      "~/vendor/chartjs/Chart.bundle.min.js",
                      "~/vendor/select2/select2.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Vendor/css").Include(
                      "~/vendor/font-awesome-4.7/css/font-awesome.min.css",
                      "~/vendor/font-awesome-5/css/fontawesome-all.min.css",
                      "~/vendor/mdi-font/css/material-design-iconic-font.min.css",
                      "~/vendor/bootstrap-4.1/bootstrap.min.css",
                      "~/vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css",
                      "~/vendor/wow/animate.css",
                      "~/vendor/css-hamburgers/hamburgers.min.css",
                      "~/vendor/slick/slick.css",
                      "~/vendor/select2/select2.min.css",
                      "~/vendor/perfect-scrollbar/perfect-scrollbar.css",
                      "~/vendor/wow/animate.css",
                      "~/vendor/animsition/animsition.min.css"));

            bundles.Add(new StyleBundle("~/css").Include(
                "~/css/font-face.css"));
        }
    }
}
