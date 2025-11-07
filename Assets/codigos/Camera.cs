/*using UnityEngine;

public class Camera : MonoBehaviour
{

    [Header("Follow Settings")]
    public Transform target;
    public float smoothTime = 0.3f;
    public Vector3 offset = new Vector3(0, 0, -10);

    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {

        if (target == null)
        {
            Debug.LogWarning("target indisponivel");
        }

        Vector3 targetPosition = target.position + offset;
        targetPosition.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(
            tranform.position,
            targetpPosition,
            ref velocity,
            smoothTime

        );


    }
}
*/
using UnityEngine;

public class Camera2DFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
    public Vector3 offset = new Vector3(0, 0, -10);

    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        if (target == null) return;

        Vector3 targetPosition = target.position + offset;
        targetPosition.z = transform.position.z; // Mantém Z constante

        transform.position = Vector3.SmoothDamp(
            transform.position,
            targetPosition,
            ref velocity,
            smoothTime
        );
    }
}