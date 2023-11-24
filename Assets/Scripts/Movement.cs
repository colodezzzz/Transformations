using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    private float _direction;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
        _direction = 1f;
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (true)
        {
            if (transform.position.z < _startPosition.z - _distance)
            {
                _direction = 1f;
            }
            else if (transform.position.z > _startPosition.z + _distance)
            {
                _direction = -1f;
            }

            transform.Translate(transform.forward * _direction * _speed * Time.deltaTime);

            yield return null;
        }
    }
}
