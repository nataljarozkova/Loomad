using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Loomad
{
    public partial class MainPage : TabbedPage
    {
        Button btn;

        public MainPage()
        { btn = new Button();
            btn.Clicked += Btn_Clicked1;
            StackLayout stackLayout = new StackLayout()

            {
                Children = { btn }
            };stackLayout.Orientation = StackOrientation.Vertical;
            }
        private async void Btn_Clicked1(object sender, EventArgs e)
        {

            string answer = await DisplayActionSheet("выьбрать животное", "отменить", null);
            if (answer == "")

        {
            InitializeComponent();
        }
        }
    }
}
