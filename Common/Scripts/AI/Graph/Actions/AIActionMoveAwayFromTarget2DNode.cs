using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMoveAwayFromTarget2D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/2D/Move Away From Target")]
    public class AIActionMoveAwayFromTarget2DNode : AIActionNode
    {
        public float maximumDistance = 5.0f;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMoveAwayFromTarget2D>();
            action.Label = label;
            action.MaximumDistance = maximumDistance;
            
            return action;
        }
    }
}