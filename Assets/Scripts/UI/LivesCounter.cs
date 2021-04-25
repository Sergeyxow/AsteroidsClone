using TMPro;
using UnityEngine;

namespace Asteroids.UI
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