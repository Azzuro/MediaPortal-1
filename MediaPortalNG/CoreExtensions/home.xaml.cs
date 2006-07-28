// #define USE_VISUALBRUSH

using MediaPortal;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;

namespace MediaPortal
{
    public partial class HomeExtension :  Page
    {


        private ScrollViewer sv;
        public string _skinMediaPath;
        private bool viewThumbNails = true;
        private Core _core;
        public HomeExtension(ResourceDictionary dict)
        {
            InitializeComponent();
            this.ShowsNavigationUI = true;
            this.Opacity = 0.0f;
            this.Loaded += new RoutedEventHandler(HomeExtension_Loaded);
           
            this.Height = 608;
            this.Width = 720;
            _core = (Core)this.Parent;

            ApplyLanguage("German");
        }

        private void ApplyLanguage(string lang)
        {
            System.Xml.XmlDocument langFile = new System.Xml.XmlDocument();
            langFile.Load(System.IO.Directory.GetCurrentDirectory()+@"\language\"+lang+@"\strings.xml");
            System.Xml.XmlNode node = langFile.GetElementsByTagName("strings").Item(0);
            if (node != null)
            {
                for (int n = 0; n < 9999; n++)
                {
                   object o=this.FindName("id" + n.ToString());
                    if (o != null)
                    {
                      
                         if(o.ToString().StartsWith("System.Windows.Controls.TextBlock"))
                         {

                             ((TextBlock)o).Text = Core.GetLocalizedString("id", ((TextBlock)o).Text, "value", node);
                         }

                         if (o.ToString().StartsWith("System.Windows.Controls.Button"))
                         {
                             string tag = ((Button)o).Tag.ToString();
                             string label=Core.SplitElementTag(tag, "labelNum","##metadata");
                             ((Button)o).Content = Core.GetLocalizedString("id", label, "value", node);
                         }
                         if (o.ToString().StartsWith("System.Windows.Controls.CheckBox"))
                         {
                             string tag = ((CheckBox)o).Tag.ToString();
                             string label = Core.SplitElementTag(tag, "labelNum", "##metadata");
                             ((CheckBox)o).Content = Core.GetLocalizedString("id", label, "value", node);
                         }
                    }
                }
                int count=VisualTreeHelper.GetChildrenCount(this);
                int a = 0;
            }

        }

        void HomeExtension_Loaded(object sender, RoutedEventArgs e)
        {

            _skinMediaPath = System.IO.Directory.GetCurrentDirectory() + @"\BlueTwo\BlueTwo\Media\";
            DoubleAnimation anim = new DoubleAnimation(1.0f, new Duration(new TimeSpan(0, 0, 0, 0, 500)));
            this.BeginAnimation(Page.OpacityProperty, anim);

            //
            lv1.Items.Add("frodo");
            lv1.Items.Add("dman");
            lv1.Items.Add("mpod");
            lv1.Items.Add("agree");
            lv1.Items.Add("mediaportal");
            lv1.Items.Add("Annie Lenox");
            lv1.Items.Add("What the heck");
            lv1.Items.Add("some numbers:");
            lv1.Items.Add("1");
            lv1.Items.Add("2");
            lv1.Items.Add("3");
            lv1.Items.Add("4");
            lv1.Items.Add("5");
            lv1.Items.Add("6");
            lv1.Items.Add("7");
            lv1.Items.Add("8");
            lv1.Items.Add("9");
            lv1.Items.Add("10");
            lv1.Items.Add("11");
            lv1.Items.Add("12");
            lv1.Items.Add("13");
            lv1.Items.Add("14");
            lv1.Items.Add("15");
            lv1.Items.Add("16");



        }

        public void Launch_Wizard(object sender,RoutedEventArgs e)
        {
        }
        public void MPNG(object sender, RoutedEventArgs e)
        {
            if (lv1 == null)
                return;
            lv1.Style = null;

            if (viewThumbNails == true)
            {
                lv1.Style = (Style)lv1.FindResource("GUIListControl");
                lv1.ApplyTemplate();
                viewThumbNails = false;
            }
            else
            {
                lv1.Style = (Style)lv1.FindResource("GUIThumbnailControl");
                lv1.ApplyTemplate();
                viewThumbNails = true;
            }
            try
            {
                // example to get the elements from an style and apply the template
                // to access its elements by name
                int c = VisualTreeHelper.GetChildrenCount(lv1);
                Border b = (Border)VisualTreeHelper.GetChild(lv1, 0);
                sv = (ScrollViewer)VisualTreeHelper.GetChild(b, 0);
                if (c > 0)
                {
                    sv.ApplyTemplate();
                    TextBlock tb = (TextBlock)sv.Template.FindName("objCount", sv);
                    if(tb!=null)
                        tb.Text=lv1.Items.Count.ToString()+" objects";
                }
            }
            catch
            {
            }

        }
 
    }
}