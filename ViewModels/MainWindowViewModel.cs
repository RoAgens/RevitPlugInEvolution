using Autodesk.Revit.DB;
using AGRevitCommandSimple.Models;
using AGRevitCommandSimple.ViewModels.Base;

namespace AGRevitCommandSimple.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly Document _doc;

        public MainWindowViewModel(Document doc) => _doc = doc;

        private string _selectedElementId;
        public string SelectedElementId
        {
            get => _selectedElementId;
            set
            {
                _selectedElementId = value;
                OnPropertyChanged(nameof(SelectedElementId));
            }
        }

        private RelayCommand _selectElement;
        public RelayCommand SelectElement => _selectElement ??
        (_selectElement = new RelayCommand(obj =>
        {
            SelectedElementId = new SelectElementService(_doc).GetElementId();
        }));
    }
}