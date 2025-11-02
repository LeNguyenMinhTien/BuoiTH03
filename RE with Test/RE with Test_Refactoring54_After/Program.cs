using System;
using System.Collections.Generic;

namespace Solution_ReplaceExceptionWithTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourcePool = new ResourcePool();
            if (resourcePool.IsAvailable())
            {
                var resource = resourcePool.GetResource();
                Console.WriteLine("Got resource.");
            }
            else
            {
                Console.WriteLine("Resource pool is empty.");
            }
        }
    }

    class ResourcePool
    {
        private Stack<string> _resources = new Stack<string>();
        public bool IsAvailable()
        {
            return _resources.Count > 0;
        }
        public string GetResource()
        {
            if (!IsAvailable()) // Vẫn có thể throw exception cho các trường hợp bất thường
            {
                throw new InvalidOperationException("Check IsAvailable() before calling.");
            }
            return _resources.Pop();
        }
    }
}