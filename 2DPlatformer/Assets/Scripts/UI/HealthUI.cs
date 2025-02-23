using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private Player _player;

    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Image _panel;

    [SerializeField] private float _opacityUpTime;

    private Coroutine _currentCoroutine;
    private float _maxOpacity = 1f;

    private void Awake()
    {
        _text.gameObject.SetActive(false);
        _panel.gameObject.SetActive(false);
    }

    private void OnEnable() =>
        _player.Dead += Show;

    private void OnDisable() =>
        _player.Dead -= Show;

    private void Show()
    {
        if(_currentCoroutine != null) 
            _timer.StopCoroutine(_currentCoroutine);

        _text.gameObject.SetActive(true);
        _panel.gameObject.SetActive(true);

        _currentCoroutine = _timer.DoActionRepeating(() => UpOpacity());
    }

    private void UpOpacity()
    {
        float currentAlpha = _panel.color.a;
        float alpha = Mathf.MoveTowards(currentAlpha, _maxOpacity, Time.deltaTime / _opacityUpTime);

        Color panelColor = _panel.color;
        panelColor.a = alpha;

        _panel.color = panelColor;

        Color textColor = _text.color;
        textColor.a = alpha;

        _text.color = textColor;

        if (alpha >= _maxOpacity)
            _timer.StopCoroutine(_currentCoroutine);
    }
}
