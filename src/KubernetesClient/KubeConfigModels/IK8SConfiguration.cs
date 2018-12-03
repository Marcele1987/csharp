using System.Collections.Generic;

namespace k8s.KubeConfigModels
{
    /// <summary>
    /// kubeconfig configuration model. Holds the information needed to build connect to remote
    /// Kubernetes clusters as a given user.
    /// </summary>
    /// <remarks>
    /// Should be kept in sync with https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/client-go/tools/clientcmd/api/v1/types.go
    /// </remarks>
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
