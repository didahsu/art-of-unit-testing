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
        
        [Test]
        public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            var analyzer = new LogAnalyzer();
            var result = analyzer.IsValidLogFileName("filewithbadextension.slf");
            Assert.That(result, Is.True);
        }
        
        [Test]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            var analyzer = new LogAnalyzer();
            var result = analyzer.IsValidLogFileName("filewithbadextension.SLF");
            Assert.That(result, Is.True);
        }
    }
}