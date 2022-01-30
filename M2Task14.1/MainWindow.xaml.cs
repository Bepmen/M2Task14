using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M2Task14._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;
        
        public MainWindow()
        {
            InitializeComponent();
           
            products = new ObservableCollection<Product>();

            products.Add(new Product()
            {
                Name = "Сыр",
                Price = 250,
                Image = "Data/cheese.png",
                Type = ProductTypes.Food
            });
            
            products.Add(new Product()
            {
                Name = "Пароварка",
                Price = 1320,
                Image = "Data/steam_cooker.png",
                Type = ProductTypes.Appliances
            });

            products.Add(new Product()
            {
                Name = "Мясо",
                Price = 250,
                Image = "Data/meat.png",
                Type = ProductTypes.Food
            });
            
            products.Add(new Product()
            {
                Name = "Тостер",
                Price = 1320,
                Image = "Data/toaster.png",
                Type = ProductTypes.Appliances
            });

            lstBox.ItemsSource = products;
        }
    }
}
