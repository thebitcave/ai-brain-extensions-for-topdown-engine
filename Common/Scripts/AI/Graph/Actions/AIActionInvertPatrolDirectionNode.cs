using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionInvertPatrolDirection"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Invert Patrol Direction")]
    public class AIActionInvertPatrolDirectionNode : AIActionNode
    {
//        [Header("Invert Patrol Action Bindings")]
//        public AIActionMovePatrol2D movePatrol2D;
//        public AIActionMovePatrol3D movePatrol3D;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionInvertPatrolDirection>();
            action.Label = label;
//            action._movePatrol2D = movePatrol2D;
//            action._movePatrol3D = movePatrol3D;
            return action;
        }
    }
}