using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ToDoList.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(Text);
            Text = String.Empty;
        }
    }
}