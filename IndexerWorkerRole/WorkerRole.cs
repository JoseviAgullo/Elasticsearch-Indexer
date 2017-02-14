using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using ElasticsearchIndexer.Infrastructure.Repository;
using IndexerWorkerRole.DependencyInjection;
using Microsoft.WindowsAzure.ServiceRuntime;
using StructureMap;

namespace IndexerWorkerRole
{
    public class WorkerRole : RoleEntryPoint
    {
        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private readonly ManualResetEvent runCompleteEvent = new ManualResetEvent(false);
        private IContainer _container;

        public override void Run()
        {
            Trace.TraceInformation("IndexerWorkerRole is running");

            var productRepo = new ProductRepository();

            var a = productRepo.GetAllProducts();

            try
            {
                this.RunAsync(this.cancellationTokenSource.Token).Wait();
            }
            finally
            {
                this.runCompleteEvent.Set();
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            // For information on handling configuration changes
            // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.

            _container = IoC.Initialize();

            bool result = base.OnStart();

            Trace.TraceInformation("IndexerWorkerRole has been started");

            return result;
        }

        public override void OnStop()
        {
            Trace.TraceInformation("IndexerWorkerRole is stopping");

            this.cancellationTokenSource.Cancel();
            this.runCompleteEvent.WaitOne();

            base.OnStop();

            Trace.TraceInformation("IndexerWorkerRole has stopped");
        }

        private async Task RunAsync(CancellationToken cancellationToken)
        {
            // TODO: Replace the following with your own logic.
            while (!cancellationToken.IsCancellationRequested)
            {
                Trace.TraceInformation("Working");
                await Task.Delay(1000);
            }
        }
    }
}
