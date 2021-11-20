using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionFaceTowardsTarget2D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/2D/Face Towards Target")]

    public class AIActionFaceTowardsTarget2DNode : AIActionNode
    {
        public AIActionFaceTowardsTarget2D.Modes mode = AIActionFaceTowardsTarget2D.Modes.LeftRight;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionFaceTowardsTarget2D>();
            action.Label = label;
            action.Mode = mode;
            return action;
        }
    }
}