using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class pause : MonoBehaviour{
    public VideoPlayer my_video;
    void OnMouseDown(){
        Debug.Log("�Ͻ����� ��ư ����");
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
