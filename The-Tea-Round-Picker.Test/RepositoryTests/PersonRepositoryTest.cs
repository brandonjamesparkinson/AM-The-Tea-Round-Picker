using AM_The_Tea_Round_Picker.Models;
using AM_The_Tea_Round_Picker.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace The_Tea_Round_Picker.Test.RepositoryTests
{
    /// <summary>
    /// Summary description for PersonRepositoryTest
    /// </summary>
    [TestClass]
    public class PersonRepositoryTest
    {
        //TODO : Proper mocking
        [TestMethod]
        public void AddPersonForTestAndGetPersonByIdAndThenDelete()
        {
            var data = new Person { PersonId = 1, PersonName = "Paul" };
            IPersonRepository repository = new PersonRepository();
            repository.AddPerson(data);
            var result = repository.GetById(data.PersonId);
            Assert.AreEqual(data.PersonId, result.PersonId);
            repository.Delete(data.PersonId);
        }

        [TestMethod]

        public void GetAllPeople()
        {
            IPersonRepository repository = new PersonRepository();
            Assert.IsNotNull(repository.GetAll());
        }
    }
}
