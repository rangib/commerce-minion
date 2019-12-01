using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Plugin.MyProject.Import
{
    public class ImportMinionMinionPipeline : CommercePipeline<MinionRunResultsModel, MinionRunResultsModel>, IImportMinionMinionPipeline, IPipeline<MinionRunResultsModel, MinionRunResultsModel, CommercePipelineExecutionContext>, IPipelineBlock<MinionRunResultsModel, MinionRunResultsModel, CommercePipelineExecutionContext>, IPipelineBlock, IPipeline
    {
        public ImportMinionMinionPipeline(IPipelineConfiguration<IImportMinionMinionPipeline> configuration, ILoggerFactory loggerFactory) : base((IPipelineConfiguration)configuration, loggerFactory)
        {
        }
    }
}
