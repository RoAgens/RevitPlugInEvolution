using System.Windows;
using Autodesk.Revit.UI;
using System.Windows.Controls;
using AGRevitCommandSimple.Models;
using AGRevitCommandSimple.ViewModels.Base;

namespace AGRevitCommandSimple.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly UIDocument _uiDoc;
        private readonly SelectElementService _selectElementService;

        public MainWindowViewModel(UIDocument uiDoc, SelectElementService selectElementService)
        {
            _uiDoc = uiDoc;
            _selectElementService = selectElementService;
        }

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
            SelectedElementId = _selectElementService.GetElementId();
        }));

        private RelayCommand _closeWindow;
        public RelayCommand CloseWindow => _closeWindow ??
            (_closeWindow = new RelayCommand(obj =>
            {
                var button = obj as Button;
                var window = Window.GetWindow(button);

                if (window != null) window.Close();  
            }));
    }
}