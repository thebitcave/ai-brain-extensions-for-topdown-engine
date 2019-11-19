using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExtensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionAimWeaponAtMovement"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Aim Weapon At Movement")]
    public class AIActionAimWeaponAtMovementNode : AIActionNode
    {
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionAimWeaponAtMovement>();
            action.Label = label;
            return action;
        }
    }
}
