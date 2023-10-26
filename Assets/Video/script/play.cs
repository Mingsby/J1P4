using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class play : MonoBehaviour{
    public VideoPlayer my_video;
    void OnMouseDown(){
        Debug.Log("재생 버튼 눌림");
        my_video.Play();
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
