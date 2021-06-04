using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMoveRandomlyGrid"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Move Randomly Grid")]
    public class AIActionMoveRandomlyGridNode : AIActionNode
    {
        public AIActionMoveRandomlyGrid.Modes mode = AIActionMoveRandomlyGrid.Modes.ThreeD;
        public float maximumDurationInADirection = 3f;
        public LayerMask obstacleLayerMask;
        public float obstaclesDetectionDistance = 1f;
        public float obstaclesCheckFrequency = 1f;
        public Vector2 minimumRandomDirection = new Vector2(-1f, -1f);
        public Vector2 maximumRandomDirection = new Vector2(1f, 1f);
        public bool avoid180 = true;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMoveRandomlyGrid>();
            action.Label = label;
            action.Mode = mode;
            action.MaximumDurationInADirection = maximumDurationInADirection;
            action.ObstacleLayerMask = obstacleLayerMask;
            action.ObstaclesDetectionDistance = obstaclesDetectionDistance;
            action.ObstaclesCheckFrequency = obstaclesCheckFrequency;
            action.MinimumRandomDirection = minimumRandomDirection;
            action.MaximumRandomDirection = maximumRandomDirection;
            action.Avoid180 = avoid180;
            return action;
        }
    }
}