using Avalonia.Controls;
using Avalonia.Logging;
using System;
using System.Diagnostics;

namespace MPPI
{
    public partial class MainWindow : Window
    {
        private string Mode { get; set; } = "ZeroInstall";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Mode = (sender as RadioButton).Name ?? "null";
        }

        private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Debug.WriteLine(Mode);
        }
    }
}