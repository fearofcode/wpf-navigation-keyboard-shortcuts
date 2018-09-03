using System.Windows;
using System.Windows.Input;

namespace navigation
{
    public partial class MainWindow : Window
    {
        public static readonly RoutedUICommand GotoPage1 = new RoutedUICommand
            (
                "Go to Page 1",
                "Go to Page 1",
                typeof(MainWindow),
                new InputGestureCollection() { new KeyGesture(Key.F1) }
            );

        public static readonly RoutedUICommand GotoPage2 = new RoutedUICommand
            (
                "Go to Page 2",
                "Go to Page 2",
                typeof(MainWindow),
                new InputGestureCollection() { new KeyGesture(Key.F2) }
            );

        public MainWindow()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding(GotoPage1, Page1Command_Executed));
            CommandBindings.Add(new CommandBinding(GotoPage2, Page2Command_Executed));

            Loaded += MainWindow_Loaded;            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ShowPage1();
        }

        private void Command_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Page1Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ShowPage1();
        }

        private void Page2Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ShowPage2();
        }

        private void Page1Button_Click(object sender, RoutedEventArgs e)
        {
            ShowPage1();
        }

        private void Page2Button_Click(object sender, RoutedEventArgs e)
        {
            ShowPage2();
        }

        private void ShowPage1()
        {
            Main.Content = Page1.instance;
            Page1.instance.textBox.Focus();
        }

        private void ShowPage2()
        {
            Main.Content = Page2.instance;
            Page2.instance.textBox.Focus();
        }
    }
}
