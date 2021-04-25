using TMPro;
using UnityEngine;

namespace DefaultNamespace.UI
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textBox;

        public void ChangeScore(int score)
        {
            _textBox.text = "Score: " + score;
        }
    }
}