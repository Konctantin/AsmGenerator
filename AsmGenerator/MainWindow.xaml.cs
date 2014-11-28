using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using MemoryModule.FASM;

namespace AsmGenerator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush baseColor;
        public MainWindow()
        {
            InitializeComponent();

            cbMode.SelectedValue = MemoryModule.FASM.FasmMode.Use32;
            baseColor = tbStatus.Foreground;

            cbOutMode.SelectedValue = OutputMode.Default;
        }

        private void CommandBinding_Run_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            tbStatus.Foreground = baseColor;
            tbOutput.Clear();

            var str = "";
            if (cbMode.SelectedIndex > -1)
                str += "use" + (int)(FasmMode)cbMode.SelectedValue + "\n";
            if (!string.IsNullOrWhiteSpace(tbOrg.Text))
                str += "org " + tbOrg.Text + "\n";

            str += tbInput.Text;

            try
            {
                var bytes = Fasm.Assemble(str);

                if (bytes.Length > 0)
                {
                    if ((OutputMode)cbOutMode.SelectedValue == OutputMode.Default)
                        tbOutput.Text = string.Join(" ", bytes.Select(b => b.ToString("X2")));

                    else if ((OutputMode)cbOutMode.SelectedValue == OutputMode.ByteArray)
                        tbOutput.Text = string.Join(", ", bytes.Select(b => "0x" + b.ToString("X2")));

                    else if ((OutputMode)cbOutMode.SelectedValue == OutputMode.FullCSharpArray)
                        tbOutput.Text = "var asm = new byte[] { " + string.Join(", ", bytes.Select(b => "0x" + b.ToString("X2"))) + " };";

                    tbStatus.Text = "OK";
                }
            }
            catch (Exception ex)
            {
                tbStatus.Foreground = Brushes.Red;
                tbStatus.Text = ex.Message;
            }
        }
    }
}
