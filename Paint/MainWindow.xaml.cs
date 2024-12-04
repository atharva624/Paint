using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Paint
{
    public partial class MainWindow : Window
    {
        private Point previousPoint; // Store the previous point to draw a line
        private bool _isDrawing; // Flag to check if we are currently drawing
        private Line _currentLine; // To hold the current line while drawing

        public MainWindow()
        {
            InitializeComponent();
        }

    
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            DrawingCanvas.Children.Clear();
        }

        // mouse down event to start drawing
        private void DrawingCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            previousPoint = e.GetPosition(DrawingCanvas); // Get the position where the mouse was pressed
            _isDrawing = true; 
        }

       
        private void DrawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return; 

            var currentPoint = e.GetPosition(DrawingCanvas); 

           
            var selectedBrushSize = BrushSize.SelectedItem as ComboBoxItem;
            var brushSizeValue = selectedBrushSize?.Content.ToString();
            int brushSize = int.TryParse(brushSizeValue, out var size) ? size : 2; 

           
            var selectedBrushColor = BrushColor.SelectedItem as ComboBoxItem;
            string brushColor = selectedBrushColor?.Content.ToString();
            var color = Colors.Black; 
            switch (brushColor)
            {
                case "Red":
                    color = Colors.Red;
                    break;
                case "Green":
                    color = Colors.Green;
                    break;
                case "Yellow":
                    color = Colors.Yellow;
                    break;
                case "Blue":
                    color = Colors.Blue;
                    break;
                case "Black":
                    color = Colors.Black;
                    break;
            }

            // Draw a line if the mouse is moving
            _currentLine = new Line
            {
                X1 = previousPoint.X,
                Y1 = previousPoint.Y,
                X2 = currentPoint.X,
                Y2 = currentPoint.Y,
                StrokeThickness = brushSize,
                Stroke = new SolidColorBrush(color)
            };

            // Add the line to the canvas
            DrawingCanvas.Children.Add(_currentLine);

            // Update the previous point for the next drawing step
            previousPoint = currentPoint;
        }

       
        private void DrawingCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _isDrawing = false; 
        }

        private void DrawingCanvas_MouseLeave(object sender, MouseEventArgs e)
        {
            _isDrawing = false; 
        }

    
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
