﻿using System;

namespace WpfUserControl
{
    public partial class ShowNumberControl : UserControl
    {
        public ShowNumberControl()
        {
            InitializeComponent();
        }

        //private int currNumber = 0;
        // public int CurrentNumber
        //{
        //    get { return currNumber; }
        //    set
        //    {
        //        currNumber = value;
        //        // Передаем в метку текущее значение
        //        numberDisplay.Content = CurrentNumber.ToString();
        //    }
        // }



        public int CurrentNumber
        {
            get { return (int)GetValue(CurrentNumberProperty); }
            set { SetValue(CurrentNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentNumberProperty = 
            DependencyProperty.Register("CurrentNumber", typeof(int),
                typeof(ShowNumberControl),
                new UIPropertyMetadata(100,
                    new PropertyChangedCallback(CurrentNumberChanged)),
                new ValidateValueCallback(ValidateCurrentNumber));

        public static bool ValidateCurrentNumber(object value)
        {
            if (Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) <= 500)
                return true;
            else
                return false;
        }

        private static void CurrentNumberChanged(DependencyObject depObj,
DependencyPropertyChangedEventArgs args)
        {
            ShowNumberControl s = (ShowNumberControl)depObj;
            Label theLabel = s.numberDisplay;
            theLabel.Content = args.NewValue.ToString();
        }

    }
}
