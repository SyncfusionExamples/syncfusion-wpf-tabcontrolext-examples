using System.Windows;
using Syncfusion.Windows.Shared;

namespace Pin_UnPin
{
    public class TabItem_ViewModel : NotificationObject
    {
        private string header;
        private string content;
        private bool canClose;
        private bool allowPin;
        private bool showPin;
        private Visibility closeButtonState;
        private bool isPinned;

        public string Header
        {
            get { return header; }
            set
            {
                header = value;
                this.RaisePropertyChanged(nameof(Header));
            }
        }

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                this.RaisePropertyChanged(nameof(Content));
            }
        }
        public bool CanClose
        {
            get
            {
                return canClose;
            }
            set
            {
                canClose = value;
                this.RaisePropertyChanged(nameof(CanClose));
            }
        }

        public bool AllowPin
        {
            get
            {
                return allowPin;
            }
            set
            {
                allowPin = value;
                this.RaisePropertyChanged(nameof(AllowPin));
            }
        }

        public bool ShowPin
        {
            get
            {
                return showPin;
            }
            set
            {
                showPin = value;
                this.RaisePropertyChanged(nameof(ShowPin));
            }
        }

        public bool IsPinned
        {
            get
            {
                return isPinned;
            }
            set
            {
                isPinned = value;
                this.RaisePropertyChanged(nameof(IsPinned));
            }
        }

        public Visibility CloseButtonState
        {
            get
            {
                return closeButtonState;
            }
            set
            {
                closeButtonState = value;
                this.RaisePropertyChanged(nameof(CloseButtonState));
            }
        }

        public TabItem_ViewModel()
        {

        }
    }
}
