using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Interactivity;

namespace WpfControlStyle
{
    public class ButtonBehavior : Behavior<UIElement>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.MouseEnter += new MouseEventHandler(AssociatedObject_MouseEnter);
            this.AssociatedObject.MouseLeave += new MouseEventHandler(AssociatedObject_MouseLeave);
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.MouseLeave -= new MouseEventHandler(AssociatedObject_MouseEnter);
            this.AssociatedObject.MouseLeave -= new MouseEventHandler(AssociatedObject_MouseLeave);
        }

        private void AssociatedObject_MouseEnter(object sender, MouseEventArgs e)
        {
            Border border = sender as Border;
            if (border != null)
                border.Background = new SolidColorBrush(Color.FromArgb(0xff, 0xBB, 0xDD, 0xff));
        }
        private void AssociatedObject_MouseLeave(object sender, MouseEventArgs e)
        {
            Border border = sender as Border;
            if (border != null)
                border.Background = new SolidColorBrush(Color.FromArgb(0xff, 0xDD, 0xEE, 0xFF));
        }
    }

    public class ButtonBehavior2 : Behavior<UIElement>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.MouseEnter += new MouseEventHandler(AssociatedObject_MouseEnter);
            this.AssociatedObject.MouseLeave += new MouseEventHandler(AssociatedObject_MouseLeave);
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.MouseLeave -= new MouseEventHandler(AssociatedObject_MouseEnter);
            this.AssociatedObject.MouseLeave -= new MouseEventHandler(AssociatedObject_MouseLeave);
        }

        private void AssociatedObject_MouseEnter(object sender, MouseEventArgs e)
        {
            Border border = sender as Border;
            if (border != null)
                border.Background = new SolidColorBrush(Color.FromArgb(0xff, 0x50, 0xA1, 0xF1));
        }
        private void AssociatedObject_MouseLeave(object sender, MouseEventArgs e)
        {
            Border border = sender as Border;
            if (border != null)
                border.Background = new SolidColorBrush(Colors.Transparent);
        }
    }
}
