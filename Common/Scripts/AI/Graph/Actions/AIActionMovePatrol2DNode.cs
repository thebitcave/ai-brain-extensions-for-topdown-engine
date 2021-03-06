﻿using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMovePatrol2D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/2D/Move Patrol")]
    public class AIActionMovePatrol2DNode : AIActionNode
    {
        [Header("Obstacle Detection")]
        public bool changeDirectionOnObstacle = true;
        public LayerMask obstaclesLayerMask;
        public float obstaclesCheckFrequency = 1f;
        
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMovePatrol2D>();
            action.Label = label;
            action.ChangeDirectionOnObstacle = changeDirectionOnObstacle;
            action.ObstaclesLayerMask = obstaclesLayerMask;
            action.ObstaclesCheckFrequency = obstaclesCheckFrequency;
            return action;
        }
    }
}