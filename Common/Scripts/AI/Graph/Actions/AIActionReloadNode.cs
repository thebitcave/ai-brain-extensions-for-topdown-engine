using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionReload"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Reload")]
    public class AIActionReloadNode : AIActionNode
    {
        public bool onlyReloadOnceInThisState = true;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionReload>();
            action.Label = label;
            action.OnlyReloadOnceInThisSate = onlyReloadOnceInThisState;
            
            return action;
        }
    }
}