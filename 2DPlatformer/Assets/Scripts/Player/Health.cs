using System;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class Health : MonoBehaviour, IDamageble
{
    private Player _player;

    public event Action Dead;
    public bool IsAlive { get; private set; } = true;

    private void Start()
    {
        _player = GetComponent<Player>();
        _player.Animator.SetBool("IsAlive", true);
    }

    public void TakeDamage()
    {
        if (IsAlive == false)
            return;

        IsAlive = false;
        _player.Animator.SetTrigger("Dead");
        Dead?.Invoke();
    }
}
