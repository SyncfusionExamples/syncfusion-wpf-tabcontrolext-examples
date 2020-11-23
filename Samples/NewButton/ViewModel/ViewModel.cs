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
        private bool selectOnCreatingNewItem = true;
        private ObservableCollection<TabItem_ViewModel> tabItems;
        private ICommand newButtonClickCommand;

        public ICommand NewButtonClickCommand
        {
            get
            {
                return newButtonClickCommand;
            }
            set
            {
                newButtonClickCommand = value;
            }
        }
        public Brush NewButtonBackground
        {
            get { return newButtonBackground; }
            set
            {
                newButtonBackground = value;
                this.RaisePropertyChanged(nameof(NewButtonBackground));
            }
        }
        
        public NewButtonAlignment NewButtonAlignment
        {
            get { return newButtonAlignment; }
            set
            {
                newButtonAlignment = value;
                this.RaisePropertyChanged(nameof(NewButtonAlignment));
            }
        }
        public bool IsNewButtonEnabled
        {
            get { return isNewButtonEnabled; }
            set
            {
                isNewButtonEnabled = value;
                this.RaisePropertyChanged(nameof(IsNewButtonEnabled));
            }
        } 
        
        public bool SelectOnCreatingNewItem
        {
            get { return selectOnCreatingNewItem; }
            set
            {
                selectOnCreatingNewItem = value;
                this.RaisePropertyChanged(nameof(SelectOnCreatingNewItem));
            }
        }
        public bool IsNewButtonClosedonNoChild
        {
            get { return isNewButtonClosedonNoChild; }
            set
            {
                isNewButtonClosedonNoChild = value;
                this.RaisePropertyChanged(nameof(IsNewButtonClosedonNoChild));
            }
        }
        
        public ObservableCollection<TabItem_ViewModel> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged(nameof(TabItems));
            }
        }
        public void NewButtonClicked(object parameter)
        {
            TabControlExt tabControl = parameter as TabControlExt;
            int count = tabControl.Items.Count + 1;
            TabItem_ViewModel new_model1 = new TabItem_ViewModel()
            {
                Header = "tabItem" + count,
                Content = "This is the content of "+ count + " tabitem."
            };
            tabItems.Add(new_model1);
        }        

        public void PopulateCollection()
        {
            TabItem_ViewModel model1 = new TabItem_ViewModel()
            {
                Header = "tabItem1",
                Content = "This is the content of 1 tabitem."
            };
            TabItem_ViewModel model2 = new TabItem_ViewModel()
            {
                Header = "tabItem2",
                Content = "This is the content of 2 tabitem."
            };

            //Adding tab item details to the collection
            tabItems.Add(model1);
            tabItems.Add(model2);
        }
        public ViewModel()
        {
            tabItems = new ObservableCollection<TabItem_ViewModel>();
            PopulateCollection();
            NewButtonClickCommand = new DelegateCommand<object>(NewButtonClicked);
        }
    }
}