using NUnit.Framework;
using Rhino.Mocks;

namespace MFramework.Common.Core.Logging.Test
{
    [TestFixture]
    public abstract class TestUnitBase
    {
        protected MockRepository _mockRepository;
        [SetUp]
        public virtual void SetUp()
        {
            _mockRepository= new MockRepository();
        }
    }
}
