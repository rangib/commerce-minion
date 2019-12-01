using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Eventing;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Plugin.MyProject.Import
{
    class ImportMinionBlock : PipelineBlock<MinionRunResultsModel, MinionRunResultsModel, CommercePipelineExecutionContext>
    {
        private readonly IPersistEntityPipeline _persistEntityPipeline;

        public ImportMinionBlock(IPersistEntityPipeline persitEntityPipeline): base((string)null)
        {
            this._persistEntityPipeline = persitEntityPipeline;
        }

        public override Task<MinionRunResultsModel> Run(MinionRunResultsModel arg, CommercePipelineExecutionContext context)
        {
            return Task.FromResult<MinionRunResultsModel>(arg);
        }
    }
}

