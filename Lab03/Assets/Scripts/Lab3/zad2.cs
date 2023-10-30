using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public Vector3 targetPosition;
    public Vector3 startPosition;

    void Start()
    {
        // Ustawienie pozycji startowej
        targetPosition = transform.position + new Vector3(10, 0, 0);
        startPosition = transform.position;
    }

    void Update()
    {
        // Przesunięcie obiektu do punktu docelowego
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Jeśli obiekt dotrze do pozycji docelowej, wróć do punktu startowego
        if (transform.position == targetPosition)
        {
            Vector3 temp = startPosition;
            startPosition = targetPosition;
            targetPosition = temp;
        }
    }
}