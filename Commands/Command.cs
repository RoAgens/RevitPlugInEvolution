using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using AGRevitCommandSimple.Base;
using AGRevitCommandSimple.View;
using Autodesk.Revit.Attributes;
using AGRevitCommandSimple.ViewModels;
using SimpleInjector;
using AGRevitCommandSimple.Models;

namespace AGRevitCommandSimple
{
    [Transaction(TransactionMode.Manual)]
    internal class Command : BaseExternalCommand
    {
        public override Result Execute()
        {
            Container contaner = new();

            contaner.RegisterInstance(_uiDoc);

            contaner.Register<SelectElementService>();
            contaner.Register<MainWindowViewModel>();
            contaner.Register<MainWindow>();

            MainWindow mainWindow = contaner.GetInstance<MainWindow>();
            mainWindow.Show();

            return Result.Succeeded;
        }
    }
}