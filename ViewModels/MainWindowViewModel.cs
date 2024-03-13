using Autodesk.Revit.DB;
using AGRevitCommandSimple.Models;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Autodesk.Revit.UI;

namespace AGRevitCommandSimple.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly UIDocument _uiDoc;

        public MainWindowViewModel(UIDocument uiDoc) => _uiDoc = uiDoc;

        [ObservableProperty]
        private string _selectedElementId;

        [RelayCommand]
        private void GetSelectedElementID()
        {
            SelectedElementId = new SelectElementService(_uiDoc).GetElementId();
        }
    }
}