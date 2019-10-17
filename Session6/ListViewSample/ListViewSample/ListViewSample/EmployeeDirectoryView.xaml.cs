using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeDirectoryView : ContentPage
    {
        public EmployeeDirectoryView()
        {
            InitializeComponent();
            var empList = DataSource.GetList();

            var groupedData =
                empList.OrderBy(e => e.FirstName)
                    .GroupBy(e => e.FirstName[0].ToString())
                    .Select(e => new ObservableGroupCollection<string, Employee>(e))
                    .ToList();

            BindingContext = new ObservableCollection<ObservableGroupCollection<string, Employee>>(groupedData);
        }
    }
}