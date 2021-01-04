using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.ObjectModel;

namespace TabListContextMenuOptions
{
    public class ViewModel : NotificationObject
    {

        private Syncfusion.Windows.Tools.Controls.TabListContextMenuOptions tabListContextMenuOptions = Syncfusion.Windows.Tools.Controls.TabListContextMenuOptions.ShowHiddenItems;
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

        public Syncfusion.Windows.Tools.Controls.TabListContextMenuOptions TabListContextMenuOptions
        {
            get { return tabListContextMenuOptions; }
            set
            {
                tabListContextMenuOptions = value;
                this.RaisePropertyChanged(nameof(TabListContextMenuOptions));
            }
        }

        public ViewModel()
        {
            TabItems = new ObservableCollection<object>();
        }
    }
}