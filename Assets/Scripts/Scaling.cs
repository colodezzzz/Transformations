using System.Collections;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxScale;

    private float _minScale;
    private float _currentScale;
    private float _scaleFactor;

    void Start()
    {
        _minScale = transform.localScale.x;
        _currentScale = _minScale;
        _scaleFactor = 1f;
        StartCoroutine(Scale());
    }

    private IEnumerator Scale()
    {
        while (true)
        {
            if (_currentScale > _maxScale)
            {
                _scaleFactor = -1f;
            }
            else if (_currentScale < _minScale)
            {
                _scaleFactor = 1f;
            }

            _currentScale += _speed * Time.deltaTime * _scaleFactor;

            transform.localScale = Vector3.one * _currentScale;

            yield return null;
        }
    }
}
