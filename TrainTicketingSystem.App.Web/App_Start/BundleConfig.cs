using System.Web.Optimization;

namespace TrainTicketingSystem.App.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Scripts bundles
            ScriptBundle scripts = new ScriptBundle("~/ScriptsBundle");
            scripts.Include("~/Scripts/jquery-3.3.1.js");
            scripts.Include("~/Scripts/bootstrap.js");
            bundles.Add(scripts);

            //CSS bundles
            StyleBundle styles = new StyleBundle("~/StylesBundle");
            styles.Include("~/Styles/bootstrap.css");
            styles.Include("~/Styles/mystyles.css");
            bundles.Add(styles);

            StyleBundle loginRegisterStyles = new StyleBundle("~/LoginRegisterStylesBundle");
            loginRegisterStyles.Include("~/Styles/bootstrap.css");
            loginRegisterStyles.Include("~/Styles/mystyles.css");
            bundles.Add(loginRegisterStyles);

            //< link rel = "stylesheet" href = "https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic" >
        }
    }
}