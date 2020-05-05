using System.Windows;
using Syncfusion.Windows.Shared;
namespace Tab_Closing
{
   public class TabItem_ViewModel : NotificationObject
    {
        private string header;
        private string content;
        private bool canClose;
        private Visibility closeButtonState;

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
            get { return canClose; }
            set
            {
                canClose = value;
                this.RaisePropertyChanged(nameof(CanClose));
            }
        }

        public Visibility CloseButtonState
        {
            get { return closeButtonState; }
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