using System;
using System.Windows.Controls;
using System.Windows.Interactivity;
using bindingExample;
using System.Windows.Input;

namespace bindingExample {

    public class PressNumPadButton : Behavior<UserControl> {

        protected override void OnAttached() {

            AssociatedObject.PreviewKeyUp += AssociatedObject_onPreviewKeyUp;

        }

        private void AssociatedObject_onPreviewKeyUp(object sender, KeyEventArgs e) {

       

            switch (e.Key)
            {
                case Key.NumPad1:

                    break;
                   


            }
           

        }

        protected override void OnDetaching() {

            AssociatedObject.PreviewKeyUp -= AssociatedObject_onPreviewKeyUp;
            

        }
    }
}
