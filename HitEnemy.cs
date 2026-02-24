using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class HitEnemy : MonoBehaviour
{
    [SerializeField] private int Damage;
    public UnityEvent<int> OnDamage;
    private bool stay;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(WaitDamage());
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            stay = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            stay = false;
        }
    }
    private IEnumerator WaitDamage()
    {
        yield return new WaitForSeconds(0.7f);
        if (stay)
        {
            OnDamage.Invoke(Damage);
            StartCoroutine(WaitDamage());
        }
    }
}
