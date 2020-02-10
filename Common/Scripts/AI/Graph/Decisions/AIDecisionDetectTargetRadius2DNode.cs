using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionDetectTargetRadius2D"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/2D/Detect Target Radius")]
    public class AIDecisionDetectTargetRadius2DNode : AIDecisionNode
    {
        public float radius = 3f;
        public Vector3 detectionOriginOffset = new Vector3(0, 0, 0);
        public LayerMask targetLayer;
        public LayerMask obstacleMask;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionDetectTargetRadius2D>();
            decision.Label = label;
            decision.Radius = radius;
            decision.DetectionOriginOffset = detectionOriginOffset;
            decision.TargetLayer = targetLayer;
            decision.ObstacleMask = obstacleMask;
            return decision;
        }
    }
}