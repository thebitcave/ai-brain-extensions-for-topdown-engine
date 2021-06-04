using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionShoot2D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/2D/Shoot")]
    public class AIActionShoot2DNode : AIActionNode
    {
   //     [Header("Binding")] 
   //     public CharacterHandleWeapon targetHandleWeaponAbility;

        [Header("Behaviour")] 
        public AIActionShoot2D.AimOrigins aimOrigin = AIActionShoot2D.AimOrigins.Transform;
        public bool faceTarget = true;
        public bool aimAtTarget = false;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionShoot2D>();
   //         action.TargetHandleWeaponAbility = targetHandleWeaponAbility;
            action.AimOrigin = aimOrigin;
            action.FaceTarget = faceTarget;
            action.AimAtTarget = aimAtTarget;
            action.Label = label;
            return action;
        }
    }
}