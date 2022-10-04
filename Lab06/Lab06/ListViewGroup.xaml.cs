using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<group> personas = new ObservableCollection<group>();

        public ObservableCollection<group> Personas { get { return personas; } }
        public ListViewGroup()
        {
            InitializeComponent();
            GroupView.ItemsSource = personas;
            personas.Add(new group("Alpha", "A")
            {
                new Employee{DisplayName ="Alfie" },
                new Employee{DisplayName ="Ava" },
                new Employee{DisplayName ="Archie" },
                new Employee{DisplayName ="Amelia" },
            });
            personas.Add(new group("Bravo", "B")
            {
                new Employee { DisplayName = "Brooke" },
                new Employee { DisplayName = "Bobby" },
                new Employee { DisplayName = "Bella" },
                new Employee { DisplayName = "Ben" },
            });
            personas.Add(new group("Charlie", "C")
            {
                new Employee { DisplayName = "Carolina" },
                new Employee { DisplayName = "Christian"},
                new Employee { DisplayName = "Camila"},
                new Employee { DisplayName = "Chachi"},
            });
            
        }
    }
}