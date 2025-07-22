using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private Renderer rend;
    private Vector2 offset;

    void Start()
    {
        rend = GetComponent<Renderer>();
        offset = Vector2.zero;
    }

    void Update()
    {
        offset.x += scrollSpeed * Time.deltaTime;
        rend.material.mainTextureOffset = offset;
    }
}
