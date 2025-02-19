using UnityEngine;
using UnityEngine.Pool;

public class GameObjectPool : MonoBehaviour
{
    [SerializeField] private SpawnableObject _prefab;
    [SerializeField] private int _defaultCapacity;
    [SerializeField] private int _maxSize;

    private ObjectPool<SpawnableObject> _pool;

    private void Start()
    {
        _pool = new ObjectPool<SpawnableObject>(
            createFunc: () => Instantiate(_prefab, transform.position, Quaternion.identity),
            actionOnGet: (obj) => ActionOnGet(obj),
            actionOnRelease: (obj) => AcitionOnRelease(obj),
            actionOnDestroy: (obj) => Destroy(obj),
            collectionCheck: true,
            defaultCapacity: _defaultCapacity,
            maxSize: _maxSize
            );
    }

    public SpawnableObject Get() => _pool.Get();

    public void Release(SpawnableObject obj) => _pool.Release(obj);

    private void ActionOnGet(SpawnableObject obj)
    {
        obj.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        obj.gameObject.SetActive(true);
    }

    private void AcitionOnRelease(SpawnableObject obj)
    {
        obj.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        obj.gameObject.SetActive(false);
    }
}
