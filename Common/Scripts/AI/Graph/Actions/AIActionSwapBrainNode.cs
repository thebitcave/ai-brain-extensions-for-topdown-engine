using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionSwapBrain"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Swap Brain")]
    public class AIActionSwapBrainNode : AIActionNode
    {
        // newAIBrain is hidden from inspector as it cannot be easily assigned at generation time
        // public AIBrain newAIBrain;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionSwapBrain>();
            action.Label = label;
            // action.NewAIBrain = newAIBrain;
            return action;
        }
    }
}