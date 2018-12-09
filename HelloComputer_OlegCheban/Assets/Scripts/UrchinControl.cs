using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrchinControl : MonoBehaviour {
    [SerializeField]
    private ControlUrchinSettings controllSettings;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            if (hit.collider != null && hit.collider.tag == "Urchin")
            {
                float force = Random.Range(controllSettings.minForce, controllSettings.maxForce);
                hit.transform.GetComponent<UrchinUnit>().DropUrchin(force);
            }
            else
            {
                CreateUrchin();
            }
        }
    }
    
    void CreateUrchin()
    {
        Vector2 posSpawn = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject urchin = (GameObject)Instantiate(Resources.Load("urchin"), posSpawn, Quaternion.identity);
        float scaleUrchin = Random.Range(controllSettings.minScale, controllSettings.maxScale);
        urchin.transform.localScale = new Vector3(scaleUrchin, scaleUrchin, scaleUrchin);
    }
}
