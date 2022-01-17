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
            Assert.AreEqual(1, list.Count);
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

            list.Clear();
            Assert.Zero(list.Count);
        }

        [Test]
        public void RemoveSpecificElement(){
            var list = new TurboList<int>();
            for (int i = 0; i < 10; i++){
                list.Add(11);
            }

            var tester = list.Count;
            list.RemoveAt(8);
            Assert.AreNotEqual(list.Count, tester);
        }

        [Test]
        public void ListContainsItem(){
            var list = new TurboList<int>();
            list.Add(11);
            list.Add(5);
            bool contains = list.Contains(5);
            Assert.True(contains);
        }

        [Test]
        public void IndexOfItem(){
            var list = new TurboList<int>();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            int index = list.IndexOf(10);
            Assert.AreEqual(2, index);
        }

        [Test]
        public void ItemNotContainedInList(){
            var list = new TurboList<int>();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            int index = list.IndexOf(50);
            Assert.AreEqual(-1, index);
        }
        
    }
}