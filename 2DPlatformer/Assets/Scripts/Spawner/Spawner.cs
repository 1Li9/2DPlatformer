using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private SpawnPoint[] _points;
    [SerializeField] private float _timePeriod;

    private void Start()
    {
        if (_points.Length == 0)
            throw new System.ArgumentOutOfRangeException(nameof(_points) + " length is zero");

        _timer.DoActionRepeating(() => Spawn(), _timePeriod);
    }

    private void Spawn()
    {
        SpawnPoint currentPoint = GetRandomPoint();

        while(currentPoint.CanSpawn());
    }

    private SpawnPoint GetRandomPoint()
    {
        int pointIndex = Random.Range(0, _points.Length);
        return _points[pointIndex];
    }
}
