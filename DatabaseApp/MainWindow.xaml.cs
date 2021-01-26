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

namespace DatabaseApp
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void butAddPerson_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person(tbFirstName.Text, tbSurName.Text, tbPersonNumber.Text, dtDateofBirth.DisplayDate);
            Database d = Database.CreateOne;
            
            MessageBox.Show($"{d}");
        }
    }

    class Database
    {
        static Dictionary<string, Person> databaze;
        private static readonly object locking = new object();
        static Database instance = null;

        private Database()
        {
            databaze = new Dictionary<string, Person>();
        }

        public static Database CreateOne
        {
            get 
            { 
                lock(locking)
                {
                    if(instance == null)
                    {
                        instance = new Database();
                    }
                }
                return instance;
            }
        }
    }
}
