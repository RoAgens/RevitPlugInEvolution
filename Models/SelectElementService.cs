using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace AGRevitCommandSimple.Models
{
    internal class SelectElementService
    {
        private readonly UIDocument _uiDoc;

        public SelectElementService(UIDocument uiDoc) => _uiDoc = uiDoc;

        public string GetElementId()
        {
            return SelectElement()?.ToString();
        }

        private ElementId SelectElement()
        {
            Reference reference = _uiDoc.Selection.PickObject(ObjectType.Element, "Please pick any element");
            return reference?.ElementId;
        }
    }
}