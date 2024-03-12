using Autodesk.Revit.UI;
using System.Drawing;
using System.Reflection;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AGRevitCommandSimple.App
{
    public class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            var ribbonPanel = application.GetRibbonPanels()
                .FirstOrDefault(f => f.Name.Equals("Command"))
                   ?? application.CreateRibbonPanel("Command");

            var CommandButton = new PushButtonData(
                nameof(Command),
                "Command",
                Assembly.GetExecutingAssembly().Location,
                typeof(Command).ToString());
            CommandButton.ToolTip = "Revit Simple Command";

            try
            {
                CommandButton.LargeImage = GetImageSourceByBitMapFromResource(Properties.Resources.myIcon, 32);
                CommandButton.Image = GetImageSourceByBitMapFromResource(Properties.Resources.myIcon, 16);
            }
            catch { }

            ribbonPanel.AddItem(CommandButton);

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        private ImageSource GetImageSourceByBitMapFromResource(Bitmap source, int size)
        {
            return Imaging.CreateBitmapSourceFromHBitmap(
                source.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromWidthAndHeight(size, size)
            );
        }
    }
}