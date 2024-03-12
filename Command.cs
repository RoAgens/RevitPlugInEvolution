using AGRevitCommandSimple.Base;
using AGRevitCommandSimple.View;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace AGRevitCommandSimple
{
    [Transaction(TransactionMode.Manual)]
    internal class Command : BaseExternalCommand
    {
        public override Result Execute()
        {
            MainWindow mainWindow = new(_doc);
            mainWindow.ShowDialog();

            return Result.Succeeded;
        }
    }
}