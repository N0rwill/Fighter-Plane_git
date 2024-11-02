using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      transform.Rotate(0, 0, 25f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -3f, 0) * Time.deltaTime * 2f);

        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }
}