using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFDemo.ExtensionButton
{
    public class ExtensionButton : Button
    {
        public int ClickCount
        {
            get { return (int)GetValue(ClickCountProperty); }
            set { SetValue(ClickCountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClickCount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClickCountProperty =
            DependencyProperty.Register("ClickCount", typeof(int), typeof(ExtensionButton), new PropertyMetadata(0));


        public string CustomDateTime
        {
            get { return (string)GetValue(CustomDateTimeProperty); }
            set { SetValue(CustomDateTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DateTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomDateTimeProperty =
            DependencyProperty.Register("CustomDateTime", typeof(string), typeof(ExtensionButton), new PropertyMetadata(System.DateTime.UtcNow.ToString()));



        /// <summary>
        /// 
        /// </summary>
        public ExtensionButton() 
        {
            // nothing to do.

            _ = Task.Run(() =>
            {
                while (true)
                {   
                    try
                    {
                        Dispatcher.Invoke(() =>
                        {
                            var temp = (int)GetValue(ClickCountProperty); ;
                            SetValue(ClickCountProperty, ++temp);

                            SetValue(CustomDateTimeProperty, System.DateTime.UtcNow.ToString());
                        });

                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Task.Delay(2000);

                }
            });
        }
    }
}
