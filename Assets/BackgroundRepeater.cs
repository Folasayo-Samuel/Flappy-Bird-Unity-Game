using UnityEngine;

public class BackgroundRepeater : MonoBehaviour
{
public GameObject backgroundPrefab;
    public int repeatCount = 5;
    public float spacing = 2f;
    public float scrollSpeed = 1f;

    void Start()
    {
        Vector3 startPosition = transform.position;

        for (int i = 0; i < repeatCount; i++)
        {
            Vector3 position = startPosition + new Vector3(i * spacing, 0, 0);
            Instantiate(backgroundPrefab, position, Quaternion.identity, transform);
        }
    }
    
    void Update()
{
    transform.position += Vector3.left * scrollSpeed * Time.deltaTime;
}
}
