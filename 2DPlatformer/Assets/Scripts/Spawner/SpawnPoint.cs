using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public void Spawn(SpawnableObject obj) =>
        obj.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
}
