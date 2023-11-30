using System;
using UnityEngine;
using UnityEngine.UI;

public class SceneSwitchDetector : MonoBehaviour
{
    [SerializeField] private string _nextSceneName;

    public event Action<string> SceneSwitcherClicked;

    private void OnMouseDown()
    {
        SceneSwitcherClicked.Invoke(_nextSceneName);
    }
}
