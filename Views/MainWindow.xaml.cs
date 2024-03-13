using System.Windows;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace AGRevitCommandSimple.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Document _doc;

        public MainWindow(Document doc)
        {
            _doc = doc;

            InitializeComponent();

            tbSelectElementId.Text = "---------";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSelectElement_Click(object sender, RoutedEventArgs e)
        {
            GetSelectElementId();
        }

        private void GetSelectElementId()
        {
            UIDocument uIDocument = new(_doc);

            Reference reference = uIDocument.Selection.PickObject(ObjectType.Element, "Please pick any element");

            tbSelectElementId.Text = reference?.ElementId.ToString();
        }
    }
}