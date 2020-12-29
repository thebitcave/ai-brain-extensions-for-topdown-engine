using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionSetLastKnownPositionAsTarget"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Set Last Known Position as Target")]
    public class AIActionSetLastKnownPositionAsTargetNode : AIActionNode
    {
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionSetLastKnownPositionAsTarget>();
            action.Label = label;
            return action;
        }
    }
}