using NUnit.Framework;

namespace TurboCollections.Test{
    public class TurboListTests{

        [Test]
        public void NewListIsEmpty(){
            var list = new TurboList<int>();
            Assert.Zero(list.Count);
        }

        [Test]
        public void AddingAnElementIncreasesCountToOne(){
            var list = new TurboList<int>();
            list.Add(5);
            Assert.AreEqual(1,list.Count);
        }

        [Test, TestCase(5), TestCase(7)]
        public void AddingMultipleElementsIncreasesTheCount(int numberOfElements){
            var list = new TurboList<int>();
            for (int i = 0; i < numberOfElements; i++)
                list.Add(5);
            Assert.AreEqual(numberOfElements, list.Count);
            
        }

        [Test]
        public void AnAddedElementCanBeGet(){
            var list = new TurboList<int>();
            list.Add(1337);
            Assert.AreEqual(1337, list.Get(0));
        }

        [Test]
        public void ClearTheEntireList(){
            var list = new TurboList<int>();
            for (int i = 0; i < 10; i++){
                list.Add(1);
            }
            Assert.Zero(list.Count);
        }
    }
}