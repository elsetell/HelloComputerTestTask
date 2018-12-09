using UnityEngine;

public class ScaleBackGround : MonoBehaviour
{
    //use sprite for BackGround or UI(StretchMax + Canvas RenderMode:ScSpaceCamera)
    void Start()
    {
        var sr = GetComponent<SpriteRenderer>();
        if (sr == null) return;

        var width = sr.sprite.bounds.size.x;
        var height = sr.sprite.bounds.size.y;

        float worldScreenHeight = Camera.main.orthographicSize * 2.0f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector3(worldScreenWidth / width, worldScreenHeight / height, 1);
    }
}
