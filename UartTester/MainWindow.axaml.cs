using System.IO.Ports;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace UartTester;

public partial class MainWindow : Window
{
    private SerialPort _serialPort = new SerialPort();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ComportRefresh(object? sender, RoutedEventArgs e)
    {
        ComportComboBox.Items.Clear();
        foreach (string port in SerialPort.GetPortNames())
        {
            ComportComboBox.Items.Add(port);
        }
    }
}