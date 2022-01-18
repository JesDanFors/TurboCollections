using System;
using NUnit.Framework;

namespace TurboCollections.Test{
    public class TurboListTests{

        //Given
        //When
        //Then
        
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

        [TestCase(5), TestCase(7)]
        public void AddingMultipleElementsIncreasesTheCount(int numberOfElements){
            var list = new TurboList<int>();
            for (int i = 0; i < numberOfElements; i++)
                list.Add(5);
            Assert.AreEqual(numberOfElements, list.Count);

        }

        [Test]
        public void ExistingItemsCanBeOverwritten(){
            var (_, list) = CreateTestData();
            list.Set(2, 666);
            Assert.AreEqual(666, list.Get(2));

        }

        (int[] numbers, TurboList<int>) CreateTestData(){
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var list = new TurboList<int>();
            foreach (var number in numbers){
                list.Add(number);
            }

            return (numbers, list);
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
            list.Add(1);
            list.Add(2);
            list.Add(3); 
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(7);
            list.Add(7);
            list.Add(7);
            list.RemoveAt(2);
            Assert.AreEqual(6, list.Get(4));
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

        [Test]
        public void RemovedItem(){
            var list = new TurboList<int>();
            list.Add(12);
            list.Add(11);
            list.Add(10);
            list.Remove(11);
            Assert.AreEqual(10, list.Get(1));
        }

        [Test]
        public void AddedARangeOfItems(){
            var fillList = new TurboList<int>();
            var list = new TurboList<int>();
            fillList.Add(1);
            fillList.Add(2);
            fillList.Add(3);

            //IEnumerable<int> test = fillList;
            
            
            //list.AddRange(test);

            for (int i = 0; i < fillList.Count; i++){
                Console.WriteLine(fillList.Get(i));
            }
            for (int i = 0; i < list.Count; i++){
                Console.WriteLine(list.Get(i));
            }
            Assert.AreSame(fillList,list);
        }
    }
}