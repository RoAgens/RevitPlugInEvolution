using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using AGRevitCommandSimple.UI;
using AGRevitCommandSimple.Base;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Selection;

namespace AGRevitCommandSimple
{
    [Transaction(TransactionMode.Manual)]
    internal class Command : BaseExternalCommand
    {
        private MainWinForm _mainWinForm = new();
 
        public override Result Execute()
        {
            _mainWinForm.btClose.Click += (s, e) => _mainWinForm.Close();
            _mainWinForm.btnSelectElement.Click += (s, e) => SelectElemet();
            _mainWinForm.Show();

            return Result.Succeeded;
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SelectElemet()
        {
            UIDocument uIDocument = new(_doc);

            Reference reference = uIDocument.Selection.PickObject(ObjectType.Element);

            _mainWinForm.tbElementId.Text = reference?.ElementId.ToString();
        }
    }
}