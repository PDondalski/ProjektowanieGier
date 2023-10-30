using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad5 : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfObjects = 10;
    public float planeWidth = 10f;
    public float planeLength = 10f;

    void Start()
    {
        List<Vector3> positions = new List<Vector3>();
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-planeWidth / 2, planeWidth / 2), 0, Random.Range(-planeLength / 2, planeLength / 2));
            while (positions.Exists(p => Vector3.Distance(pos, p) < prefab.transform.localScale.x))
            {
                pos = new Vector3(Random.Range(-planeWidth / 2, planeWidth / 2), 0, Random.Range(-planeLength / 2, planeLength / 2));
            }
            positions.Add(pos);
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
}