using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMovePatrol2D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Move Patrol 2D")]
    public class AIActionMovePatrol2DNode : AIActionNode
    {
        [Header("Obstacle Detection")]
        public bool changeDirectionOnObstacle = true;
        public LayerMask obstaclesLayerMask;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMovePatrol2D>();
            action.Label = label;
            action.ChangeDirectionOnObstacle = changeDirectionOnObstacle;
            action.ObstaclesLayerMask = obstaclesLayerMask;
            return action;
        }
    }
}