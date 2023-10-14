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

namespace HW_23._09._23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<ListItem> list = new List<ListItem>
            { 
            //{D:\2.ШАГ Уроки\3.Пары\2. 2 семестр ООП\37. 23.09.23\HW - 23.09.23\HW - 23.09.23\Resources\turtle.jpg
                new ListItem{Text="Turtle", ImageSource=new BitmapImage(new Uri("pack://application:,,,/Resources/turtle.jpg"))},
                new ListItem{Text="Dog", ImageSource=new BitmapImage(new Uri("pack://application:,,,/Resources/dog.jpg")) },
                new ListItem{Text="Sunset", ImageSource=new BitmapImage(new Uri("pack://application:,,,/Resources/sunset.jpg"))},
                new ListItem{Text="Moon", ImageSource=new BitmapImage(new Uri("pack://application:,,,/Resources/moon.jpg"))},
                new ListItem{Text="Bridge", ImageSource=new BitmapImage(new Uri("pack://application:,,,/Resources/bridge.jpg"))}
            };
            imageListBox.ItemsSource = list;
        }
        private void imageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (imageListBox.SelectedItem is ListItem selectedItem)
            {
                // Здесь мы устанавливаем источник изображения в Image
                itemImage.Source = selectedItem.ImageSource;
            }
        }
    }

    public class ListItem
    {
        public string Text { get; set; }
        public BitmapImage ImageSource { get; set; }
    }

}
