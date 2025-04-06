using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform hedef;

    Vector3 mesafe = Vector3.zero;

    private void Start()
    {
        mesafe = transform.position - hedef.position;
    }

    private void LateUpdate()
    {
        transform.position = hedef.position+mesafe;
    }
}
