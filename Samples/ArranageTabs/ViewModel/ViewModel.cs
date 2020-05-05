using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace ArranageTabs
{
    class ViewModel : NotificationObject
    {
        private bool allowDragDrop = true;
        private Brush dragMarkerColor= Brushes.Red;
        private TabItemLayoutType tabItemLayout= TabItemLayoutType.MultiLine;
        private ObservableCollection<object> tabItems;

        public ObservableCollection<object> TabItems
        {
            get
            {
                return tabItems;
            }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged(nameof(TabItems));
            }
        }

        public bool AllowDragDrop
        {
            get { return allowDragDrop; }
            set
            {
                allowDragDrop = value;
                this.RaisePropertyChanged(nameof(AllowDragDrop));
            }
        }
        public TabItemLayoutType TabItemLayout
        {
            get { return tabItemLayout; }
            set
            {
                tabItemLayout = value;
                this.RaisePropertyChanged(nameof(TabItemLayout));
            }
        }

        public Brush DragMarkerColor
        {
            get { return dragMarkerColor; }
            set
            {
                dragMarkerColor = value;
                this.RaisePropertyChanged(nameof(DragMarkerColor));
            }
        }     
        
        public ViewModel()
        {
            TabItems = new ObservableCollection<object>();
        }
    }
}
