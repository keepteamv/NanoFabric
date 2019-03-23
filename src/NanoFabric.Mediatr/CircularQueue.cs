using System.Collections.Concurrent;
using System.Linq;

namespace NanoFabric.Mediatr
{
    public class CircularQueue<T>
    {
        private readonly ConcurrentQueue<T> _innerQueue = new ConcurrentQueue<T>();
        private readonly object _lockObject = new object();

        public int Limit { get; }

        public CircularQueue(int limit = 1000)
        {
            Limit = limit;
        }

        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="obj"></param>
        public void Enqueue(T obj)
        {
            lock (_lockObject)
            {
                _innerQueue.Enqueue(obj);
                while (_innerQueue.Count > Limit && _innerQueue.TryDequeue(out T _)) ;
            }
        }

        /// <summary>
        /// 队列是否包含某个值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(T value)
        {
            lock (_lockObject)
            {
                return _innerQueue.Contains(value);
            }
        }
    }
}