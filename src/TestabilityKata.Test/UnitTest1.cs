using NUnit.Framework;

namespace TestabilityKata.Tests
{
        
    public class ProgramTest
    {
        [SetUp]
        public void ProgramSendsEmailWhenStartingUp()
        {
            //problem: we certainly don't want to send e-mails out
            Program.Main(new string[0]);
        }

        [Test]
        public void ProgramLogsErrorWhenEmailIsInvalid()
        {
            //problem: how can we know if the logging works, and how can we
            //simulate an error when we can't modify the MailSender?
            Program.Main(new string[0]);
        }
    }
}
