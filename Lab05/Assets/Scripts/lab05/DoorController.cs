using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject doors;
    public GameObject detectorFront;
    public GameObject detectorBack;
    public float distanceThreshold = 2.0f;
    public float doorSpeed = 1.0f;

    private bool areDoorsOpen = false;

    void Update()
    {
        if (areDoorsOpen)
        {
            return;
        }

        if (Vector3.Distance(detectorFront.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < distanceThreshold || Vector3.Distance(detectorBack.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < distanceThreshold)
        {
            doors.transform.Translate(Vector3.right * doorSpeed * Time.deltaTime);
            areDoorsOpen = true;
        }
    }
}