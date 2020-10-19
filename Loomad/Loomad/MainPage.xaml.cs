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
        {
        }

        private async void Hide_Button_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("показать", "скрыть", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
        }

    }
}
