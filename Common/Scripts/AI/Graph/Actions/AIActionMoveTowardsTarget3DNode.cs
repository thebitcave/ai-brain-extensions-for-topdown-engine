using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMoveTowardsTarget3D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/3D/Move Towards Target")]
    public class AIActionMoveTowardsTarget3DNode : AIActionNode
    {
        public float minimumDistance = 1f;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMoveTowardsTarget3D>();
            action.Label = label;
            action.MinimumDistance = minimumDistance;
            return action;
        }
    }
}