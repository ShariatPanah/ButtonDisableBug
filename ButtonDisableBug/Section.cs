using CommunityToolkit.Mvvm.ComponentModel;

namespace ButtonDisableBug
{
    public partial class Section : ObservableObject
    {
        [ObservableProperty]
        private string _title = "";
    }
}
