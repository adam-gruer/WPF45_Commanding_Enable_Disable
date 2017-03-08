using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WPF45_Commanding_Enable_Disable.Commands;
using WPF45_Commanding_Enable_Disable.ModelClasses;

namespace WPF45_Commanding_Enable_Disable.ViewModels
{
    /// <summary>
    /// The ViewModel class
    /// </summary>
    class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string pName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(pName));
            }
        }

        private ObservableCollection<PersonInfo> persons;

        public ObservableCollection<PersonInfo> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged("Name");
                }
        }

        public RelayActionCommand SearchPersonCommand { get; set; }

        private DataAccess objds;

        public PersonViewModel()
        {
            
            objds = new DataAccess();
            Persons = new ObservableCollection<PersonInfo>(objds.GetPersonData());

            var defaultView = CollectionViewSource.GetDefaultView(Persons);

            //The Command object is initialized where the 'CanExecuteAction' will be set True or False
            //based upon the State of the 'Name' property
            //The 'ExecuteAction' will accepts the data filtered from the collection
            //based upon the data entered in the TextBox
            SearchPersonCommand = new RelayActionCommand()
            {
                CanExecuteAction = n => !String.IsNullOrEmpty(Name),
                ExecuteAction = n => defaultView.Filter = name => ((PersonInfo)name).FirstName.StartsWith(Name)
                                                                || ((PersonInfo)name).LastName.StartsWith(Name)
                                                                || ((PersonInfo)name).City == Name
            };


        }





    }
}
