using Autodesk.Revit.DB;
using AGRevitCommandSimple.Models;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AGRevitCommandSimple.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly Document _doc;

        public MainWindowViewModel(Document doc) => _doc = doc;

        [ObservableProperty]
        private string _selectedElementId;

        [RelayCommand]
        private void GetSelectedElementID()
        {
            SelectedElementId = new SelectElementService(_doc).GetElementId();
        }
    }
}