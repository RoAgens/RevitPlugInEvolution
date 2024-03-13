using Autodesk.Revit.DB;

namespace AGRevitCommandSimple.Models
{
    internal class SelectElementService
    {
        private readonly Document _doc;

        public SelectElementService(Document doc) => _doc = doc;

        public string GetElementId()
        {
            return SelectElement().Id.ToString();
        }

        private Element SelectElement()
        {
            return null;
        }
    }
}