using Autodesk.Revit.DB;
using AGRevitCommandSimple.Models;
using AGRevitCommandSimple.ViewModels.Base;
using Autodesk.Revit.UI;

namespace AGRevitCommandSimple.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly UIDocument _uiDoc;

        public MainWindowViewModel(UIDocument uiDoc) => _uiDoc = uiDoc;

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
            SelectedElementId = new SelectElementService(_uiDoc).GetElementId();
        }));
    }
}