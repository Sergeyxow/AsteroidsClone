using UnityEngine;

namespace Asteroids
{
    public class DisableOnTrigger : MonoBehaviour
    {
        public void Trigger()
        {
            gameObject.SetActive(false);
        }
    }
}