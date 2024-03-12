using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Form = System.Windows.Forms.Form;

namespace AGRevitCommandSimple.UI
{
    public partial class MainWinForm : Form
    {
        private readonly Document _doc;

        public MainWinForm()
        {
            InitializeComponent();
        }

        public MainWinForm(Document doc)
        {
            _doc = doc;
            InitializeComponent();
        }

        private void btnSelectElement_Click(object sender, EventArgs e)
        {
            tbElementId.Text = SelectElemet();
        }

        private string SelectElemet()
        {
            UIDocument uIDocument = new(_doc);

            Reference reference = uIDocument.Selection.PickObject(ObjectType.Element);
            Element element = _doc.GetElement(reference);
            ElementId elementId = element.Id;
            int intElementId = elementId.IntegerValue;

            return $"{intElementId}";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}