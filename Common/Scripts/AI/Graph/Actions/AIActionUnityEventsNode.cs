using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;
using UnityEngine.Events;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionUnityEvents"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Unity Events")]
    public class AIActionUnityEventsNode : AIActionNode
    {
        // targetEvent is hidden from inspector as it cannot be easily assigned at generation time
        // public UnityEvent targetEvent;
        public bool onlyPlayWhenEnteringState;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionUnityEvents>();
            action.Label = label;
            // action.TargetEvent = targetEvent;
            action.OnlyPlayWhenEnteringState = onlyPlayWhenEnteringState;
            return action;
        }

    }
}