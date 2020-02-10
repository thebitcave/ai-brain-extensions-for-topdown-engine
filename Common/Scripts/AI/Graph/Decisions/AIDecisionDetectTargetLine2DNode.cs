using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionDetectTargetLine2D"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/2D/Detect Target Line")]
    public class AIDecisionDetectTargetLine2DNode : AIDecisionNode
    {
        [NodeEnum] public AIDecisionDetectTargetLine2D.DetectMethods detectMethod = AIDecisionDetectTargetLine2D.DetectMethods.Ray;
        [NodeEnum] public AIDecisionDetectTargetLine2D.DetectionDirections detectionDirection = AIDecisionDetectTargetLine2D.DetectionDirections.Front;
        public float rayWidth = 1f;
        public float detectionDistance = 10f;
        public Vector3 detectionOriginOffset = new Vector3(0,0,0);
        public LayerMask targetLayer;
        public LayerMask obstaclesLayer;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionDetectTargetLine2D>();
            decision.Label = label;
            decision.DetectMethod = detectMethod;
            decision.DetectionDirection = detectionDirection;
            decision.RayWidth = rayWidth;
            decision.DetectionDistance = detectionDistance;
            decision.DetectionOriginOffset = detectionOriginOffset;
            decision.TargetLayer = targetLayer;
            decision.ObstaclesLayer = obstaclesLayer;
            return decision;
        }
    }
}