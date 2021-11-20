using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionRotateTowardsTarget2D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/2D/Rotate Towards Target")]
    public class AIActionRotateTowardsTarget2DNode : AIActionNode
    {

        public bool lockRotationX = false;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionRotateTowardsTarget2D>();
            action.Label = label;
            action.LockRotationX = lockRotationX;
            return action;
        }

    }
}