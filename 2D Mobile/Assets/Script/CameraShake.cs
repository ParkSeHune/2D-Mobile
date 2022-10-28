using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private float endTime = 0;

    private Vector3 direction;

    private void Start()
    {
        direction = transform.localPosition;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(Shake(0.25f, 0.5f));
        }
    }

    public IEnumerator Shake(float magnitude, float duration)
    {
        while (endTime <= duration)
        {
            transform.localPosition = (Vector3)Random.insideUnitCircle * magnitude + direction;

            duration -= Time.deltaTime;

            yield return null;
        }

        transform.localPosition = direction;
    }
}