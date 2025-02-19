using UnityEngine;

[RequireComponent(typeof(Player))]
public abstract class PlayerComponent : MonoBehaviour
{
    protected Player Player;

    void Awake() =>
        Player = GetComponent<Player>();
}
