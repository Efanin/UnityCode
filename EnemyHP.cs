using System.Collections;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private float hp = 100;
    [SerializeField] private float respawnTime = 1;
    private Vector3 startPosition;
    private float startHP;
    private void Start()
    {
        startPosition = transform.position;
        startHP = hp;
    }

    public void OnDamage(float damage)
    {
        hp-=damage;
        if (hp < 0)
            respawn();
    }
    private void respawn()
    {
        transform.position = startPosition;
        hp = startHP;
    }

}
