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
    }
}    