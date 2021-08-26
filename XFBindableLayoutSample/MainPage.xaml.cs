using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFBindableLayoutSample
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> MyStrings { get; set; }
        public Command ClearCommand { get; set; }

        public MainPage()
        {
            InitializeComponent();

            ClearCommand = new Command(() => MyStrings.Clear());

            MyStrings = new ObservableCollection<string>
            {
                "Hey, have you",
                "Subscribed to",
                "My channel",
                "YET?!"
            };

            BindingContext = this;
        }
    }
}
