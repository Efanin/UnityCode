using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] private float reload;
    [SerializeField] private float distance;
    [SerializeField] private float damage;


    private bool isReload = true;
    private void Update()
    {
        if (Input.GetAxis("Fire1") == 1 && isReload)
        {
            Vector3 origin = gameObject.transform.position;
            Vector3 direction = transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(origin, direction, out RaycastHit hit, distance))
            {
                if (hit.collider == true)
                {
                    lineRenderer.SetPosition(0, gameObject.transform.position);
                    lineRenderer.SetPosition(1, hit.point);
                    if(hit.collider.tag == "Enemy")
                    {
                        hit.collider.GetComponent<EnemyHP>().OnDamage(damage);
                    }
                }
            }
            isReload = false;
            StartCoroutine(delayReload());
        }
    }
    private IEnumerator delayReload()
    {
        yield return new WaitForSeconds(reload);
        isReload = true;
    }
}
