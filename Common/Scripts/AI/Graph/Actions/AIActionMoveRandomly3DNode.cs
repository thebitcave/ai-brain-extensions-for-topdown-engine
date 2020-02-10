using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMoveRandomly3D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/3D/Move Randomly")]
    public class AIActionMoveRandomly3DNode : AIActionNode
    {
        [Header("Duration")]
        public float maximumDurationInADirection = 2f;
        [Header("Obstacles")]
        public LayerMask obstacleLayerMask;
        public float obstaclesDetectionDistance = 1f;
        public float obstaclesCheckFrequency = 1f;
        public Vector2 minimumRandomDirection = new Vector2(-1f, -1f);
        public Vector2 maximumRandomDirection = new Vector2(1f, 1f);

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMoveRandomly3D>();
            action.Label = label;
            action.MaximumDurationInADirection = maximumDurationInADirection;
            action.ObstacleLayerMask = obstacleLayerMask;
            action.ObstaclesDetectionDistance = obstaclesDetectionDistance;
            action.ObstaclesCheckFrequency = obstaclesCheckFrequency;
            action.MinimumRandomDirection = minimumRandomDirection;
            action.MaximumRandomDirection = maximumRandomDirection;
            return action;
        }
    }
}