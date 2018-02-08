#if DebugTest
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace NukaCollect.Win.Tests {
    [TestFixture]
    public class ElementConstStringLoaderTests {
        [Test]
        public void Test() {
            TestElement testElement = new TestElement();
            testElement.PublicProperty = 1;
            testElement.NonPublicProperty = 2;
            testElement.PublicField = 3;
            testElement.nonPublicField = new TestElement();
            testElement.nonPublicField.PublicProperty = 4;
            testElement.nonPublicField.NonPublicProperty = 5;
            testElement.nonPublicField.PublicField = 6;
            ElementConstStringLoader.SetPropertyPathValue(testElement, "PublicProperty", 7);
            ElementConstStringLoader.SetPropertyPathValue(testElement, "NonPublicProperty", 8);
            ElementConstStringLoader.SetPropertyPathValue(testElement, "PublicField", 9);
            ElementConstStringLoader.SetPropertyPathValue(testElement, "nonPublicField.PublicProperty", 10);
            ElementConstStringLoader.SetPropertyPathValue(testElement, "nonPublicField.NonPublicProperty", 11);
            ElementConstStringLoader.SetPropertyPathValue(testElement, "nonPublicField.PublicField", 12);
            Assert.AreEqual(7, testElement.PublicProperty);
            Assert.AreEqual(8, testElement.NonPublicProperty);
            Assert.AreEqual(9, testElement.PublicField);
            Assert.AreEqual(10, testElement.nonPublicField.PublicProperty);
            Assert.AreEqual(11, testElement.nonPublicField.NonPublicProperty);
            Assert.AreEqual(12, testElement.nonPublicField.PublicField);
        }
    }
    public class TestElementBase {
        double publicProperty;

        public double PublicField;
        public double PublicProperty { get { return publicProperty; } set { publicProperty = value; } }
    }
    public class TestElement : TestElementBase {
        internal TestElement nonPublicField;
        int publicProperty;
        int nonPublicProperty;

        public new int PublicField;
        public new int PublicProperty { get { return publicProperty; } set { publicProperty = value; } }
        internal int NonPublicProperty { get { return nonPublicProperty; } set { nonPublicProperty = value; } }
    }
}
#endif
