using System.ComponentModel;
using ViewModels.BaseClass;

namespace TeruletProject.Model
{
    public class Terulet : ViewModelBase
    {
        private double _a;
        public Terulet()
        {
            _a = 3;
        }
        public string A
        {
            get => _a.ToString();
            set => SetValue(ref _a, Convert.ToDouble(value));
        }


        public double Haromszog
        {
            get
            {
                double haromszog = (Math.Pow(_a, 2) * Math.Sqrt(3)) / 4;
                double roundedTer = Math.Round(haromszog, 2);
                return roundedTer;
            }
        }

        public string TeruletAdatok
        {
            get
            {
                return " A végösszeg: " + Haromszog;
            }
        }

        public void Compute()
        {
            OnPropertyChanged(nameof(Haromszog));
            OnPropertyChanged(nameof(TeruletAdatok));
        }
    }
}
