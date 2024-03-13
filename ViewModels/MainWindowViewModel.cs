
using Autodesk.Revit.DB;
using System.ComponentModel;
using System.Windows;

namespace AGRevitCommandSimple.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly Document _doc;

        public MainWindowViewModel(Document doc) => _doc = doc;

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
            SelectElementService();
        }));

        private RelayCommand _closeWindow;
        public RelayCommand CloseWindow => _closeWindow ??
        (_closeWindow = new RelayCommand(obj =>
        {
            (obj as Window)?.Close();
        }));

        private void SelectElementService()
        {

        }
    }
}