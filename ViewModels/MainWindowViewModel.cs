using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.ComponentModel;
using Autodesk.Revit.UI.Selection;
using AGRevitCommandSimple.View;

namespace AGRevitCommandSimple.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly UIDocument _uiDoc;

        public MainWindowViewModel(UIDocument uiDoc) => _uiDoc = uiDoc;

        private Document Doc => _uiDoc.Document;

        public event PropertyChangedEventHandler PropertyChanged;

        private string _selectedElementId;
        public string SelectedElementId
        {
            get { return _selectedElementId; }
            set
            {
                _selectedElementId = value;
                OnPropertyChanged(nameof(SelectedElementId));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private RelayCommand _selectElement;
        public RelayCommand SelectElement => _selectElement ??
        (_selectElement = new RelayCommand(obj =>
        {
            SelectedElementId = SelectElementService();
        }));

        private RelayCommand _closeWindow;
        public RelayCommand CloseWindow => _closeWindow ??
        (_closeWindow = new RelayCommand(obj =>
        {
            (obj as MainWindow)?.Close();
        }));

        private string SelectElementService()
        {
            Reference reference = _uiDoc.Selection.PickObject(ObjectType.Element, "Please pick any element");

            return reference?.ElementId.ToString();
        }
    }
}