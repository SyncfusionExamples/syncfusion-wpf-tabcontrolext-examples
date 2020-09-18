using Syncfusion.SfSkinManager;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Themes
{
    class ViewModel : NotificationObject
    {
        private FlowDirection flowDirection;
        private ObservableCollection<string> themes = new ObservableCollection<string>();
        private DelegateCommand<object> selectionChangedCommand;
        private ObservableCollection<object> tabItems;

        public ObservableCollection<object> TabItems
        {
            get { return tabItems; }
            set
            {
                tabItems = value;
                this.RaisePropertyChanged(nameof(TabItems));
            }
        }
        public ICommand SelectionChangedCommand
        {
            get
            {
                return selectionChangedCommand;
            }
        }

        public ObservableCollection<string> Themes
        {
            get { return themes; }
            set
            {
                themes = value;
                this.RaisePropertyChanged(nameof(Themes));
            }
        }

        public FlowDirection FlowDirection
        {
            get { return flowDirection; }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged(nameof(FlowDirection));
            }
        }

        public void selectionChanged(object parameter)
        {
            WindowCollection windows = Application.Current.Windows;
            if (windows.Count > 0)
            {
                Window samplewindow = windows[0];
                ComboBox combo = parameter as System.Windows.Controls.ComboBox;
                if (combo != null)
                {
                    if (combo.SelectedItem != null)
                    {
                        string themename = combo.SelectedValue.ToString();
                        SfSkinManager.SetVisualStyle(samplewindow, (VisualStyles)Enum.Parse(typeof(VisualStyles), themename));
                    }
                }
            }
        }

        public ViewModel()
        {
            TabItems = new ObservableCollection<object>();

            //Theme list  added in the collection
            Themes.Add("Blend");
            Themes.Add("Lime");
            Themes.Add("MaterialDark");
            Themes.Add("MaterialDarkBlue");
            Themes.Add("MaterialLight");
            Themes.Add("MaterialLightBlue");
            Themes.Add("Metro");
            Themes.Add("Office2010Black");
            Themes.Add("Office2010Blue");
            Themes.Add("Office2010Silver");
            Themes.Add("Office2013DarkGray");
            Themes.Add("Office2013LightGray");
            Themes.Add("Office2013White");
            Themes.Add("Office2016Colorful");
            Themes.Add("Office2016DarkGray");
            Themes.Add("Office2016White");
            Themes.Add("Office2019Black");
            Themes.Add("Office2019Colorful");
            Themes.Add("Office365");
            Themes.Add("Saffron");
            Themes.Add("VisualStudio2013");
            Themes.Add("VisualStudio2015");

            selectionChangedCommand = new DelegateCommand<object>(selectionChanged);
        }
    }
}
