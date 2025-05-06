using System;

namespace WpfHello
{
    public partial class MyWindow : Window
    {
        public MyWindow()
        {
            InitializeComponent();
        }
        private bool _close;
        public new void Close()
        {
            _close = true;
            base.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_close) return;
            e.Cancel = true;
            Hide();
        }
        MainWindow wnd1 = null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wnd1 = Owner as MainWindow;
            if (wnd1 != null)
            {
                wnd1.textBlock.Text = textBox.Text;
            }
            Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            wnd1.myWin = null;
        } 
    }
}
