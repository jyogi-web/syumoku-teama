using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthGauge: MonoBehaviour
{
    [SerializeField] public Image healthImage;
    [SerializeField] private Image burnImage;
    [SerializeField] private GameObject gameclear;

    public float duration = 0.5f;
    public float strength = 20f;
    public int vibrate = 100;

    public float debugDamageRate = 0.1f;

    private float currentRate = 1f;

    private void Start()
    {
        SetGauge(1.0f);
    }

    public void SetGauge(float targetRate)
    {
        if(healthImage.fillAmount != 0)
        {
            // DoTween‚ð˜AŒ‹‚µ‚Ä“®‚©‚·
            healthImage.DOFillAmount(targetRate, duration)
                .OnComplete(() =>
                {
                    burnImage.DOFillAmount(targetRate, duration * 0.5f).SetDelay(0.5f);
                });
            transform.DOShakePosition(duration * 0.5f,
                strength, vibrate);

            currentRate = targetRate;

        }

    }

    public void TakeDamage(float rate)
    {
        SetGauge(currentRate - rate);
    }

    private void Update()
    {
        if (healthImage.fillAmount == 0)
        {
            gameclear.SetActive(true);
            Time.timeScale = 0f;   
        }
    }
}