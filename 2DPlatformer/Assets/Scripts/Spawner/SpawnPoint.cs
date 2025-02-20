using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private readonly int _cointsCount = 1;

    [SerializeField] private View _view;

    private bool _canSpawn = true;

    private void Awake() =>
        _view.gameObject.SetActive(false);  

    public int GetCoins()
    {
        if (_canSpawn)
            return 0;

        _view.gameObject.SetActive(false);
        _canSpawn = true;
        return _cointsCount;
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
