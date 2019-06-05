using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ArconClientPort
{
    public class NotificationUnBoldItemSelectTrigger : TriggerAction<TextCell>
    {
        protected override void Invoke(TextCell notification)
        {
            double result;
            bool isValid = Double.TryParse(notification.Text, out result);
            notification.TextColor = isValid ? Color.Default : Color.Gray;
        }
    }
}
