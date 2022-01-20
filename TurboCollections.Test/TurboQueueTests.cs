using System;
using System.ComponentModel;
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
        public void DequeueReturnsCorrectValue(){
            var newQueue = new TurboQueue<int>();
            newQueue.Enqueue(1);
            newQueue.Enqueue(2);
            newQueue.Enqueue(3);
            newQueue.Enqueue(4);
            var test = newQueue.Dequeue();
            Assert.AreEqual(3,newQueue.Count);
            Assert.AreEqual(1, test);
        }

        [Test]
        public void QueueCanBeCleared(){
            var newQueue = new TurboQueue<int>();
            for (int i = 0; i < 5; i++){
                newQueue.Enqueue(1);
            }
            newQueue.Clear();
            Assert.AreEqual(0,newQueue.Count);
        }

        [Test]
        public void QueueIsEmpty(){
            var newQueue = new TurboQueue<int>();
            for (int i = 0; i < 4; i++){
                newQueue.Enqueue(1);
            }
            newQueue.Clear();
            Assert.AreEqual(0,newQueue.Peak());
        }

        [Test]
        public void MarcsTest(){
            var queue = new TurboQueue<int>();
            queue.Enqueue(1); // 1
            queue.Enqueue(2); // 2
            queue.Enqueue(3); // 3
            queue.Enqueue(4); // 4
            Assert.AreEqual(1, queue.Dequeue()); // 3
            queue.Enqueue(5); // 4
            Assert.AreEqual(2, queue.Dequeue());// 3
            queue.Enqueue(6); // 4
            Assert.AreEqual(3, queue.Dequeue()); // 3
            Assert.AreEqual(4, queue.Dequeue()); // 2
            Assert.AreEqual(5, queue.Dequeue()); // 1
            queue.Enqueue(7); // 2
            queue.Enqueue(8); // 3
            queue.Enqueue(9); // 4
            Assert.AreEqual(6,queue.Dequeue()); // 3
            Assert.AreEqual(7,queue.Dequeue());// 2
            Assert.AreEqual(8,queue.Dequeue());// 1
            Assert.AreEqual(9,queue.Dequeue());// 0
        }

        [Test]
        public void MarcsSecondtest(){
            var queue = new TurboQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Assert.AreEqual(1,queue.Dequeue());
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Assert.AreEqual(2,queue.Dequeue());
            Assert.AreEqual(3,queue.Dequeue());
            Assert.AreEqual(4,queue.Dequeue());
            Assert.AreEqual(5,queue.Dequeue());
        }
    }
}    