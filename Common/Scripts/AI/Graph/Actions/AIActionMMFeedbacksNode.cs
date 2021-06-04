using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionMMFeedbacks"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/MM Feedbacks")]
    public class AIActionMMFeedbacksNode : AIActionNode
    {
        // targetFeedbacks is hidden from inspector as it cannot be easily assigned at generation time
     //   public MMFeedbacks targetFeedbacks;
        public bool onlyPlayWhenEnteringState;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMMFeedbacks>();
            action.Label = label;
     //       action.TargetFeedbacks = targetFeedbacks;
            action.OnlyPlayWhenEnteringState = onlyPlayWhenEnteringState;
            return action;
        }
    }
}