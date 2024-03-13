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
            return Result.Succeeded;
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