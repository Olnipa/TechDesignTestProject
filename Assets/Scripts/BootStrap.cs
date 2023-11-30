using UnityEngine;

public class BootStrap : MonoBehaviour
{
    [SerializeField] private SceneSwitcherRevealler _sceneSwitchDetector;
    [SerializeField] private SceneSwitcher _sceneSwitcher;

    private void Start()
    {
        _sceneSwitcher.Initialize(_sceneSwitchDetector);
    }

}