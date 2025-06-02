using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Horvath_Mark_Ckiindulo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly AppContext context = new AppContext();

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string tulajdonsagNev)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(tulajdonsagNev));
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            //context.valami.load();
            //Pilots = context.pilots.Local.ToObservableCollection();
        }
    }
}