using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CustomControlApp.ViewModels
{
    internal class RotationManager : DependencyObject
    {
        public static readonly DependencyProperty AngleProperty = DependencyProperty.RegisterAttached("Angle",
           typeof(double), typeof(RotationManager), new UIPropertyMetadata(0.0, OnAngleChanged));
        public static double GetAngle(DependencyObject d) => (double)d.GetValue(AngleProperty); 
        public static void SetAngle(DependencyObject d, double value) => d.SetValue(AngleProperty, value);
        private static void OnAngleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var Element = obj as UIElement;
            if (Element != null)
            {
                Element.RenderTransformOrigin = new Point(.5, .5);
                Element.RenderTransform = new RotateTransform((double)e.NewValue);
            }
        }
        
    }   
}
