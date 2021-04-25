using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class VelocityMover : MoverBase
    {

        [Header("Velocity")]
        [SerializeField] private float _speed;
        [SerializeField] private float _drag;
        [SerializeField] private float _velocityLimit;
        
        [Header("Angular velocity")]
        [SerializeField] private float _angularSpeed;
        [SerializeField] private float _angularDrag;
        [SerializeField] private float _angularVelocityLimit;
        
        private Vector3 _velocity;
        private Vector3 _angularVelocity;
        
        public override void AddForce(Vector3 force)
        {
            if (_velocity.magnitude < _velocityLimit || _velocityLimit == 0f)
                _velocity += force * _speed;
        }

        public override void AddTorque(Vector3 torque)
        {
            if (_angularVelocity.magnitude < _angularVelocityLimit || _angularVelocityLimit == 0f)
                _angularVelocity += torque * (_angularSpeed * 100f);
        }

        protected virtual void Update()
        {
            transform.position += _velocity * Time.deltaTime;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles +  _angularVelocity * Time.deltaTime);

            _velocity = Vector3.Lerp(_velocity, Vector2.zero, _drag * Time.deltaTime);
            _angularVelocity = Vector3.Lerp(_angularVelocity, Vector2.zero, _angularDrag * Time.deltaTime);
        }
    }
}