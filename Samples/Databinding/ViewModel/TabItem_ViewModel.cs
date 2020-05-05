using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;

namespace Tabcontrol_binding
{
    public class TabItem_ViewModel : NotificationObject
    {
        private string header;
        private string content;
        private string image;
        private ImageAlignment imageAlignment = ImageAlignment.LeftOfText;

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

        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                this.RaisePropertyChanged(nameof(Image));
            }
        }


        public ImageAlignment ImageAlignment
        {
            get { return imageAlignment; }
            set
            {
                imageAlignment = value;
                this.RaisePropertyChanged(nameof(ImageAlignment));
            }
        }

        public TabItem_ViewModel()
        {

        }
    }
}
