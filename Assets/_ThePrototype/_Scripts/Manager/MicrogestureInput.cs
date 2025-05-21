using System;
using UnityEngine;

namespace ThePrototype.Scripts.Manager
{
    public class MicrogestureInput : MonoBehaviour
    {
        public OVRHand ovrHand;
        private Vector2 _moveInput = Vector2.zero;
        public StarterAssets.StarterAssetsInputs inputs;

        private void Update()
        {
            OVRHand.MicrogestureType microgestureType = ovrHand.GetMicrogestureType();

            _moveInput = microgestureType switch
            {
                OVRHand.MicrogestureType.SwipeLeft => Vector2.left,
                OVRHand.MicrogestureType.SwipeRight => Vector2.right,
                OVRHand.MicrogestureType.SwipeForward => Vector2.up,
                OVRHand.MicrogestureType.SwipeBackward => Vector2.down,
                OVRHand.MicrogestureType.ThumbTap => Vector2.zero,
                _ => _moveInput
            };
            inputs.MoveInput(_moveInput);
        }
    }
}