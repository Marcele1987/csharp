using System.Collections.Generic;

namespace k8s.KubeConfigModels
{
    public interface IK8SConfiguration
    {
        string ApiVersion { get; set; }
        IEnumerable<Cluster> Clusters { get; set; }
        IEnumerable<Context> Contexts { get; set; }
        string CurrentContext { get; set; }
        IDictionary<string, dynamic> Extensions { get; set; }
        string FileName { get; set; }
        string Kind { get; set; }
        IDictionary<string, object> Preferences { get; set; }
        IEnumerable<User> Users { get; set; }
    }
}