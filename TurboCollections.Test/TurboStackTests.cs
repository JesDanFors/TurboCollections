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

        [Test]
        public void PopTheStack(){
            var stack = new TurboStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var test = stack.Yeet();
            Assert.AreEqual(3,test);
            Assert.AreEqual(2,stack.Count);
        }

        [Test]
        public void ClearTheStack(){
            var stack = new TurboStack<int>();
            for (int i = 0; i < 5; i++){
                stack.Push(1);
            }
            stack.Clear();
            Assert.AreEqual(0,stack.Count);
        }
    }
}