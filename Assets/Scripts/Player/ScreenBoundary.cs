using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundary : MonoBehaviour
{
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 objPos = transform.position;
        objPos.x = Mathf.Clamp(objPos.x, screenBounds.x * -1, screenBounds.x);
        objPos.y = Mathf.Clamp(objPos.y, screenBounds.y * -1, screenBounds.y);
        transform.position = objPos;
    }
}
