using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comments : MonoBehaviour
{
    public RawImage[] ImgCommentPos;
    public RawImage[] ImgCommentNeg;
    public Slider AudienceSlider;
    public RawImage DisplayComment;

    

    private void OnTriggerEnter(Collider other) {
       
        if (other.tag == "Hoop")
        {
          DisplayComment = ImgCommentPos[Random.Range(0,4)];
        }

        if (other.tag == "Obstical")
        {
           DisplayComment = ImgCommentNeg[Random.Range(0,4)];  
        }
    }
}
