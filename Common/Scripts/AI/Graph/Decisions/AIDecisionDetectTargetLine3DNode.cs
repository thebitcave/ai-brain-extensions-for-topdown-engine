using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionDetectTargetLine3D"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/3D/Detect Target Line")]
    public class AIDecisionDetectTargetLine3DNode : AIDecisionNode
    {
        [NodeEnum] public AIDecisionDetectTargetLine3D.DetectMethods detectMethod = AIDecisionDetectTargetLine3D.DetectMethods.Ray;
        public float rayWidth = 1f;
        public float detectionDistance = 10f;
        public Vector3 detectionOriginOffset = new Vector3(0,0,0);
        public LayerMask targetLayer;
        public LayerMask obstaclesLayer;
  //      public Transform referenceTransform;
        public bool forceAimToDetectionDirection = false;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionDetectTargetLine3D>();
            decision.Label = label;
            decision.DetectMethod = detectMethod;
            decision.RayWidth = rayWidth;
            decision.DetectionDistance = detectionDistance;
            decision.DetectionOriginOffset = detectionOriginOffset;
            decision.TargetLayer = targetLayer;
            decision.ObstaclesLayer = obstaclesLayer;
   //         decision.ReferenceTransform = referenceTransform;
            decision.ForceAimToDetectionDirection = forceAimToDetectionDirection;
            return decision;
        }
    }
}