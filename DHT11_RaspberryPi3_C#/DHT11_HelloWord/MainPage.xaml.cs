// Copyright (c) Microsoft. All rights reserved.
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TN
{
    public sealed partial class MainPage : Page
    {
        Callant.CharacterLCD lcd = null;
        public MainPage()
        {
            InitializeComponent();
            Unloaded += MainPage_Unloaded;

            lcd = new Callant.CharacterLCD();
            lcd.ClearLCD();
            lcd.WriteLCD("LCD 16x2 - TN\nWindows IoT Core");
        }

        private void MainPage_Unloaded(object sender, RoutedEventArgs e)
        {
            lcd.Dispose();
        }
    }
}