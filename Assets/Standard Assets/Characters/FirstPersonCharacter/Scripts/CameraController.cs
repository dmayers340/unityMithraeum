using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    public Vector3 Offset
    {
        get
        {
            return offset;
        }

        set
        {
            offset = value;
        }
    }

    void Start()
    {
        Offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + Offset;
    }
}
