using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace NewButton
{
    public class ViewModel : NotificationObject
    {
        private NewButtonAlignment newButtonAlignment= NewButtonAlignment.Last;
        private Brush newButtonBackground = Brushes.Red;
        private bool isNewButtonClosedonNoChild=true;
        private bool isNewButtonEnabled = true;
        private ObservableCollection<Model> tabItems;
        private DelegateCommand<object> newButtonClickCommand;

        public ICommand NewButtonClickCommand
        {
            get
            {
                return newButtonClickCommand;
            }
        }
        public Brush NewButtonBackground
        {
            get { return newButtonBackground; }
            set
            {
                newButtonBackground = value;
                this.RaisePropertyChanged("NewButtonBackground");
            }
        }
        
        public NewButtonAlignment NewButtonAlignment
        {
            get { return newButtonAlignment; }
            set
            {
                newButtonAlignment = value;
                this.RaisePropertyChanged("NewButtonAlignment");
            }
        }
        public bool IsNewButtonEnabled
        {
            get { return isNewButtonEnabled; }
            set
            {
                isNewButtonEnabled = value;
                this.RaisePropertyChanged("IsNewButtonEnabled");
            }
        }
        public bool IsNewButtonClosedonNoChild
        {
            get { return isNewButtonClosedonNoChild; }
            set
            {
                isNewButtonClosedonNoChild = value;
                this.RaisePropertyChanged("IsNewButtonClosedonNoChild");
            }
        }
        
        public ObservableCollection<Model> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged("TabItems");
            }
        }
        public void NewButtonClicked(object parameter)
        {
            TabControlExt tabControl = parameter as TabControlExt;
            int count = tabControl.Items.Count + 1;
            Model new_model1 = new Model()
            {
                Header = "tabItem" + count,
                Content = new TextBlock()
                {
                    Text = "This is the content of "+ count + " tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                }
            };
            tabItems.Add(new_model1);
        }        

        public void PopulateCollection()
        {
            Model model1 = new Model()
            {
                Header = "tabItem1",
                Content = new TextBlock()
                {
                    Text = "This is the content of 1 tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                }
            };
            Model model2 = new Model()
            {
                Header = "tabItem2",
                Content = new TextBlock()
                {
                    Text = "This is the content of 2 tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                }
            };

            //Adding tab item details to the collection
            tabItems.Add(model1);
            tabItems.Add(model2);
        }
        public ViewModel()
        {
            tabItems = new ObservableCollection<Model>();
            PopulateCollection();
            newButtonClickCommand = new DelegateCommand<object>(NewButtonClicked);
        }
    }
}