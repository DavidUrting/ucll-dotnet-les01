using Oefening01;
using System.ComponentModel;

namespace DemoWPF.ViewModels
{
    public class GreeterViewModel : INotifyPropertyChanged
    {
        private Greeter _greeter = new Greeter();
        public GreeterViewModel()
        {
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Greeting = _greeter.Greet(_name);
                OnPropertyChanged("Greeting");
            }
        }

        public string Greeting
        {
            get;
            private set;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
