// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Glimpse.Site.Controllers {
    public partial class HelpController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HelpController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HelpController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Plugin() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Plugin);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HelpController Actions { get { return MVC.Help; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Help";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string Plugin = "Plugin";
            public readonly string Configuration = "Configuration";
            public readonly string Setup = "Setup";
            public readonly string CreatingPlugins = "CreatingPlugins";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Configuration = "~/Views/Help/Configuration.cshtml";
            public readonly string CreatingPlugins = "~/Views/Help/CreatingPlugins.cshtml";
            public readonly string Index = "~/Views/Help/Index.cshtml";
            public readonly string Plugin = "~/Views/Help/Plugin.cshtml";
            public readonly string Setup = "~/Views/Help/Setup.cshtml";
            static readonly _Plugins s_Plugins = new _Plugins();
            public _Plugins Plugins { get { return s_Plugins; } }
            public partial class _Plugins{
                public readonly string Ajax = "~/Views/Help/Plugins/Ajax.cshtml";
                public readonly string Binding = "~/Views/Help/Plugins/Binding.cshtml";
                public readonly string Config = "~/Views/Help/Plugins/Config.cshtml";
                public readonly string Environment = "~/Views/Help/Plugins/Environment.cshtml";
                public readonly string Execution = "~/Views/Help/Plugins/Execution.cshtml";
                public readonly string Index = "~/Views/Help/Plugins/Index.cshtml";
                public readonly string Metadata = "~/Views/Help/Plugins/Metadata.cshtml";
                public readonly string Remote = "~/Views/Help/Plugins/Remote.cshtml";
                public readonly string Request = "~/Views/Help/Plugins/Request.cshtml";
                public readonly string Routes = "~/Views/Help/Plugins/Routes.cshtml";
                public readonly string Server = "~/Views/Help/Plugins/Server.cshtml";
                public readonly string Session = "~/Views/Help/Plugins/Session.cshtml";
                public readonly string Trace = "~/Views/Help/Plugins/Trace.cshtml";
                public readonly string Views = "~/Views/Help/Plugins/Views.cshtml";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_HelpController: Glimpse.Site.Controllers.HelpController {
        public T4MVC_HelpController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Plugin(string id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Plugin);
            callInfo.RouteValueDictionary.Add("id", id);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Configuration() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Configuration);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Setup() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Setup);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult CreatingPlugins() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.CreatingPlugins);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
