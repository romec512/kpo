using AppKit;
namespace Kpo4310_asadovrs.Main
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            Kpo4310_asadovrs.AppGlobalSettings.Initialize();
            NSApplication.Init();
            NSApplication.Main(args);
        }
    }
}
