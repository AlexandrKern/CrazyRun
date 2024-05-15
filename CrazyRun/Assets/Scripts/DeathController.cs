using UnityEngine;

public class DeathController : MonoBehaviour
{
    [SerializeField] private GameObject _deathEffect;
    [SerializeField] private GameObject _screenLoss;
    private bool _dead;
    private float _timerEffect = 3;

    private void OnTriggerStay(Collider other)
    {
        _dead = true;
        Destroy(other);
    }

    void Update()
    {
        TimerEffect();
    }

    private void TimerEffect()
    {
        if (_dead)
        {
            _timerEffect -= Time.deltaTime;
            _deathEffect.SetActive(true);
            if (_timerEffect <= 0)
            {
                _screenLoss.SetActive(true);
                _deathEffect.SetActive(false);
                _dead = false;
            }
        }
    }
}
