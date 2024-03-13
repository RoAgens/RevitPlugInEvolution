using AGRevitCommandSimple.Base;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace AGRevitCommandSimple
{
    [Transaction(TransactionMode.Manual)]
    internal class Command : BaseExternalCommand
    {
        public override Result Execute()
        {
            TaskDialog.Show("SelectedElementId", $"Picked element ID: {GetElementId()}");

            return Result.Succeeded;
        }

        private string GetElementId()
        {
            Reference reference = _uiDoc.Selection.PickObject(ObjectType.Element, "Please pick any element");

            return reference != null ? reference.ElementId.ToString() : "Element not selected";
        }
    }
}