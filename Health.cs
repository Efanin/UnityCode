using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private int health;
    public UnityEvent OnDeath;
    private void Start()
    {
        ChangeHealth(0);
    }
    public void ChangeHealth(int damage)
    {
        health -= damage;
        healthText.text = health.ToString();
        healthSlider.value = health;
        if(health<=0)
        {
            OnDeath.Invoke();
        }
    }

}
