using Issue8183.Controls;
using Issue8183.Renderers;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;
using System.ComponentModel;

using TPlatformView = Microsoft.UI.Xaml.Controls.TextBlock;

[assembly: ExportRenderer(typeof(TestView), typeof(TestViewRenderer))]

namespace Issue8183.Renderers
{
    public class TestViewRenderer : ViewRenderer<TestView, TPlatformView>
    {
        public TestViewRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TestView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Cleanup
            }

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(new TPlatformView());
                }

                // Initialization
                UpdateText();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == TestView.TextProperty.PropertyName)
            {
                UpdateText();
            }
        }

        private void UpdateText()
        {
            if (Control != null)
            {
                Control.Text = Element?.Text;
            }
        }
    }
}
