using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMoveRandomly2D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Move Randomly 2D")]
    public class AIActionMoveRandomly2DNode : AIActionNode
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
            var action = go.AddComponent<AIActionMoveRandomly2D>();
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