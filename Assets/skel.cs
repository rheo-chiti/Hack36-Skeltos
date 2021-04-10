using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hand,handText,leg,legText,spinalCord,spineText,skull,skullText,ribs,ribsText,wrist,wristText,pelvis,pelvisText,shoulder,shoulderText,feet,feetText,thigh,thighText;
    void Start()
    {
        hand.SetActive(true);
        handText.SetActive(false);
        leg.SetActive(false);
        legText.SetActive(false);
        spinalCord.SetActive(false);
        spineText.SetActive(false);
        skull.SetActive(false);
        skullText.SetActive(false);
        ribs.SetActive(false);
        ribsText.SetActive(false);
        wrist.SetActive(false);
        wristText.SetActive(false);
        pelvis.SetActive(false);
        pelvisText.SetActive(false);
        shoulder.SetActive(false);
        shoulderText.SetActive(false);
        feet.SetActive(false);
        feetText.SetActive(false);
        thigh.SetActive(false);
        thighText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
