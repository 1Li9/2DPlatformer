using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _view;

    private bool _canSpawn = true;

    private void Start() =>
        _view.gameObject.SetActive(false);

    public void Release()
    {
        if (_canSpawn)
            return;

        _view.gameObject.SetActive(false);
        _canSpawn = true;
    }

    public bool CanSpawn()
    {
        if (_canSpawn == false)
            return false;

        _view.gameObject.SetActive(true);
        _canSpawn = false;

        return true;
    }
}
