using Autodesk.Revit.UI;
using System.Windows.Controls;
using AGRevitCommandSimple.Models;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

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
        [RelayCommand]
        private void CloseWindow(Button? button)
        {
            var window = Window.GetWindow(button);
            if (window != null) window.Close();
        }
    }
}