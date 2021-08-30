using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    void FixedUpdate()
    {
        Vector3 dPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, dPosition, smoothSpeed);
        transform.position = smoothPosition;
    }

}
