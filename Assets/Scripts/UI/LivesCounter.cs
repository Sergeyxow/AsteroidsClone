using TMPro;
using UnityEngine;

namespace DefaultNamespace.UI
{
    public class LivesCounter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textBox;

        public void ChangeScore(int lives)
        {
            _textBox.text = "Lives: " + lives;
        }
    }
}