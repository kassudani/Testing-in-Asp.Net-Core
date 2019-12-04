using System;
using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetLastErrorProperty()
        {
            var logger = new ErrorLogger();
            
            logger.Log("Abc");

            Assert.That(logger.LastError, Is.EqualTo("Abc")); 
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]

        public void Log_InvalidError_ThrowArgumentNullExceptionError(string error)
        {
            var logger = new ErrorLogger();

            //logger.Log(error);

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();


            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; }; //subscribed to the event
                                                                    //subscription has to be done before actiong on the method
            logger.Log("Abc");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
