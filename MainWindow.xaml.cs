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

namespace PRKR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PRKRFEntities context;

        public MainWindow()
        {
            InitializeComponent();
            context = new PRKRFEntities();
            ShowTable();
        }
        public void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newEquipment = new Equipment();
            context.Equipment.Add(newEquipment);
            var win = new AddWindow(context, newEquipment);
            win.ShowDialog();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var row = DataGridRegistrations.SelectedItem as Equipment;
            if (row==null)
            {
                MessageBox.Show("Выберите строку для удаления");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Удалить эту строку данных?", "Подтверждение удаления", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result== MessageBoxResult.Yes)
            {
                context.Equipment.Remove(row);
                context.SaveChanges();
                ShowTable();
            }
        }

        public void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btnEdit = sender as Button;
            var editEquipment = btnEdit.DataContext as Equipment;
            var win = new AddWindow(context, editEquipment);
            win.ShowDialog();
        }

        public void ShowTable()
        {
            DataGridRegistrations.ItemsSource = context.Equipment.ToList();
        }
    }
}
