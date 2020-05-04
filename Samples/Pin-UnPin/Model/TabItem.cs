using Syncfusion.Windows.Shared;
using System.Windows;
using System.Windows.Controls;

namespace Pin_UnPin
{
    public class TabItem : NotificationObject
    {
        private string header;
        private TextBlock content;
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
                this.RaisePropertyChanged("Header");
            }
        }

        public TextBlock Content
        {
            get { return content; }
            set
            {
                content = value;
                this.RaisePropertyChanged("Content");
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
                canClose = value; this.RaisePropertyChanged("CanClose");
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
                this.RaisePropertyChanged("AllowPin");
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
                this.RaisePropertyChanged("ShowPin");
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
                this.RaisePropertyChanged("IsPinned");
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
                this.RaisePropertyChanged("CloseButtonState"); 
            }
        }

        public TabItem()
        {

        }
    }
}
