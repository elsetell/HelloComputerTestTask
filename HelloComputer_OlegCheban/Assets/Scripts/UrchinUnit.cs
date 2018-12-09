using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrchinUnit : MonoBehaviour {
    private CircleCollider2D circCol;
    private float speedRotate;

    void Start()
    {
        circCol = GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        if (CheckGround())
            RotateToFeet();
    }
    bool CheckGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, circCol.radius);
        return (hit.collider != null && hit.collider.tag == "Ground") ? true : false;
    }
    void RotateToFeet()
    {
        Vector3 to = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime * speedRotate);
    }

}
