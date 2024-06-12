using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    private const int NumberScene = 0;

    [SerializeField] private Button _exitGameButton;

    private void OnEnable() => _exitGameButton.onClick?.AddListener(OnClickExitGame);

    private void OnDisable() => _exitGameButton.onClick?.RemoveListener(OnClickExitGame);

    private void OnClickExitGame() => SceneManager.LoadScene(NumberScene);
}