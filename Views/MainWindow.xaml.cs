using Autodesk.Revit.DB;
using System.Windows;

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
            tbSelectElementId.Text = "---------";
        }
    }
}
