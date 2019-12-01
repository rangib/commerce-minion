using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plugin.MyProject.Import
{
    [PipelineDisplayName("IImportMinionMinionPipeline")]
    public interface IImportMinionMinionPipeline : IPipeline<MinionRunResultsModel, MinionRunResultsModel, CommercePipelineExecutionContext>, IPipelineBlock<MinionRunResultsModel, MinionRunResultsModel, CommercePipelineExecutionContext>, IPipelineBlock, IPipeline
    {
    }
}
