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

namespace PRKR
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        PRKRFEntities context;
        public AddWindow(PRKRFEntities context, Equipment newEquipment)
        {
            InitializeComponent();
            this.context = context;
            this.DataContext = newEquipment;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context.SaveChanges();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
            }

        }
    }
}
