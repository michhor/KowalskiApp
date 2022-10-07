using KowalskiApp.StdLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KowalskiApp.Test.Models
{ 
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void CheckAGoodSerilization()
        {
            string first = "Jan";
            string second = "Kowalski";
            Person person = new Person() {FirstName = first, SecondName = second};
            Assert.AreEqual($"{first} {second}",person.ToString());

        }
    }
}