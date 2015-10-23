using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Windows_10_IoT_Core___UltraSonic_Distance_Mapper__UWP_.Library
{
    public static class DistanceMapper
    {
        private static Grid _Grid;
        private static Ellipse _Ellipse;
        private static Line _Line;
        private static CompositeTransform _CompositeTransform;
        private static RowDefinition _RowDefination;

        public static Grid GetMapper(double Angle, int Distance)
        {
            _CompositeTransform = new CompositeTransform();
            _CompositeTransform.Rotation = Angle;
            
            _Grid = new Grid();
            _Grid.RenderTransform = _CompositeTransform;

            /* <RowDefination Height="Auto"/> */
            _RowDefination = new RowDefinition();
            _RowDefination.Height = GridLength.Auto;
            _Grid.RowDefinitions.Add(_RowDefination);

            /* <RowDefination Height="*"/> */
            _RowDefination = new RowDefinition();
            _Grid.RowDefinitions.Add(_RowDefination);

            _Grid.HorizontalAlignment = HorizontalAlignment.Center;
            _Grid.VerticalAlignment = VerticalAlignment.Bottom;
            
            _Grid.RenderTransformOrigin = new Windows.Foundation.Point(0, 1);

            _Ellipse = new Ellipse();
            _Ellipse.Height = 2;
            _Ellipse.Width = 2;
            _Ellipse.RenderTransformOrigin = new Windows.Foundation.Point(0, 0);
            _Ellipse.Margin = new Thickness(-2, 0, -2, 0);

            if(Distance < 50)
            {
                _Ellipse.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            }
            else if(Distance < 100)
            {
                _Ellipse.Fill = new SolidColorBrush(Color.FromArgb(255, 200, 100, 0));
            }
            else
            {
                _Ellipse.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }

            _Grid.Children.Add(_Ellipse);

            _Line = new Line();
            Grid.SetRow(_Line, 1);
            _Line.X1 = 0;
            _Line.X2 = 0;
            _Line.Y1 = Distance + 3;
            _Line.Y2 = 0;
            _Line.StrokeThickness = 1;
            _Line.Stroke = _Ellipse.Fill;

            _Grid.Children.Add(_Line);

            return _Grid;
        }

    }
}
