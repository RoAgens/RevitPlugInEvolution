
using Autodesk.Revit.DB;

namespace AGRevitCommandSimple.ViewModels
{
    public class MainaWindowViewModel
    {
        private readonly Document _doc;

        public MainaWindowViewModel(Document doc) => _doc = doc;
    }
}