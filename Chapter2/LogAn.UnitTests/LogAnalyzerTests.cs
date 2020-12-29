using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            var analyzer = new LogAnalyzer();
            var result = analyzer.IsValidLogFileName("filewithbadextension.form");
            Assert.That(result, Is.False);
        }
    }
}