using Unity.VisualScripting;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    Camera mainCamera;
    bool basildimi = false;
    Vector3 offset;
    int odulpuani = 0;
    bool girdimi = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        basildimi = true;
        Debug.Log("Ben burdaydým.");
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - mousePosition;
    }
    private void OnMouseDrag()
    {
        if (basildimi)
        {
            Debug.Log("Buraya hiç gelmemeliydim");
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition + offset;
            if (transform.position.x > 3 && transform.position.x < 4)
            {
                if (transform.position.y > 3 && transform.position.y < 4)
                {
                    girdimi = true;
                }
            }
            else { girdimi=false;}
        }

    }

    private void OnMouseUp()
    {
        basildimi = false;
        if (girdimi) { odulpuani++;Debug.Log("Odul puanýn = " + odulpuani);girdimi = false; }
    }
}
