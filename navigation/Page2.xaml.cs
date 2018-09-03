using System.Windows.Controls;

namespace navigation
{
    public partial class Page2 : Page
    {
        public static Page2 instance = new Page2();

        private Page2()
        {
            InitializeComponent();
        }
    }
}
