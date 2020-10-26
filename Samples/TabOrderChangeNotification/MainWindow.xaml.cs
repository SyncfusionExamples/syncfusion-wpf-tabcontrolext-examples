using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TabOrderChangeNotification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabControlExt_TabOrderChanging(object sender, Syncfusion.Windows.Tools.Controls.TabOrderChangingEventArgs e)
        {
            // Restrict the Tab order changing
            e.Cancel = true;
            var draggeditem = e.TargetItem;
            var oldIndex = e.OldIndex;
            var newIndex = e.NewIndex;
        }

        private void TabControlExt_TabOrderChanged(object sender, Syncfusion.Windows.Tools.Controls.TabOrderChangedEventArgs e)
        {
            var drag_Drop_Item = e.TargetItem;
            var oldIndex = e.OldIndex;
            var newIndex = e.NewIndex;
        }
    }
}
