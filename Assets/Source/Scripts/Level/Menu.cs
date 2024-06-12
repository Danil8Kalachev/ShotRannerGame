using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private const int NumberGameScene = 1;

    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _settingsGameButton;
    [SerializeField] private Button _exitGameButton;
    [SerializeField] private TextMeshProUGUI _settingsText;

    private void OnEnable()
    {
        _startGameButton.onClick?.AddListener(OnStartGameButton);
        _settingsGameButton.onClick?.AddListener(OnSettingsGameButton);
        _exitGameButton.onClick?.AddListener(OnExitGameButton);
    }

    private void OnDisable()
    {
        _startGameButton.onClick?.RemoveListener(OnStartGameButton);
        _settingsGameButton.onClick?.RemoveListener(OnSettingsGameButton);
        _exitGameButton.onClick?.RemoveListener(OnExitGameButton);
    }

    private void OnStartGameButton() => SceneManager.LoadScene(NumberGameScene);

    private void OnSettingsGameButton() => _settingsText.gameObject.SetActive(true);

    private void OnExitGameButton() => Application.Quit();
}