using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private RectTransform rt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    rt = GetComponent<RectTransform>();  
    }

    // Update is called once per frame
    void Update()
    {
        rt.anchoredPosition += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}
