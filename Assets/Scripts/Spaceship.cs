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
            _mover.AddForce(movementInput * Time.deltaTime);
        }
    }
}