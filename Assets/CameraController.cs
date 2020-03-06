using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothingAmmount = 0.125f;
    public Vector3 cameraOffset;

    private void FixedUpdate()
    {
        //transform.position = target.position + cameraOffset;
        transform.position = Vector3.Lerp(transform.position, target.position + cameraOffset, smoothingAmmount * Time.deltaTime);
    }
}
