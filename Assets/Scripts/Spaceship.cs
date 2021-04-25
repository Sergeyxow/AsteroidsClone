using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DefaultNamespace
{
    public class Spaceship : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private MoverBase _mover;
        [SerializeField] private PlayerInput _playerInput;
        
        [Header("Shooting")]
        [SerializeField] private Fireable _bulletPrefab;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private int _bulletsPerSecond;

        private float _shotDelay;
        private float _shotTimer;

        private void Start()
        {
            _shotDelay = 1f / _bulletsPerSecond;
        }

        private void Update()
        {
            Vector2 movementInput = _playerInput.currentActionMap["movement"].ReadValue<Vector2>();
            SetMovement(movementInput);

            bool attackHeld = _playerInput.currentActionMap["attack"].ReadValue<float>() > 0;
            if (attackHeld) Attack();

            if (_shotTimer > 0f)
                _shotTimer -= Time.deltaTime;

        }

        private void SetMovement(Vector2 movementInput)
        {
            if (movementInput.y > 0f)
                _mover.AddForce(transform.up * (movementInput.y * Time.deltaTime));

            if (movementInput.x != 0f)
            {
                _mover.AddTorque(new Vector3(0f, 0f, -movementInput.x * Time.deltaTime));
            }
        }

        private void Attack()
        {
            if (_shotTimer <= 0f)
            {
                _shotTimer = _shotDelay;
                Fireable bullet = Instantiate(_bulletPrefab, _shootPoint.position, _shootPoint.rotation);
                bullet.SetMovementDirection(_shootPoint.up);
            }
        }

        public void Respawn()
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
        }

    }
}