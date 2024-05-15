using UnityEngine;
using UnityEngine.UI;

public class FinishController : MonoBehaviour
{
    [SerializeField] private GameObject _screenFinish;
    [SerializeField] private GameObject _screenLoss;
    [SerializeField] private Text _timerText;

    public float _gameTime;
    private bool _isFinish = false;
    private int _currentSceonds;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        ReverseTimer();
    }

    private void OnTriggerStay(Collider other)
    {
        _isFinish = true;
        Destroy(other);
        TurningOnTheScreen();
    }

    private void TurningOnTheScreen()
    {
        _screenFinish.SetActive(true);
    }

    private void ReverseTimer()
    {
        if (!_isFinish)
        {
            _gameTime -= Time.deltaTime;
            _currentSceonds = Mathf.FloorToInt(_gameTime % 60);
            _timerText.text = _currentSceonds.ToString();

            if (_gameTime <= 0)
            {
                _isFinish = true;
                Time.timeScale = 0;
                _timerText.text = 0.ToString();
                _screenLoss.SetActive(true);
            }
        }
    }
}
