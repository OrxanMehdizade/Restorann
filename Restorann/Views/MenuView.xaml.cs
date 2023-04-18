using Restorann.Models;
using System;
using System.Collections.Generic;
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

namespace Restorann.Views
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        public List<Restoran>? restoranlar { get; set; }
        //public ICommand ColorCommand { get; set; }
        public MenuView()
        {
            InitializeComponent();

            restoranlar = new List<Restoran>();

            restoranlar.Add(new Restoran() { Name = "Toyuq Kababı -> Qiymet: ", Price = 4.99, ImageUrl = "https://azerbaijan.az/uploads/news-files/melumatlar/medeniyyet/Kulinariya/%D0%9D%D0%BE%D0%B2%D0%B0%D1%8F%D0%9F%D0%B0%D0%BF%D0%BA%D0%B0/23923974535_0108380f28_b.jpg" });
            restoranlar.Add(new Restoran() { Name = "Quzu Kababı -> Qiymet: ", Price = 10.99, ImageUrl = "https://a.d-cd.net/1-AAAgHHVuA-1920.jpg" });
            restoranlar.Add(new Restoran() { Name = "Lülə Kabab -> Qiymet: ", Price = 7.99, ImageUrl = "https://pbs.twimg.com/media/CsOCLodWYAAZfqw?format=jpg" });
            restoranlar.Add(new Restoran() { Name = "Çoban Salatı -> Qiymet: ", Price = 3.99, ImageUrl = "https://e7.pngegg.com/pngimages/346/855/png-clipart-doner-kebab-turkish-cuisine-shawarma-meze-salad-leaf-vegetable-food.png" });
            restoranlar.Add(new Restoran() { Name = "Qarışıq tərəvəz salatı -> Qiymet: ", Price = 5.99, ImageUrl = "https://banner2.cleanpng.com/20200716/vil/transparent-salad-5f101c0fcc0ba1.9004243415948912798358.jpg" });
            restoranlar.Add(new Restoran() { Name = "Mimoza Salatı -> Qiymet: ", Price = 4.99, ImageUrl = "https://w7.pngwing.com/pngs/268/805/png-transparent-mimosa-salad-recipe-vegetarian-cuisine-dish-salad-food-recipe-ru.png" });
            restoranlar.Add(new Restoran() { Name = "Colla 1L -> Qiymet: ", Price = 1.49, ImageUrl = "https://e7.pngegg.com/pngimages/488/437/png-clipart-coca-cola-fizzy-drinks-diet-coke-sprite-ice-cola-cola-beverage-can.png" });
            restoranlar.Add(new Restoran() { Name = "Sprite 1L -> Qiymet: ", Price = 1.49, ImageUrl = "https://e7.pngegg.com/pngimages/878/236/png-clipart-fizzy-drinks-sprite-lemon-lime-drink-pepsi-mineral-water-sprite-logo-mineral-water.png" });
            restoranlar.Add(new Restoran() { Name = "Fanta 1L -> Qiymet: ", Price = 1.49, ImageUrl = "https://e7.pngegg.com/pngimages/651/449/png-clipart-fanta-fizzy-drinks-orange-soft-drink-coca-cola-diet-coke-fanta-food-orange.png" });
            restoranlar.Add(new Restoran() { Name = "Stolichnaya Vodka 1L -> Qiymet: ", Price = 43.99, ImageUrl = "https://e7.pngegg.com/pngimages/157/636/png-clipart-vodka-vodka.png" });
            restoranlar.Add(new Restoran() { Name = "Lchaım Vodka 1L -> Qiymet: ", Price = 45.99, ImageUrl = "https://w7.pngwing.com/pngs/77/158/png-transparent-liqueur-wine-cocktail-non-alcoholic-drink-summer-drinks-distilled-beverage-cocktail-wine.png" });
            restoranlar.Add(new Restoran() { Name = "Qırmızı Şərab 1L -> Qiymet: ", Price = 49.99, ImageUrl = "https://e7.pngegg.com/pngimages/998/236/png-clipart-lambrusco-liqueur-red-wine-champagne-wine-glass-wine-glass.png" });



            DataContext = this;

            //ShowCommandd = new BasketCommand(ExecuteShowCommandd, CanExecuteShowCommandd);
            //ColorCommand = new ColorCommand(ExecuteColorCommand, CanExecuteColorCommand);
        }
        public MainView mainView { get; set; }
        public Restoran restoran { get; set; }
        //void ExecuteShowCommandd(object? parameter) => sebet.Text += restoran.Price;
        //bool CanExecuteShowCommandd(object? parameter) => true;

        double? FinalDebt = 0;
        private void Button_Click_sebete(object sender, RoutedEventArgs e)
        {
            foreach (var itme in restoranlar)
            {
                FinalDebt += itme.Price ?? 0;
            }
            sebet.Text = FinalDebt.ToString();

        }

        private void Button_Click_save_menu(object sender, RoutedEventArgs e)
        {
            if (mainView.count == 1)
            {
                if (mainView.MS1.Background != Brushes.Red)
                {
                    mainView.MS1.Background = Brushes.Red;
                }
                else
                    MessageBox.Show("Sorry 1st table reserved");
            }
        }
    }
}
