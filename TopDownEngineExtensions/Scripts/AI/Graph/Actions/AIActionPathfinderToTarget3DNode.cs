using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionPathfinderToTarget3D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/3D/Pathfinder To Target")]
    public class AIActionPathfinderToTarget3DNode : AIActionNode
    {
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionPathfinderToTarget3D>();
            action.Label = label;
            return action;
        }
    }
}