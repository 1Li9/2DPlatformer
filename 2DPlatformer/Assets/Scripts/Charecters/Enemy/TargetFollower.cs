using UnityEngine;

[RequireComponent(typeof(SpriteFlipper))]
public class TargetFollower : MonoBehaviour
{
    [SerializeField] private TargetsMap _map;
    [SerializeField] private float _speed;
    [Range(0f, 1f)]
    [SerializeField] private float _targetChangeDistanse;

    private SpriteFlipper _flipper;

    private void Start() =>
        _flipper = GetComponent<SpriteFlipper>();

    private void Update() =>
        Follow();

    private void Follow()
    {
        float xTargetPosition = _map.CurrentTarget.transform.position.x;
        float xDirection = xTargetPosition - transform.position.x;

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(xTargetPosition, transform.position.y), Time.deltaTime * _speed);

        if (Mathf.Abs(xDirection) <= _targetChangeDistanse)
            _map.SelectNextTarget();

        if(xDirection < 0f & _flipper.IsTurnedToRight | xDirection > 0f & _flipper.IsTurnedToRight == false)
            _flipper.Flip();
    }
}
