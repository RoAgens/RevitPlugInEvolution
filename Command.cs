using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Selection;

namespace AGRevitCommandSimple
{
    [Transaction(TransactionMode.Manual)]
    internal class Command : IExternalCommand
    {
        private Document _doc;
        private UIDocument _uiDoc;

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            _uiDoc = commandData.Application.ActiveUIDocument;
            _doc = commandData.Application.ActiveUIDocument?.Document;

            try
            {
                TaskDialog.Show("SelectedElementId", $"Picked element ID: {GetElementId()}");
                return Result.Succeeded;
            }
            catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }
        }

        private string GetElementId()
        {
            string value = "";

            Element elemnt = GetElement();

            if (elemnt != null)
                value = elemnt.Id.ToString();
            else
                value = "Element not selected";

            return value;
        }

        private Element GetElement()
        {
            Element element = null;

            Reference reference = _uiDoc.Selection.PickObject(ObjectType.Element, "Please pick any element");

            if (reference != null)
            {
                element = _doc.GetElement(reference.ElementId);
            }

            return element;
        }
    }
}