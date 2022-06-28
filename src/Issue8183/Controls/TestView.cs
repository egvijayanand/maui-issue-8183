namespace Issue8183.Controls
{
    public class TestView : View
    {
        public static readonly BindableProperty TextProperty
            = BindableProperty.Create(nameof(Text), typeof(string), typeof(TestView), string.Empty);

        public static readonly BindableProperty TextColorProperty
            = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(TestView), Black);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }
    }
}
