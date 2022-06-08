using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace test_SfEffectView
{
    public class MainPage_ViewModel
    {

        public MainPage_ViewModel()
        {

            prp_Items = new ObservableCollection<Item>();

            for (int i = 0; i < 20; i++)
            {
                Item tmp_Item = new Item();
                prp_Items.Add(tmp_Item);
            }

        }

        private ObservableCollection<Item> prp_Items;
        public ObservableCollection<Item> Items
        {
            get
            {
                return prp_Items;
            }
            set
            {
                prp_Items = value;
            }
        }

    }
}
