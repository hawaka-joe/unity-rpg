using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset = new Vector3(0f, 0f, -10f);
    [Tooltip("0 = 每帧紧贴目标，越大越平滑")]
    [SerializeField] float smoothSpeed = 0f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desired = target.position + offset;
        if (smoothSpeed <= 0f)
            transform.position = desired;
        else
            transform.position = Vector3.Lerp(transform.position, desired, smoothSpeed * Time.deltaTime);
    }
}
