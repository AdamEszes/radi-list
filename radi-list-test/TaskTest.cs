using radi_list.Models;

namespace radi_list_test
{
    [TestClass]
    public class TaskTest
    {
        private RadiologyTask rTask;
        const string initialTitle = "Initial title";

        [TestInitialize]
        public void TestInitialize()
        {
            rTask = new RadiologyTask()
            {
                Title = initialTitle,
                IsCompleted = false
            };

        }

        //No business logic yet, so "testing" a simple edit
        [TestMethod]
        public void EditTask()
        {
            Assert.AreEqual(rTask.Title, initialTitle);
            var fixedTitle = "Fixed title";
            rTask.Title = fixedTitle;
            Assert.AreEqual(rTask.Title, fixedTitle);
        }


    }
}