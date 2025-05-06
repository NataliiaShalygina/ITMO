using System;

namespace WpfHello
{
    class CustomCommands
    {
        public static RoutedUICommand Launch { get; }
        static CustomCommands()
        {
            InputGestureCollection myInputGesture = new InputGestureCollection();
            myInputGesture.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            Launch = new RoutedUICommand("Запуск", "Launch", typeof(CustomCommands), myInputGesture);
        }
    }
}
