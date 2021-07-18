using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform oyuncu;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - oyuncu.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = oyuncu.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
