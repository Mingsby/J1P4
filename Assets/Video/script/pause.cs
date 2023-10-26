using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class pause : MonoBehaviour{
    public VideoPlayer my_video;
    void OnMouseDown(){
        Debug.Log("일시정지 버튼 눌림");
        my_video.Pause();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
