using System.Collections;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Start()
    {
        StartCoroutine(Rotate());
    }

    private IEnumerator Rotate()
    {
        while (true)
        {
            transform.Rotate(new Vector3(0f, _speed * Time.deltaTime, 0f));

            yield return null;
        }
    }
}
