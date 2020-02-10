using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMovePatrol3D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/3D/Move Patrol")]
    public class AIActionMovePatrol3DNode : AIActionNode
    {
        [Header("Obstacle Detection")]
        public bool changeDirectionOnObstacle = true;
        public float obstacleDetectionDistance = 1f;
        public float obstaclesCheckFrequency = 1f;
        public LayerMask obstacleLayerMask;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMovePatrol3D>();
            action.Label = label;
            action.ChangeDirectionOnObstacle = changeDirectionOnObstacle;
            action.ObstacleDetectionDistance = obstacleDetectionDistance;
            action.ObstaclesCheckFrequency = obstaclesCheckFrequency;
            action.ObstacleLayerMask = obstacleLayerMask;
            return action;
        }
    }
}