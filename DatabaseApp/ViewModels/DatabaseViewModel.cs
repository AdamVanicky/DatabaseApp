using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;
using GalaSoft.MvvmLight.Command;
using DatabaseApp.Validate;

namespace DatabaseApp.ViewModels
{
    public class DatabaseViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DatabaseViewModel()
        {

        }

        private string firstname;

        // Zprava je bindovaná z GUI
        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Firstname)));
            }
        }

        private string surname;

        // Zprava je bindovaná z GUI
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Surname)));
            }
        }

        private string rodnecislo;

        // Zprava je bindovaná z GUI
        public string RodneCislo
        {
            get { return rodnecislo; }
            set
            {
                rodnecislo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RodneCislo)));
            }
        }

        private DateTime dateofbirth;

        // Zprava je bindovaná z GUI
        public DateTime DateofBirth
        {
            get { return dateofbirth; }
            set
            {
                dateofbirth = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateofBirth)));
            }
        }

        private Person CreateProfile()
        {
            Person p;

            p = new Person(new StringValidator(), new NumberValidator());

            bool checkup = p.Checkup(Firstname, Surname, RodneCislo, DateofBirth);

            if (checkup)
            {
                return p;
            }
            else return null;
        }

        private static ICommand _sendCommand;

        public ICommand SendCommand
        {
            get
            {
                if (_sendCommand == null)
                {
                    _sendCommand = new RelayCommand(
                        () => {
                            Database d = Database.CreateOne;

                            Person p = CreateProfile();

                            if(p != null)
                            {
                                Debug.WriteLine(p.FirstName);

                                d.databaze.Add(p.FirstName, p);
                                MessageBox.Show("Person added");
                            }
                            else { MessageBox.Show("Error occured, wrong input!"); }
                        });
                }
                return _sendCommand;
            }
        }
    }
}
