using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace.UI
{
    public class LoseScreen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreTextBox;
        [SerializeField] private Button _restartButton;

        public void Show(int score)
        {
            gameObject.SetActive(true);
            _scoreTextBox.text = "Score: " + score;
            _restartButton.onClick.AddListener( () => SceneManager.LoadScene(0));
        }
    }
}