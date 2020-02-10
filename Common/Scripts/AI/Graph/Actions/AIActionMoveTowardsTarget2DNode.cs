using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMoveTowardsTarget2D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/2D/Move Towards Target")]
    public class AIActionMoveTowardsTarget2DNode : AIActionNode
    {
        public float minimumDistance = 1f;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMoveTowardsTarget2D>();
            action.Label = label;
            action.MinimumDistance = minimumDistance;
            return action;
        }
    }
}