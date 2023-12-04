using Syncfusion.Maui.TabView;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TabviewSample {
    public partial class MainPage : ContentPage 
    {      
        public MainPage() {
            InitializeComponent();
        }       
    }

    public class Model : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;

        public string Name {
            get { return name; }
            set {
                name = value;

            }
        }

        private string id;

        public string ID {
            get { return id; }
            set {
                id = value;

            }
        }
    }

    public class TabItemsSourceViewModel : INotifyPropertyChanged {
            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propertyName) {
                var handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs(propertyName));
            }

            private ObservableCollection<Model> tabItems;
            public ObservableCollection<Model> TabItems {
                get { return tabItems; }
                set {
                    tabItems = value;
                    OnPropertyChanged("TabItems");
                }
            }
            public TabItemsSourceViewModel() {
                TabItems = new ObservableCollection<Model>();
                TabItems.Add(new Model() { ID = "Calls" });
                TabItems.Add(new Model() { ID = "Message" });
                TabItems.Add(new Model() { ID = "Photos" });               
            }
        }
 }




