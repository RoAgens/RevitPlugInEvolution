using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;

namespace AGRevitCommandSimple.Base
{
    internal abstract class BaseExternalCommand : IExternalCommand
    {
        protected ExternalCommandData _commandData;
        protected UIDocument _uiDoc;
        protected Application _app;
        protected Document _doc;

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            _commandData = commandData;
            _uiDoc = commandData.Application.ActiveUIDocument;
            _app = commandData.Application.Application;

            _doc = commandData.Application.ActiveUIDocument?.Document;

            try
            {
                return Execute();
            }
            catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }
        }

        public abstract Result Execute();
    }
}
