using System.Collections.Generic;
using System.Threading.Tasks;
using KafkaCurator.Configuration;

namespace KafkaCurator.Changes
{
    public interface IChangesManager
    {
        public string Name { get; }
        Task PreviewChanges(IReadOnlyList<ITopicConfiguration> topics);
        Task HandleChanges(IReadOnlyList<ITopicConfiguration> topics);
    }
}