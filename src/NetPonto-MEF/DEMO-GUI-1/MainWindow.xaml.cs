using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DemoGui1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Int64 pvalue;
        private String poperation;
        private bool fromOper = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Clean_Click(object sender, RoutedEventArgs e)
        {
            DemoDisplay.Text = "" + 0;
        }

        public void Equal_Click(object sender, RoutedEventArgs e)
        {
            
            var t = Int64.Parse(DemoDisplay.Text);
            if(poperation.Equals("+"))
                pvalue = pvalue + t;
            else if(poperation.Equals("-"))
                pvalue = pvalue - t;
            else if(poperation.Equals("*"))
                pvalue = pvalue * t;            
            else if(poperation.Equals("/"))
                pvalue = pvalue / t;
            DemoDisplay.Text = "" + pvalue;
            fromOper = true;
        }

        public void Operation_Click(object sender, RoutedEventArgs e)
        {
            if (poperation == null) poperation = ((Button)sender).CommandParameter.ToString();
            var t = Int64.Parse(DemoDisplay.Text);
            if (poperation.Equals("+"))
                pvalue = pvalue + t;
            else if (poperation.Equals("-"))
                pvalue = pvalue - t;
            else if (poperation.Equals("*"))
                pvalue = pvalue * t;
            else if (poperation.Equals("/"))
                pvalue = pvalue / t;
            poperation = ((Button)sender).CommandParameter.ToString();
            DemoDisplay.Text = "" + pvalue;
            fromOper = true;
        }

        public void Clear_Click(object sender, RoutedEventArgs e)
        {
            DemoDisplay.Text = ""+0;
            pvalue = 0;
            fromOper = false;
            poperation = "";
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (fromOper) DemoDisplay.Text = "" + 0;
            var v = Int64.Parse(DemoDisplay.Text);
            var b = Int64.Parse(((Button)sender).CommandParameter.ToString());
            DemoDisplay.Text =""+(v * 10 + b);
            fromOper = false;
        }
    }
}
