using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad6_lerp : MonoBehaviour
{
    // Smooth towards the height of the target

    public Transform target;
    public float smoothTime = 0.3f;
    Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, target.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothTime);
    }
}
