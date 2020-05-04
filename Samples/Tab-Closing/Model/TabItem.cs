
using Syncfusion.Windows.Shared;
using System.Windows;
using System.Windows.Controls;

namespace Tab_Closing
{
    public class TabItem : NotificationObject
    {
        private string header;
        private TextBlock content;
        private bool canClose;
        private Visibility closeButtonState;

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