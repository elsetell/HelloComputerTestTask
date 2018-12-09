using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrchinControl : MonoBehaviour {
    public float minScale;
    public float maxScale;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            CreateUrchin();
        }
    }
    
    void CreateUrchin()
    {
        Vector2 posSpawn = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject urchin = (GameObject)Instantiate(Resources.Load("urchin"), posSpawn, Quaternion.identity);
        float scaleUrchin = Random.Range(minScale, maxScale);
        urchin.transform.localScale = new Vector3(scaleUrchin, scaleUrchin, scaleUrchin);
    }
}
