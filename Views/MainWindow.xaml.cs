using System.Windows;
using Autodesk.Revit.DB;
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
            tbSelectElementId.Text = "---------";
            InitializeComponent();
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
            Reference reference = _uiDoc.Selection.PickObject(ObjectType.Element, "Please pick any element");

            tbElementId.Text = reference?.ElementId.ToString();
        }
    }
}