﻿using Xamarin.Forms;

namespace XamarinFormsSample
{
    static class Fonts
    {
        public static Font LargeTitle;
        public static Font Title;
        public static Font SmallTitle;
        public static Font Twitter;

        /// <summary>
        ///   Initialize the fonts for our application. The fonts used changes from
        ///   platform to platform.
        /// </summary>
        static Fonts()
        {
            Device.OnPlatform(() =>{
                                  LargeTitle = Font.OfSize("HelveticaNeue-UltraLight", 42);
                                  Title = Font.OfSize("HelveticaNeue-Light", 30);
                                  SmallTitle = Font.OfSize("HelveticaNeue-Light", 22);
                                  Twitter = Font.OfSize("HelveticaNeue-Light", NamedSize.Small);
                              }, () =>{
                                     LargeTitle = Font.SystemFontOfSize(42);
                                     Title = Font.SystemFontOfSize(30);
                                     SmallTitle = Font.SystemFontOfSize(18);
                                     Twitter = Font.SystemFontOfSize(14);
                                 }, () =>{
                                        LargeTitle = Font.SystemFontOfSize(60);
                                        Title = Font.SystemFontOfSize(46);
                                        SmallTitle = Font.SystemFontOfSize(30);
                                        Twitter = Font.SystemFontOfSize(18);
                                    }
                );
        }

        static int PlatformSize(int size)
        {
            return Device.OnPlatform(size, size, (int)(size * 1.3));
        }
    }
}
