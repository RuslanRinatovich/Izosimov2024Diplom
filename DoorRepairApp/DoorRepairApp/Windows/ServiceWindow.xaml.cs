using DoorRepairApp.Entities;
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
using System.Windows.Shapes;

namespace DoorRepairApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для ServiceWindow.xaml
    /// </summary>
    public partial class ServiceWindow : Window
    {
        public Service currentItem { get; private set; }


        public ServiceWindow(Service p)
        {
            InitializeComponent();
            currentItem = p;
            DataContext = currentItem;
            ComboCategory.ItemsSource = DataEntities.GetContext().Categories.ToList();
        }


        private StringBuilder CheckFields()
        {
            StringBuilder s = new StringBuilder();
            if (TbName.Text == "")
                s.AppendLine("Укажите название");
            if (ComboCategory.SelectedIndex == -1)
                s.AppendLine("Выберите категорию");
            return s;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder _error = CheckFields();
            // если ошибки есть, то выводим ошибки в MessageBox
            // и прерываем выполнение 
            if (_error.Length > 0)
            {
                MessageBox.Show(_error.ToString());
                return;
            }
            currentItem.Title = TbName.Text;
            currentItem.Category = ComboCategory.SelectedItem as Category;
            this.DialogResult = true;
        }

    }
}