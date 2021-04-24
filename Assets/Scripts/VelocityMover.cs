using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class VelocityMover : MoverBase
    {
        [SerializeField] private float _drag;
        [SerializeField] private float _angularDrag;
        
        private Vector2 _velocity;
        private Vector2 _angularVelocity;
        
        public override void AddForce(Vector2 force)
        {
            _velocity += force;
        }

        public override void AddTorque(Vector2 torque)
        {
            _angularVelocity += torque;
        }

        private void Update()
        {
            _velocity = Vector2.Lerp(_velocity, Vector2.zero, _drag);
            _angularVelocity = Vector2.Lerp(_angularVelocity, Vector2.zero, _angularDrag);
        }
    }
}