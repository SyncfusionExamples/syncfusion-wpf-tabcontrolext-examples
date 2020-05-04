using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Templates
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<Model> tabItems;
        public ObservableCollection<Model> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged("TabItems");
            }
        }

        public ViewModel()
        {
            tabItems = new ObservableCollection<Model>();
            PopulateCollection();
        }

        public void PopulateCollection()
        {
            Model model1 = new Model()
            {
                Header = "tabItem1",
                Content = new TextBlock()
                {
                    Text = "This is the content of first tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                }
            };
            Model model2 = new Model()
            {
                Header = "tabItem2",
                Content = new TextBlock()
                {
                    Text = "This is the content of second tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                }
            };
            Model model3 = new Model()
            {
                Header = "tabItem3",
                Content = new TextBlock()
                {
                    Text = "This is the content of third tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                }
            };

            //Adding tab item details to the collection
            tabItems.Add(model1);
            tabItems.Add(model2);
            tabItems.Add(model3);
        }
    }
}