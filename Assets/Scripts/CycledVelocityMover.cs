using UnityEngine;

namespace DefaultNamespace
{
    public class CycledVelocityMover : VelocityMover
    {
        
        [SerializeField] private float _squareHalfSide = 5f;
        protected override void Update()
        {
            base.Update();

            Vector3 position = transform.position;
            
            float signX = Mathf.Sign(position.x);
            if (Mathf.Abs(position.x) > _squareHalfSide)
            {
                position.x = -signX * _squareHalfSide;
            }
            
            float signY = Mathf.Sign(position.y);
            if (Mathf.Abs(position.y) > _squareHalfSide)
            {
                position.y = -signY * _squareHalfSide;
            }

            transform.position = position;
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireCube(Vector3.zero, Vector3.one * _squareHalfSide * 2f);
        }
    }
}