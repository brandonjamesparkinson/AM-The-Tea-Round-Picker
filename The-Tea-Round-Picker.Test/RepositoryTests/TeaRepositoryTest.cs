using AM_The_Tea_Round_Picker.Models;
using AM_The_Tea_Round_Picker.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace The_Tea_Round_Picker.Test.RepositoryTests
{
    /// <summary>
    /// Summary description for TeaRepositoryTest
    /// </summary>
    [TestClass]
    public class TeaRepositoryTest
    {
        //TODO : Proper mocking
        [TestMethod]
        public void AddTeaForTestAndGetTeaByIdAndThenDelete()
        {
            var data = new Tea { TeaId = 1, TeaName = "Herbal" };
            ITeaRepository repository = new TeaRepository();
            repository.AddTea(data);
            var result = repository.GetById(data.TeaId);
            Assert.AreEqual(data.TeaId, result.TeaId);
            repository.Delete(data.TeaId);
        }

        [TestMethod]

        public void GetAllTea()
        {
            ITeaRepository repository = new TeaRepository();
            Assert.IsNotNull(repository.GetAll());
        }
    }
}
