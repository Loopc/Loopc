using System;
using Loopc.Repository.Entity;
using Loopc.Repository.IRepositoryProvider;

namespace Loopc.Repository.RepositoryImplmentation
{
    public class DemoRepository : IDemoRepository
    {
        public Demo GetData()
        {
            // TODO
            // here need to use 
            // using(var db = new DataContext()) { }
            return new Demo { Data = "模拟数据库数据", DateTime = DateTime.Now };
        }
    }
}
