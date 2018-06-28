using Xamarin.Forms;

namespace FrameSample
{
    public class CircularStack : Xamarin.Forms.StackLayout
    {
        public static readonly BindableProperty CornerRaidusProperty =
              BindableProperty.Create<CircularStack, float>(x => x.CornerRadius, 0);

        public float CornerRadius
        {
            get { return (float)GetValue(CornerRaidusProperty); }
            set { SetValue(CornerRaidusProperty, value); }
        }
    }
}
