using System.Collections.ObjectModel;

namespace WPF45_Commanding_Enable_Disable.ModelClasses
{
    /// <summary>
    /// The DataAccess class
    /// </summary>
    public class DataAccess
    {
        public ObservableCollection<PersonInfo> GetPersonData()
        {
            return new PersonsDataStore();
        }
    }

}
