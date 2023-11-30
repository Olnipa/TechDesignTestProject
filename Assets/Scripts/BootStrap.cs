using UnityEngine;

public class BootStrap : MonoBehaviour
{
    [SerializeField] private SceneSwitchDetector _sceneSwitchDetector;

    [SerializeField] private SceneSwitcher _sceneSwitcher;
    //private CompositeDisposable _compositeDisposable;

    private void Start()
    {
        //_compositeDisposable = new CompositeDisposable();

        _sceneSwitcher.Initialize(_sceneSwitchDetector);
    }

    //private void OnDestroy()
    //{
    //    _compositeDisposable.DisposeAll();
    //}
}

//public class CompositeDisposable
//{
//    private List<IDisposable> _disposables = new List<IDisposable>();

//    public void Add(IDisposable disposable)
//    {
//        _disposables.Add(disposable);
//    }

//    public void DisposeAll()
//    {
//        foreach(IDisposable disposable in _disposables)
//        {
//            disposable.Dispose();
//        }
//    }
//}