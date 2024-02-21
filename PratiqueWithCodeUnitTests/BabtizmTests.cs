using EvaluationSampleCode;

namespace PratiqueWithCodeUnitTests
{
    [TestClass]
    public class BabtizmTests
    {
        
        [TestMethod]
        public void CanBeBaptizedBy_Priest_ReturnsTrue()
        {
            var clergyMember = new ClergyMember { IsPriest = true };
            var baptizm = new Baptizm(clergyMember);
            var result = baptizm.CanBeBaptizedBy(clergyMember);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeBaptizedBy_Pope_ReturnsTrue()
        {
            var clergyMember = new ClergyMember { IsPope = true };
            var baptizm = new Baptizm(clergyMember);
            var result = baptizm.CanBeBaptizedBy(clergyMember);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeBaptizedBy_NotPriestNorPope_ReturnsFalse()
        {
            var clergyMember = new ClergyMember();
            var baptizm = new Baptizm(clergyMember);
            var result = baptizm.CanBeBaptizedBy(clergyMember);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CanBeTeachedBy_SameClergyMember_ReturnsTrue()
        {
            var clergyMember = new ClergyMember();
            var baptizm = new Baptizm(clergyMember);
            var result = baptizm.CanBeTeachedBy(clergyMember);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeTeachedBy_DifferentClergyMember_ReturnsFalse()
        {
            var clergyMember = new ClergyMember();
            var baptizm = new Baptizm(clergyMember);
            var result = baptizm.CanBeTeachedBy(new ClergyMember());
            Assert.IsFalse(result);
        }
    }
}