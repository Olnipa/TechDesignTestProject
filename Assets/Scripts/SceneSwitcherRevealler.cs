using System;
using UnityEngine;

public class SceneSwitcherRevealler : MonoBehaviour
{
    [SerializeField] private string _nextSceneName;

    public event Action<string> SceneSwitcherClicked;

    private void OnMouseDown()
    {
        SceneSwitcherClicked.Invoke(_nextSceneName);
    }
}
