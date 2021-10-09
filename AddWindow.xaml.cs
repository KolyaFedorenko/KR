using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        MainWindow mw = (MainWindow)Application.Current.MainWindow;
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
                SaveImage();
                context.SaveChanges();
                mw.ShowTable();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
            }

        }
        private void SaveImage()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files: *.jpg, *png|*.jpg;*.png";
            openFile.ShowDialog();
            if (openFile.FileName.Length !=0)
            {
                string nameFile = openFile.FileName;
                byte[] image = File.ReadAllBytes(nameFile);
                var reg = (Equipment)this.DataContext;
                reg.Схема = image;
                Scheme.Source = new BitmapImage(new Uri(nameFile));
            }
        }
    }
}
