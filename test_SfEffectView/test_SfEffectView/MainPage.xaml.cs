using Syncfusion.XForms.EffectsView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test_SfEffectView
{
    public partial class MainPage : ContentPage
    {

        MainPage_ViewModel lc_MainPage_ViewModel = null;

        public MainPage()
        {
            InitializeComponent();

            lc_MainPage_ViewModel = new MainPage_ViewModel();

            this.BindingContext = lc_MainPage_ViewModel;
        }


        private void SfEffectsView_AnimationCompleted(object sender, EventArgs e)
        {
            try
            {
                var effectsView = sender as SfEffectsView;

                Item tmp_Item = effectsView.BindingContext as Item;

                Device.BeginInvokeOnMainThread(async () =>
                {
                    await DisplayAlert("Alert", string.Format("Item name {0}", tmp_Item.Name), "OK");
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
