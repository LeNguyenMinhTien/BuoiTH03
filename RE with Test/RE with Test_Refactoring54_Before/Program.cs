using System;
using System.Collections.Generic;

namespace Problem_ReplaceExceptionWithTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourcePool = new ResourcePool();
            try
            {
                var resource = resourcePool.GetResource();
                Console.WriteLine("Got resource.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class ResourcePool
    {
        private Stack<string> _resources = new Stack<string>();
        public string GetResource()
        {
            if (_resources.Count == 0)
            {
                throw new Exception("Resource pool is empty.");
            }
            return _resources.Pop();
        }
    }
}