using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Media;

namespace ArranageTabs
{
    class ViewModel : NotificationObject
    {
        private bool allowDragDrop = true;
        private Brush dragMarkerColor= Brushes.Red;
        private TabItemLayoutType tabItemLayout= TabItemLayoutType.MultiLine;

        public bool AllowDragDrop
        {
            get { return allowDragDrop; }
            set
            {
                allowDragDrop = value;
                this.RaisePropertyChanged("AllowDragDrop");
            }
        }
        public TabItemLayoutType TabItemLayout
        {
            get { return tabItemLayout; }
            set
            {
                tabItemLayout = value;
                this.RaisePropertyChanged("TabItemLayout");
            }
        }

        public Brush DragMarkerColor
        {
            get { return dragMarkerColor; }
            set
            {
                dragMarkerColor = value;
                this.RaisePropertyChanged("DragMarkerColor");
            }
        }        
    }
}
