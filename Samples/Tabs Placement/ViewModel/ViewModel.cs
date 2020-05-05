using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScrollButton
{
    public class ViewModel : NotificationObject
    {
        private TabScrollButtonVisibility tabScrollButtonVisibility = TabScrollButtonVisibility.Auto;
        private TabScrollStyle tabScrollStyle = TabScrollStyle.Extended;
        private bool rotateTextWhenVertical;
        private Dock tabStripPlacement= Dock.Top;

        
        
        public TabScrollButtonVisibility TabScrollButtonVisibility
        {
            get { return tabScrollButtonVisibility; }
            set
            {
                tabScrollButtonVisibility = value;
                this.RaisePropertyChanged(nameof(TabScrollButtonVisibility));
            }
        }
        
        public bool RotateTextWhenVertical
        {
            get { return rotateTextWhenVertical; }
            set
            {
                rotateTextWhenVertical = value;
                this.RaisePropertyChanged(nameof(RotateTextWhenVertical));
            }
        }
                
        public Dock TabStripPlacement
        {
            get { return tabStripPlacement; }
            set
            {
                tabStripPlacement = value;
                this.RaisePropertyChanged(nameof(TabStripPlacement));
            }
        }

        public TabScrollStyle TabScrollStyle
        {
            get { return tabScrollStyle; }
            set
            {
                tabScrollStyle = value;
                this.RaisePropertyChanged(nameof(TabScrollStyle));
            }
        }

        public ViewModel()
        {

        }
    }
}
