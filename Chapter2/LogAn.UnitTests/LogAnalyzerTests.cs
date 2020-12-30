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
        
        [TestCase("filewithbadextension.slf")]
        [TestCase("filewithbadextension.SLF")]
        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string fileName)
        {
            var analyzer = new LogAnalyzer();
            var result = analyzer.IsValidLogFileName(fileName);
            Assert.That(result, Is.True);
        }
    }
}