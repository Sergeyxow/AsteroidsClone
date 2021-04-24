using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DefaultNamespace
{
    public class Spaceship : MonoBehaviour
    {
        [SerializeField] private MoverBase _mover;
        [SerializeField] private PlayerInput _playerInput;

        private void Update()
        {
            Vector2 movementInput = _playerInput.currentActionMap["movement"].ReadValue<Vector2>();
            
            if (movementInput.y > 0f)
                _mover.AddForce(transform.up * (movementInput.y * Time.deltaTime));

            if (movementInput.x != 0f)
            {
                _mover.AddTorque(new Vector3(0f, 0f, -movementInput.x * Time.deltaTime));
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log(other);
        }
    }
}