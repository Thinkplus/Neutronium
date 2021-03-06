﻿using System.ComponentModel;

namespace Tests.Infra.WebBrowserEngineTesterHelper.HtmlContext
{
    public enum TestContext 
    {
        [Description("javascript\\index.html")]
        Index,

        [Description("javascript\\generic_bind.html")]
        GenericBind,

        [Description("javascript\\simple.html")]
        Simple,

        [Description("javascript\\empty_with_js.html")]
        EmptyWithJs,

        [Description("javascript\\almost_empty.html")]
        AlmostEmpty,

        [Description("javascript\\index_promise.html")]
        IndexPromise,

        [Description("Navigation data\\index.html")]
        AnimatedNavigation,

        [Description("javascript\\navigation_1.html")]
        Navigation1,

        [Description("javascript\\navigation_2.html")]
        Navigation2,

        [Description("javascript/navigation_3.html")]
        Navigation3
    }
}
