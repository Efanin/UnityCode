using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private GameObject respawner;
    private void OnTriggerEnter(Collider other)
    {
        respawner.transform.position = transform.position;
        Destroy(gameObject);
    }
}
