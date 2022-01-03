using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionSelfDestruct"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Self Destruct")]

    public class AIActionSelfDestructNode : AIActionNode
    {
        public bool onlyRunOnce = true;
        
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionSelfDestruct>();
            action.Label = label;
            action.OnlyRunOnce = onlyRunOnce;
            
            return action;
        }
    }
}