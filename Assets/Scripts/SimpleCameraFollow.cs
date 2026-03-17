using UnityEngine;

public class SimpleCameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset = new Vector3(0, 3, -8);
    public float SmoothSpeed = 5f;

    private void LateUpdate()
    {
        Vector3 desiredPos = Target.position + Offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, SmoothSpeed * Time.deltaTime);
        Quaternion targetRot = Quaternion.LookRotation(Target.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, SmoothSpeed * Time.deltaTime);
    }
}
