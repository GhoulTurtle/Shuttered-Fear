using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour{
    [Header("Required References")]
    [SerializeField] private Health playerHealth;
    
    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI statusText;
    [SerializeField] private Image statusImage;

    [Header("HealthUI Variables")]
    [SerializeField] private Color healthyColor = Color.blue;
    [SerializeField] private Color injuredColor = Color.cyan;
    [SerializeField] private Color warningColor = Color.yellow;
    [SerializeField] private Color criticalColor = Color.red;

    private void Awake() {
        playerHealth.OnHealthStateChanged += UpdateHealthUI;
    }

    private void OnDestroy() {
        playerHealth.OnHealthStateChanged -= UpdateHealthUI;
    }

    private void UpdateHealthUI(object sender, Health.HealthStateChangedEventArgs e){
        switch (e.healthState){
            case HealthState.Healthy:
                statusText.text = "HEALTHY";
                statusImage.color = healthyColor;
                break;
            case HealthState.Injured:
                statusText.text = "INJURED";
                statusImage.color = injuredColor;
                break;
            case HealthState.Warning:
                statusText.text = "WARNING";
                statusImage.color = warningColor;
                break;
            case HealthState.Critical:
                statusText.text = "CRITICAL";
                statusImage.color = criticalColor;
                break;
        }
    }
}