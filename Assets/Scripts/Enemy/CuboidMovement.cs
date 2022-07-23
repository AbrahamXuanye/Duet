using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboidMovement : MonoBehaviour
{
    public float moveSpeed;
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -1*moveSpeed * Time.deltaTime, 0);
    }
}
