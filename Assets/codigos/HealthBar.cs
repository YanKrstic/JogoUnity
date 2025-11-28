using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Image healthBarFill;
    void Start()
    {
        healthBarFill = this.GetComponent<Image>();
    }
    public void UpdateHealthBar(float currentHealth, float maxHealth)
    {
        healthBarFill.fillAmount = currentHealth / maxHealth;
    }

}
