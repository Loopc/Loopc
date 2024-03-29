﻿using System.ServiceProcess;
using Loopc.Foundation.Log;
using Loopc.Foundation.Utility;
using Loopc.IOC.BindingModule;
using Loopc.Service.IServiceProvider;
using Ninject;

namespace Loopc.WindowsService.HttpListener
{
    partial class Service : ServiceBase
    {
        public Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var kernel = new StandardKernel(new ServiceBindingModule(), new RepositoryBindingModule(), new OtherBindingModule());
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
        }
    }
}
