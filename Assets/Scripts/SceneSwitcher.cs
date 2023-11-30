using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SceneSwitcher : MonoBehaviour
{
    private SceneSwitchDetector _sceneSwitchDetector;
    private Button _nextSceneButton;
    private string _nextSceneName;

    private void OnDisable()
    {
        _nextSceneButton.onClick.RemoveListener(OpenNextScene);
        _nextSceneButton = null;
    }

    private void OnDestroy()
    {
        _sceneSwitchDetector.SceneSwitcherClicked -= Activate;
    }

    public void Initialize(SceneSwitchDetector sceneSwitchDetector)
    {
        _sceneSwitchDetector = sceneSwitchDetector;
        _nextSceneButton = GetComponent<Button>();

        _sceneSwitchDetector.SceneSwitcherClicked += Activate;
    }

    public void Activate(string nextSceneName)
    {
        gameObject.SetActive(true);
        _nextSceneName = nextSceneName;
        _nextSceneButton.onClick.AddListener(OpenNextScene);
    }

    private void OpenNextScene()
    {
        if (_nextSceneName == null)
            return;

        SceneManager.LoadScene(_nextSceneName);
    }
}
