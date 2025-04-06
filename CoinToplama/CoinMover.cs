using UnityEngine;

public class CoinMover : MonoBehaviour
{
    public Vector3 donusHizi = new Vector3(180, 0, 0);

    public float speed = 2f;        // Hareket hýzý
    public float distance = 5f;     // Ne kadar ileri gidecek

    private Vector3 startPos;


    void Start()
    {
        startPos = transform.position;  // Baþlangýç pozisyonunu kaydet
    }

    void Update()
    {
        // Z ekseni boyunca ileri-geri hareket
        float x = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPos + new Vector3(x, 0, 0);

        transform.Rotate(donusHizi * Time.deltaTime);
    }
}

