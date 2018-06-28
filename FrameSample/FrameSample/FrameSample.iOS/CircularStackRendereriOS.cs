using FrameSample;
using FrameSample.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircularStack), typeof(CircularStackRendereriOS))]
namespace FrameSample.iOS
{
    public class CircularStackRendereriOS : VisualElementRenderer<StackLayout>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<StackLayout> e)
        {
            base.OnElementChanged(e);
            if (Element == null)
                return;

            var element = (CircularStack)Element;

            Layer.CornerRadius = element.CornerRadius;
            Layer.BorderWidth = 1;
            Layer.BorderColor = element.BackgroundColor.ToCGColor();
            Layer.ShadowColor = Color.LightSlateGray.ToCGColor();
        }
    }
}
