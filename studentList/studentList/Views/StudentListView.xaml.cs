using studentList.Model;
using studentList.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace studentList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentListView : ContentPage
    {
        public List<string> Items { get; set; }

        public StudentListView()
        {
            InitializeComponent();
            StudentViewModel sm = new StudentViewModel();
           
            
            
            
            
            // Connecting context of this page to the our View Model class

            BindingContext = sm; 

    }

        
    }
}
