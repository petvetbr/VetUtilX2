using Android;
using CustomRenderer.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetUtilX2;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(GradientFrame), typeof(RendererGradientFrameAndroid))]
namespace CustomRenderer.Android
{
    public class RendererGradientFrameAndroid:FrameRenderer
    {
        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            SetBackgroundResource(VetUtilX2.Droid.Resource.Drawable.side_nav_bar);
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
        }
    }
}
