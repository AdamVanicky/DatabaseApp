using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GalaSoft.MvvmLight.Command;
using DatabaseApp.ViewModels;
using DatabaseApp;
using DatabaseApp.Validate;

namespace DatabaseAppUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Is_CheckupMethod_Valid()
        {
            Person p = new Person(new StringValidator(), new NumberValidator());

            bool b = p.Checkup("Adam", "Vanicky", "010101/0201", new DateTime(2001, 09, 19));

            Assert.IsTrue(b);
        }

        [TestMethod]
        public void Is_added_person_without_properties_null()
        {
            DatabaseViewModel dvm = new DatabaseViewModel();
            

            dvm.SendCommand.Execute(null);

            Assert.AreEqual(dvm.Firstname, null);
        }
    }
}
