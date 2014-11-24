using NUnit.Framework;
namespace MFramework.Common.Core.Logging.Test
{
    class LogTest:TestUnitBase
    {
        [Test]
        public void LogginTest()
        {
            var log = Log.GetLoggerFromContext();
            log.Info("Writing Info Text");

        }
    }
}
