using UnityEngine;

namespace DefaultNamespace
{
    public class Asteroid : MonoBehaviour
    {
        [SerializeField] private MoverBase _mover;
        public void SetMovementDirection(Vector2 direction)
        {
            _mover.AddForce(direction);
        }
    }
}