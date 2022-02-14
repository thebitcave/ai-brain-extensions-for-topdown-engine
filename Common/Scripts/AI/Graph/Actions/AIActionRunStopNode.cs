using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionRunStop"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/RunStop")]
    public class AIActionRunStopNode : AIActionNode
    {
        public bool onlyRunOnce = true;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionRunStop>();
            action.Label = label;
            action.OnlyRunOnce = onlyRunOnce;
            
            return action;
        }
    }
}