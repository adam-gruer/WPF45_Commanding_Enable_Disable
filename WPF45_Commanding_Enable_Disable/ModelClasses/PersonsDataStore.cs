using System.Collections.ObjectModel;

namespace WPF45_Commanding_Enable_Disable.ModelClasses
{
    /// <summary>
    /// The person data store class
    /// </summary>
    public class PersonsDataStore : ObservableCollection<PersonInfo>
    {
        public PersonsDataStore()
        {
            Add(new PersonInfo() { PersonId = 1, FirstName = "tejas", LastName = "Sabnis", Age = 10, City = "Pune" });
            Add(new PersonInfo() { PersonId = 2, FirstName = "Mahesh", LastName = "Sabnis", Age = 38, City = "Pune" });
            Add(new PersonInfo() { PersonId = 3, FirstName = "Ramesh", LastName = "Sabnis", Age = 73, City = "Yavatmal" });
            Add(new PersonInfo() { PersonId = 4, FirstName = "Aditya", LastName = "Bhagat", Age = 3, City = "Pune" });
            Add(new PersonInfo() { PersonId = 5, FirstName = "Prashant", LastName = "Bhagat", Age = 31, City = "Pune" });
            Add(new PersonInfo() { PersonId = 6, FirstName = "Tejas", LastName = "Kumar", Age = 26, City = "Delhi" });
            Add(new PersonInfo() { PersonId = 7, FirstName = "Aditya", LastName = "Kumar", Age = 25, City = "Delhi" });
            Add(new PersonInfo() { PersonId = 8, FirstName = "Sanjay", LastName = "Kulkarni", Age = 55, City = "Nagpur" });
            Add(new PersonInfo() { PersonId = 9, FirstName = "Abhay", LastName = "Kulkarni", Age = 51, City = "Akola" });
            Add(new PersonInfo() { PersonId = 10, FirstName = "Anil", LastName = "Deshpande", Age = 45, City = "Pune" });
            Add(new PersonInfo() { PersonId = 11, FirstName = "Anil", LastName = "Kulkarni", Age = 50, City = "Yavatmal" });
        }
    }
}
