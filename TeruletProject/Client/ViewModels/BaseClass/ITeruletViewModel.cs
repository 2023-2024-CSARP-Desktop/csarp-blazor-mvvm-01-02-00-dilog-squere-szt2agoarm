using System.ComponentModel;

namespace ViewModels.BaseClass
{
    public class ITeruletViewModel
    {
        bool IsBusy { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
    }
}
