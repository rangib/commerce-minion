using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Framework.Pipelines;

namespace Plugin.MyProject.Import
{
    public class ImportMinion : Minion
    {
        protected IImportMinionMinionPipeline MinionPipeline { get; set; }

        public override void Initialize(IServiceProvider serviceProvider, ILogger logger, MinionPolicy policy, CommerceEnvironment environment, CommerceContext globalContext)
        {
            base.Initialize(serviceProvider, logger, policy, environment, globalContext);
            MinionPipeline = serviceProvider.GetService<IImportMinionMinionPipeline>();
        }

        public override async Task<MinionRunResultsModel> Run()
        {
            this.Logger.LogInformation("ImportMinion running");

            var commerceContext = new CommerceContext(this.Logger, this.MinionContext.TelemetryClient, null);
            commerceContext.Environment = this.Environment;

            CommercePipelineExecutionContextOptions executionContextOptions = new CommercePipelineExecutionContextOptions(commerceContext, null, null, null, null, null);

            MinionRunResultsModel res = await this.MinionPipeline.Run(new MinionRunResultsModel(), executionContextOptions);

            return new MinionRunResultsModel();
        }
    }
}
