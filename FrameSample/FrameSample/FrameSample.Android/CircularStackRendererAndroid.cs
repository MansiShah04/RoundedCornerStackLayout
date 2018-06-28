using FrameSample;
using FrameSample.Droid;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(CircularStack), typeof(CircularStackRendererAndroid))]
namespace FrameSample.Droid
{
    public class CircularStackRendererAndroid : VisualElementRenderer<StackLayout>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<StackLayout> e)
        {
            base.OnElementChanged(e);

            if (Element == null)
                return;

            var element = (CircularStack)Element;

            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(element.CornerRadius);
            gd.SetStroke(1, e.NewElement.BackgroundColor.ToAndroid());
            gd.SetColor(e.NewElement.BackgroundColor.ToAndroid());

            SetBackgroundDrawable(gd);
        }
    }
}