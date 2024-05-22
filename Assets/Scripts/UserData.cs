using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public string id;
    public string role;
    public string name;
    public string email;
    public CountData _count;
    public List<VideosData> Video; // Lista de vídeos
    public List<LightsData> Light; // Lista de luzes
    public List<WallsData> Wall; // Lista de paredes

    [System.Serializable]
    public class CountData
    {
        public int Video;
        public int Light;
        public int Wall;
    }

    [System.Serializable]
    public class VideosData
    {
        public string name;
        public string url;
        public string time;
    }

    [System.Serializable]
    public class LightsData
    {
        public string name;
        public string color;
        public int ilumminence;
        public int range;
    }

    [System.Serializable]
    public class WallsData
    {
        public string name;
        public string color;
    }
}