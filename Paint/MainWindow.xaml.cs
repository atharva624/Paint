using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            DrawingCanvas.Children.Clear();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DrawingCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            P1 = e.GetPosition(DrawingCanvas);
            e.GetPosition(this);

        }

        Point P1;
        private void DrawingCanvas_MouseLeave(object sender, MouseEventArgs e)
        {
            var P2 = e.GetPosition(DrawingCanvas);
            DrawingCanvas.Children.Add(new Line()
            {
                X1 = P1.X,
                Y1 = P1.Y,
                X2 = P2.X,
                Y2 = P2.Y,
                StrokeThickness = 3,
                Stroke = new SolidColorBrush { Color = Colors.Blue }
            });

            //Line line = new Line();
            //Thickness thickness = new Thickness(101, -11, 362, 250);
            //line.Margin = thickness;
            //line.Visibility = System.Windows.Visibility.Visible;
            //line.StrokeThickness = 4;
            //line.Stroke = System.Windows.Media.Brushes.Black;
            //line.X1 = 10;
            //line.X2 = 40;
            //line.Y1 = 70;
            //line.Y2 = 70;

            //DrawingCanvas.Children.Add(line);

        }

      


    }
}