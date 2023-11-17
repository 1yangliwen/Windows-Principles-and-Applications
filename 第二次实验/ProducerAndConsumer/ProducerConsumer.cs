using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerAndConsumer
{
    public class ProducerConsumer
    {
        private readonly SemaphoreSlim _empty;
        private readonly SemaphoreSlim _full;
        private readonly object _lockObject = new object();
        private Queue<int> _buffer;

        public ProducerConsumer(int bufferSize)
        {
            _buffer = new Queue<int>(bufferSize);
            _empty = new SemaphoreSlim(bufferSize, bufferSize); // Initially, buffer is empty.
            _full = new SemaphoreSlim(0, bufferSize); // Initially, buffer is not full.
        }

        public void Produce(int item)
        {
            _empty.Wait(); // Wait for empty space
            lock (_lockObject)
            {
                _buffer.Enqueue(item); // Produce item
                                       // Optionally: Update producer text box here
            }
            _full.Release(); // Signal that there is a full space
        }

        public int Consume()
        {
            _full.Wait(); // Wait for full space
            int item;
            lock (_lockObject)
            {
                item = _buffer.Dequeue(); // Consume item
                                          // Optionally: Update consumer text box here
            }
            _empty.Release(); // Signal that there is an empty space
            return item;
        }

        public void ProducerMethod(ProducerConsumer pc, Action<int> updateUI, CancellationToken token)
        {
            Random rand = new Random();
            while (!token.IsCancellationRequested) // Check for cancellation request
            {
                int item = rand.Next(100); // Let's assume it produces a number between 0 and 99
                pc.Produce(item);
                updateUI?.Invoke(item); // Update the UI with the produced item
                Thread.Sleep(1000); // Slow down the production for demonstration
            }
        }

        public void ConsumerMethod(ProducerConsumer pc, Action<int> updateUI, CancellationToken token)
        {
            while (!token.IsCancellationRequested) // Check for cancellation request
            {
                int item = pc.Consume();
                updateUI?.Invoke(item); // Update the UI with the consumed item
                Thread.Sleep(1000); // Slow down the consumption for demonstration
            }
        }


    }
}
