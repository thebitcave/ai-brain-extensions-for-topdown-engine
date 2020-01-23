using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionShoot3D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/3D/Shoot")]
    public class AIActionShoot3DNode : AIActionNode
    {
        public bool aimAtTarget = false;
        public Vector3 shootOffset;
        public bool lockVerticalAim = false;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionShoot3D>();
            action.AimAtTarget = aimAtTarget;
            action.ShootOffset = shootOffset;
            action.LockVerticalAim = lockVerticalAim;
            action.Label = label;
            return action;
        }
    }
}