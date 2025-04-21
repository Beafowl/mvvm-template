using System.ComponentModel;

namespace Model
{
    public class ExampleModel : INotifyPropertyChanged
    {
        public string Name { get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;

        public ExampleModel()
        {
            Name = "bla";
        }
    }
}
