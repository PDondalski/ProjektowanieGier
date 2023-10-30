using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad3 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public Vector3 targetPosition;
    public Vector3 startPosition;
    private int direction = 1;

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

        // Jeśli obiekt dotrze do pozycji docelowej, skręć i ustaw nowy cel
        if (transform.position == targetPosition)
        {
            if (direction == 1)
            {
                targetPosition = transform.position + new Vector3(0, 0, 10);
                direction = 2;
                // Obrócenie obiektu o 90 stopni w kierunku ruchu
                transform.Rotate(new Vector3(0f, -90f * (direction - 1), 0f));
            }
            else if (direction == 2)
            {
                targetPosition = transform.position + new Vector3(-10, 0, 0);
                direction = 3;
                transform.Rotate(new Vector3(0f, -90f * (direction - 2), 0f));
            }
            else if (direction == 3)
            {
                targetPosition = transform.position + new Vector3(0, 0, -10);
                direction = 4;
                transform.Rotate(new Vector3(0f, -90f * (direction - 3), 0f));
            }
            else if (direction == 4)
            {
                targetPosition = transform.position + new Vector3(10, 0, 0);
                direction = 1;
                transform.Rotate(new Vector3(0f, -90f * (direction - 4), 0f));
            }

        }
    }
}