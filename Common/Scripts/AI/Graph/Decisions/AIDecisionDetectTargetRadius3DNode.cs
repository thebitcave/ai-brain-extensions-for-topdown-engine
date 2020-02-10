using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionDetectTargetRadius3D"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/3D/Detect Target Radius")]
    public class AIDecisionDetectTargetRadius3DNode : AIDecisionNode
    {
        public float radius = 3f;
        public Vector3 detectionOriginOffset = new Vector3(0, 0, 0);
        public LayerMask targetLayerMask;
        public LayerMask obstacleMask;
        public float targetCheckFrequency = 1f;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionDetectTargetRadius3D>();
            decision.Label = label;
            decision.Radius = radius;
            decision.DetectionOriginOffset = detectionOriginOffset;
            decision.TargetLayerMask = targetLayerMask;
            decision.ObstacleMask = obstacleMask;
            decision.TargetCheckFrequency = targetCheckFrequency;
            return decision;
        }
    }
}