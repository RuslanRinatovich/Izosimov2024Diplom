﻿using DoorRepairApp.Entities;
using DoorRepairApp.Windows;
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

namespace DoorRepairApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServicesCataloguePage.xaml
    /// </summary>
    public partial class ServicesCataloguePage : Page
    {
        int _itemcount = 0;
        int _allitemcount = 0;
        int _pagenumber = 0;
        int _pagecount = 0;
        int n = 20;

        List<Service> services;

        public ServicesCataloguePage()
        {
            InitializeComponent();
            // скрываем кнопку Изменить приоритет на

            // загрузка данных в combobox + добавление дополнительной строки
            var categories = DataEntities.GetContext().Categories
                .OrderBy(p => p.Title).ToList();
            categories.Insert(0, new Category
            {
                Title = "Все типы"
            }
            );
            ComboType.ItemsSource = categories;
            ComboType.SelectedIndex = 0;
        }


        // Создание списка страниц
        public void InitializeListBoxPages()
        {
            // очишаем список
            ListBoxPageCount.Items.Clear();
            // узнаем количество страниц нужное для отображения данного количества записей
            _pagecount = _itemcount / n;
            if (_itemcount % n != 0)
                _pagecount++;
            // добавляем в Листбокс элементы - номера страниц
            for (int i = 1; i <= _pagecount; i++)
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Content = i.ToString();

                ListBoxPageCount.Items.Add(itm);
            }

        }

        // подгрузка данных из БД об агентах
        void LoadData()
        {
            DataEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            // загрузка данных в listview сортируем по названию

            services = DataEntities.GetContext().Services.OrderBy(p => p.Title).ToList();
            // отображение количества записей
            _allitemcount = services.Count;
            _itemcount = _allitemcount;

            _pagenumber = 1;
            InitializeListBoxPages();

            // Метод GetRange позволяет выбрать из списка данных элементы 
            // Создает неполную копию диапазона элементов исходного списка List<T>.
            // GetRange (int index, int count);
            // index -  Отсчитываемый от нуля индекс списка List<T>, с которого начинается диапазон.
            // count -  Число элементов в диапазоне
            // если указать count за размером списка будет ошибка.
            int k = services.Count - (_pagenumber - 1) * n;
            if (k < 10)
                ListBoxProducts.ItemsSource = services.GetRange((_pagenumber - 1) * n, k);
            else
                ListBoxProducts.ItemsSource = services.GetRange((_pagenumber - 1) * n, n);

            TextBlockCount.Text = $" Результат запроса: {_itemcount} записей из {_allitemcount}";
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //обновление данных после каждой активации окна
            if (Visibility == Visibility.Visible)
            {
                LoadData();
            }
        }
        // Поиск агентов, которые содержат данную поисковую строку в имени или в почте или в телефоне
        private void TBoxSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }
        // Поиск агентов конкретного типа
        private void ComboTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }
        /// <summary>
        /// Метод для фильтрации и сортировки данных
        /// </summary>
        private void UpdateData()
        {
            var currentProducts =
                DataEntities.GetContext().Services.OrderBy(p => p.Title).ToList();
            // выбор только тех агентов, которые принадлежат данному типу
            if (ComboType.SelectedIndex > 0)
                currentProducts = currentProducts.Where(p => p.CategoryId == (ComboType.SelectedItem as Category).Id).ToList();
            // выбор тех агентов, в названии которых есть поисковая строка
            currentProducts = currentProducts.Where(p => p.Title.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            // сортировка
            if (ComboSort.SelectedIndex >= 0)
            {
                // сортировка по возрастанию названия
                if (ComboSort.SelectedIndex == 0)
                    currentProducts = currentProducts.OrderBy(p => p.Title).ToList();
                // сортировка по убыванию названия
                if (ComboSort.SelectedIndex == 1)
                    currentProducts = currentProducts.OrderByDescending(p => p.Title).ToList();
                // сортировка по возрастанию скидки
              
                // сортировка по возрастанию минимальной стоимости
                if (ComboSort.SelectedIndex == 2)
                    currentProducts = currentProducts.OrderBy(p => p.Price).ToList();
                // сортировка по убыванию минимальной стоимости
                if (ComboSort.SelectedIndex == 3)
                    currentProducts = currentProducts.OrderByDescending(p => p.Price).ToList();
            }


            // В качестве источника данных присваиваем список данных
            // пересчитываем список страниц
            _pagenumber = 1;
            services = currentProducts;
            ListBoxProducts.ItemsSource = currentProducts;
            _itemcount = currentProducts.Count;
            InitializeListBoxPages();
            int k = services.Count - (_pagenumber - 1) * n;
            if (k < 10)
                ListBoxProducts.ItemsSource = services.GetRange((_pagenumber - 1) * n, k);
            else
                ListBoxProducts.ItemsSource = services.GetRange((_pagenumber - 1) * n, 10);
            // отображение количества записей
            TextBlockCount.Text = $" Результат запроса: {currentProducts.Count} записей из {_allitemcount}";

        }
        // сортировка агентов 
        private void ComboSortSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        // обработка выбора номера страницы которую надо отбразить
        private void ListBoxPageCount_SelectionChanged(object sender,
        SelectionChangedEventArgs e)
        {
            if (ListBoxPageCount.SelectedItems.Count == 0)
                return;
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);

            _pagenumber = Convert.ToInt32(lbi.Content);

            int k = services.Count - (_pagenumber - 1) * n;
            if (k < 10)
                ListBoxProducts.ItemsSource = services.GetRange((_pagenumber - 1) * n, k);
            else
                ListBoxProducts.ItemsSource = services.GetRange((_pagenumber - 1) * n, 10);
            TextBlockCount.Text = $" Результат запроса: {_itemcount} записей из {_allitemcount}";
        }
        //кнопки перемещения между страницами
        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            if ((_pagenumber > 1))
                _pagenumber--;
            ListBoxPageCount.SelectedIndex = _pagenumber - 1;
        }
        //кнопки перемещения между страницами
        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if ((_pagenumber < _pagecount))
                _pagenumber++;
            ListBoxPageCount.SelectedIndex = _pagenumber - 1;
        }

        // Открытие окна изменения приоритета
        private void BtnChangePriority_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    //получаем всех выделенных агентов
            //    var selectedAgents = ListBoxProducts.SelectedItems.Cast<Service>().ToList();

            //    if (selectedAgents.Count == 0) return;
            //    // получаем максимальное значение приоритета среди выделенных агентов
            //    string maxA = selectedAgents.Max(t => t.MinimalPrice).ToString();
            //    // открытие окна изменения приоритета
            //    ChangeMinimalPriceWindow window = new ChangeMinimalPriceWindow(maxA);
            //    if (window.ShowDialog() == true)
            //    {
            //        // если была нажата кнопка Изменить, меняем значение приоритета у выделенных агентов
            //        foreach (Service material in selectedAgents)
            //        {
            //            material.MinimalPrice = window.GetMinimalPrice;
            //        }
            //        // сохраняем изменения
            //        DataEntities.GetContext().SaveChanges();

            //        MessageBox.Show("Записи изменены", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            //        // загружаем измененные данные из бд
            //        int p = _pagenumber;
            //        LoadData();
            //        // применяем фильтрацию и поиск
            //        UpdateData();
            //        //ListBoxPageCount.SelectedIndex = 0;
            //        ListBoxPageCount.SelectedIndex = p - 1;
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка");
            //}
        }
        // при выделении в списке более одного агента 
        // становится доступна кнопка Изменить приоритет на
        private void ListBoxProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (ListBoxProducts.SelectedItems.Count > 1)
            //{
            //    BtnChangePriority.Visibility = Visibility.Visible;
            //}
            //else
            //{
            //    BtnChangePriority.Visibility = Visibility.Collapsed;
            //}
        }

       
        private void BtnBasket_Click(object sender, RoutedEventArgs e)
        {
            // кнопка Корзина
            NewOrderWindow newOrderWindow = new NewOrderWindow();
            newOrderWindow.ShowDialog();
            if (DoorBasket.GetCount > 0)
            {
                BtnBasket.Visibility = Visibility.Visible;
                TextBlockBasketInfo.Visibility = Visibility.Visible;
                BadgeBasketCount.Badge = DoorBasket.GetCount;
            }
            else
            {
                BadgeBasketCount.Badge = "";
                BtnBasket.Visibility = Visibility.Collapsed;
                TextBlockBasketInfo.Visibility = Visibility.Collapsed;
            }

        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            Service _selectedProduct = (sender as Button).DataContext as Service;
            ServiceBasket.AddProductInBasket(_selectedProduct);
            // отображаем кнопку и текстовое поле
            if (DoorBasket.GetCount > 0 || ServiceBasket.GetCount > 0)
            {
                BtnBasket.Visibility = Visibility.Visible;
                TextBlockBasketInfo.Visibility = Visibility.Visible;
                TextBlockBasketInfo.Text = $"В корзине {DoorBasket.GetCount + ServiceBasket.GetCount} товаров";
                BadgeBasketCount.Badge = DoorBasket.GetCount + ServiceBasket.GetCount;
            }
        }
    }
}