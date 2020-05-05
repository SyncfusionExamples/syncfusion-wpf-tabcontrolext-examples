using Syncfusion.Windows.Shared;

namespace NewButton
{
    public class TabItem_ViewModel : NotificationObject
    {
        private string header;
        private string content;

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
    }
}
