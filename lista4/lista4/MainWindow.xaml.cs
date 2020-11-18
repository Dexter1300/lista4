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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;

namespace lista4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> listastud = null;

        public MainWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        private void InitBinding()
        {
            listastud = new List<Student>();
            try
            {
                using (var reader = new StreamReader("ListaStudentow.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Student>),
                        new XmlRootAttribute("ArrayOfPerson"));
                    listastud = (List<Student>)deserializer.Deserialize(reader);
                }
            }
            catch
            {
                MessageBox.Show("Brak pliku do załadowania!", "Uwaga", MessageBoxButton.OK);
            }
            lstPersons.ItemsSource = listastud;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            win2 window2 = new win2();
            window2.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3(id.Text);
            win3.Show();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            InitBinding();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            var serializer = new XmlSerializer(listastud.GetType());
            using (var writer = XmlWriter.Create("PersonList.xml"))
            {
                serializer.Serialize(writer, listastud);
            }
        }
    }
}
