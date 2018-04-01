﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hvac.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public HomeMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new HomeMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        public void OnMenuItemSelected(object sender, EventArgs e)
        {

        }
        class HomeMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomeMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public HomeMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<HomeMasterDetailPageMenuItem>(new[]
                {                    
                    new HomeMasterDetailPageMenuItem { Id = 0, Title = "Service Records" },
                    new HomeMasterDetailPageMenuItem { Id = 1, Title = "Reference Documents" },
                    new HomeMasterDetailPageMenuItem { Id = 2, Title = "Calculations" },                    
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}