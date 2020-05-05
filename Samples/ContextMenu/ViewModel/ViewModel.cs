using Syncfusion.Windows.Shared;
using System.Windows;

namespace ContextMenu
{
    public class ViewModel : NotificationObject
    {
        private bool showTabItemContextMenu = true;
        private bool showTabListContextMenu =true;
        private bool isCustomTabItemContextMenuEnabled=true;
        private Visibility defaultContextMenuItemVisibility= Visibility.Visible;

        public Visibility DefaultContextMenuItemVisibility
        {
            get { return defaultContextMenuItemVisibility; }
            set
            {
                defaultContextMenuItemVisibility = value;
                this.RaisePropertyChanged(nameof(DefaultContextMenuItemVisibility));
            }
        }

        public bool ShowTabItemContextMenu
        {
            get { return showTabItemContextMenu; }
            set
            {
                showTabItemContextMenu = value;
                this.RaisePropertyChanged(nameof(ShowTabItemContextMenu));
            }
        }

        public bool ShowTabListContextMenu
        {
            get { return showTabListContextMenu; }
            set
            {
                showTabListContextMenu = value;
                this.RaisePropertyChanged(nameof(ShowTabListContextMenu));
            }
        } 
        
        public bool IsCustomTabItemContextMenuEnabled
        {
            get { return isCustomTabItemContextMenuEnabled; }
            set
            {
                isCustomTabItemContextMenuEnabled = value;
                this.RaisePropertyChanged(nameof(IsCustomTabItemContextMenuEnabled));
            }
        }

        public ViewModel()
        {
        }
    }
}
