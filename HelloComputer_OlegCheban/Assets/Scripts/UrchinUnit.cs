using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrchinUnit : MonoBehaviour {
    [SerializeField]
    private LifeUrchinSettings gSettings;

    private CircleCollider2D circCol;
    private Transform bodyUrchin;
    private Animator anim;
    private Rigidbody2D rb;

    void Start()
    {
        circCol = GetComponent<CircleCollider2D>();
        bodyUrchin = transform.Find("body");
        anim = bodyUrchin.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
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
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime * gSettings.speedRotate);
    }
    public void DropUrchin(float force)
    {
        anim.SetBool("Click", true);
        Vector2 direct = new Vector2(Random.Range(gSettings.directLeftLimit, gSettings.directRightLimit), 1);
        rb.AddForce(force * direct, ForceMode2D.Impulse);
    }

}
