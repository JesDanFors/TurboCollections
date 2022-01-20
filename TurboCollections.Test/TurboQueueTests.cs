using System;
using NUnit.Framework;
using TurboCollections;

namespace TurboQueueTests{
    public class TurboQueueTests{
        [Test]
        public void EmptyQueue(){
            var newQueue = new TurboQueue<int>();
            Assert.AreEqual(0, newQueue.Count);
        }

        [Test]
        public void AddToTheQueue(){
            var newQueue = new TurboQueue<int>();
            newQueue.Enqueue(5);
            Assert.AreEqual(1,newQueue.Count);
        }

        [Test]
        public void CorrectItemAddedToQueue(){
            var newQueue = new TurboQueue<int>();
            newQueue.Enqueue(5);
            newQueue.Enqueue(4);
            Assert.AreEqual(5, newQueue.Peak());
        }

        [Test]
        public void CanDequeueAnItem(){
            var newQueue = new TurboQueue<int>();
            for (int i = 0; i < 5; i++){
                newQueue.Enqueue(1);
            }
            newQueue.Dequeue();
            Assert.AreEqual(4, newQueue.Count);
        }

        [Test]
        public void DequeueReturnsCollectValue(){
            var newQueue = new TurboQueue<int>();
            newQueue.Enqueue(1);
            newQueue.Enqueue(2);
            newQueue.Enqueue(3);
            newQueue.Enqueue(4);
            var test = newQueue.Dequeue();
            Assert.AreEqual(3,newQueue.Count);
            Assert.AreEqual(4, test);
        }
    }
}    