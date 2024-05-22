using System.Collections;
using System.Collections.Generic;
using UnityEngine; // This is the missing directive
using UnityEngine.Video; // This is the missing directive

public class getURLVideo : MonoBehaviour
{

  private VideoPlayer videoPlayer;
  public string url;

  void Start()
  {
    videoPlayer = gameObject.AddComponent<VideoPlayer>();
    videoPlayer.source = VideoSource.Url;
    videoPlayer.url = url;
    videoPlayer.Play();
  }
}
