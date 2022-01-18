using NUnit.Framework;

namespace TurboCollections.Test{
    public class TurboStackTests{

        [Test]
        public void PushTheStack(){
            var stack = new TurboStack<int>();
            stack.Push(5);
            Assert.AreEqual(1,stack.Count);
        }

        [Test]
        public void PeekTheStack(){
            var stack = new TurboStack<int>();
            stack.Push(1);
            stack.Push(2);
            var test = stack.Peek();
            Assert.AreEqual(2, test);
        }
    }
}