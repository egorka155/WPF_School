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

namespace WpfSchoolMain
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Service> servicesList = new List<Service>();

        public MainWindow()
        {
            InitializeComponent();
            initDataGrid();
        }

        private void initDataGrid()
        {
            initData();
            dataGrid.ItemsSource = servicesList;
        }

        private void initData()
        {
            servicesList.Add(new Service()
            {
                Client = "Ефимова",
                ServiceStart = "22.12.2019 15:10",
                Services = "Урок в группе немецкого языка для школьников"
            });
            servicesList.Add(new Service()
            {
                Client = "Бобылёв",
                ServiceStart = "07.06.2019 17:20",
                Services = "Киноклуб португальского языка для студентов"
            });
            servicesList.Add(new Service()
            {
                Client = "Зуев",
                ServiceStart = "04.03.2019 17:20",
                Services = "Индивидуальный урок испанского языка с преподавателем-носителем языка"
            });
            servicesList.Add(new Service()
            {
                Client = "Колобова",
                ServiceStart = "01.12.2019 14:40",
                Services = "Урок в группе немецкого языка для школьников"
            });
            servicesList.Add(new Service()
            {
                Client = "Калашников",
                ServiceStart = "26.06.2019 10:10",
                Services = "Индивидуальный урок немецкого языка с русскоязычным преподавателем"
            });
            servicesList.Add(new Service()
            {
                Client = "Голубев",
                ServiceStart = "05.12.2019 10:20",
                Services = "Занятие с русскоязычным репетитором английского языка"
            });



        }
        


        

        
    }
}
