using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using AGRevitCommandSimple.Base;
using AGRevitCommandSimple.View;
using Autodesk.Revit.Attributes;
using AGRevitCommandSimple.ViewModels;

namespace AGRevitCommandSimple
{
    [Transaction(TransactionMode.Manual)]
    internal class Command : BaseExternalCommand
    {
        public override Result Execute()
        {
            MainWindowViewModel mainaWindowViewModel = new(_uiDoc);
            MainWindow mainWindow = new(mainaWindowViewModel);
            mainWindow.Show();

            return Result.Succeeded;
        }
    }
}