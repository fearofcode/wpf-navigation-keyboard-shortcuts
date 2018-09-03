using System.Windows.Controls;

namespace navigation
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public static Page1 instance = new Page1();

        private Page1()
        {
            InitializeComponent();
        }
    }
}
