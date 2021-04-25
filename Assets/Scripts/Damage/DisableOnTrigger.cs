using UnityEngine;

namespace DefaultNamespace
{
    public class DisableOnTrigger : MonoBehaviour
    {
        public void Trigger()
        {
            gameObject.SetActive(false);
        }
    }
}