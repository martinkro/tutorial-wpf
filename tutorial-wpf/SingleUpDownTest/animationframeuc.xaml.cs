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

namespace SingleUpDownTest
{
    /// <summary>
    /// Interaction logic for animationframeuc.xaml
    /// </summary>
    public partial class animationframeuc : UserControl
    {
        private float unitTime = 0.2f;
        public animationframeuc()
        {
            InitializeComponent();
        }

        public float UnitTime
        {
            get
            {
                return unitTime;
            }
            set
            {
                unitTime = value;
            }
        }
    }
}
