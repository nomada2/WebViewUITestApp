﻿using NUnit.Framework;
using Xamarin.UITest;

namespace WebViewUITestApp.UITest
{
	[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

		[Test]
		public void ReplTest()
		{
			app.Repl();
		}

        [Test]
        public void ViewXamarinWebsite()
        {
			app.Tap(x => x.Css("SPAN.menu"));
			app.Screenshot("Tapped on view with class: Xamarin_Forms_Platform_iOS_WebViewRenderer");
			app.Tap(x => x.Css("A").Index(2));
			app.Screenshot("Tapped on view with class: Xamarin_Forms_Platform_iOS_WebViewRenderer");
			app.Tap(x => x.Css("A.action-button.blue.solid"));
			app.Screenshot("Tapped on view with class: Xamarin_Forms_Platform_iOS_WebViewRenderer");
		}
	}
}
