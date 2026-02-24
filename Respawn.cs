using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private GameObject respawner;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = respawner.transform.position;
    }
}
