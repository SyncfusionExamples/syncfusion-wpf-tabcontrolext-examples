using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SelectedItem
{
    public class TabItem : NotificationObject
    {
        private string header;
        private TextBlock content;

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
        public TabItem()
        {

        }
    }
}
