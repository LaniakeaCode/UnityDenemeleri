using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int toplamPuan = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PuanArttir (int puanMiktari)
    {
        toplamPuan += puanMiktari;
    }
}
