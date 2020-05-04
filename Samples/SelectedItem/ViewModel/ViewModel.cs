using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SelectedItem.ViewModel
{
    public class ViewModel : NotificationObject
    {
        private Brush tabItemSelectedForeground = Brushes.Red;
        private Brush tabItemSelectedBackground = Brushes.Green;
        private FontWeight selectedItemFontWeight = FontWeights.Bold;
        private bool isDisableUnloadTabItemExtContent;
        private ObservableCollection<TabItem> tabItems;

        public ObservableCollection<TabItem> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged("TabItems");
            }
        }
        public Brush TabItemSelectedForeground
        {
            get { return tabItemSelectedForeground; }
            set
            {
                tabItemSelectedForeground = value;
                this.RaisePropertyChanged("TabItemSelectedForeground");
            }
        }
        public Brush TabItemSelectedBackground
        {
            get { return tabItemSelectedBackground; }
            set
            {
                tabItemSelectedBackground = value;
                this.RaisePropertyChanged("TabItemSelectedBackground");
            }
        }

        public FontWeight SelectedItemFontWeight
        {
            get { return selectedItemFontWeight; }
            set
            {
                selectedItemFontWeight = value;
                this.RaisePropertyChanged("SelectedItemFontWeight");
            }
        }

        public bool IsDisableUnloadTabItemExtContent
        {
            get { return isDisableUnloadTabItemExtContent; }
            set
            {
                isDisableUnloadTabItemExtContent = value;
                this.RaisePropertyChanged("IsDisableUnloadTabItemExtContent");
            }
        }

        public ViewModel()
        {
            tabItems = new ObservableCollection<TabItem>();
            PopulateCollection();
        }

        public void PopulateCollection()
        {
            TabItem tabItem1 = new TabItem()
            {
                Header = "tabItem1",
                Content = new TextBlock()
                {
                    Text = "This is the content of first tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                }
            };
            TabItem tabItem2 = new TabItem()
            {
                Header = "tabItem2",
                Content = new TextBlock()
                {
                    Text = "This is the content of second tabitem.",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,

                }
            };
            TabItem tabItem3 = new TabItem()
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
            tabItems.Add(tabItem1);
            tabItems.Add(tabItem2);
            tabItems.Add(tabItem3);
        }
    }
}