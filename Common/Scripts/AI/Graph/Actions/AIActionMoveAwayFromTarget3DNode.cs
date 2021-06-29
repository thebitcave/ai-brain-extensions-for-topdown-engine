using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMoveAwayFromTarget3D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/3D/Move Away From Target")]
    public class AIActionMoveAwayFromTarget3DNode : AIActionNode
    {
        public float maximumDistance = 10.0f;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMoveAwayFromTarget3D>();
            action.Label = label;
            action.MaximumDistance = maximumDistance;
            
            return action;
        }
    }
}