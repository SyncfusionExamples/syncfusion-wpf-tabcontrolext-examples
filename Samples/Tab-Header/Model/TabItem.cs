using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Controls;

namespace Tab_Header
{
    public class TabItem : NotificationObject
    {
        private string header;
        private TextBlock content;
        private string image;
        private ImageAlignment imageAlignment = ImageAlignment.LeftOfText;

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

        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                this.RaisePropertyChanged("Image");
            }
        }


        public ImageAlignment ImageAlignment
        {
            get { return imageAlignment; }
            set
            {
                imageAlignment = value;
                this.RaisePropertyChanged("ImageAlignment");
            }
        }

        public TabItem()
        {

        }
    }
}