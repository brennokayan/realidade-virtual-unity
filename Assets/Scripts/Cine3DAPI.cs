using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;

public class Cine3DAPI : MonoBehaviour
{
    public int index;
    public Text requestResult;

    public UserData userData;
    public RenderTexture videoRenderTexture; // Adicione esta linha para a RenderTexture

    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoPlayer.source = VideoSource.Url;

        // Configurações adicionais para renderização
        videoPlayer.renderMode = VideoRenderMode.RenderTexture;
        videoPlayer.targetTexture = videoRenderTexture;

        StartCoroutine(PlayCine3D());
    }

    public IEnumerator PlayCine3D()
    {
        string targetUrl = "http://localhost:3333/user/clwgo3xx8000b11gbo63pijbw"; // Substitua pela sua API real

        UnityWebRequest www = UnityWebRequest.Get(targetUrl);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            requestResult.text = www.error;
        }
        else
        {
            string jsonDownloader = www.downloadHandler.text;
            try
            {
                userData = JsonUtility.FromJson<UserData>(jsonDownloader);

                if (userData != null)
                {
                    // Acessando dados do usuário
                    Debug.Log("ID do usuário: " + userData.id);

                    // Acessando a lista de vídeos (se houver)
                    if (userData.Video != null && userData.Video.Count > 0)
                    {
                        Debug.Log("Número de vídeos: " + userData._count.Video);

                        // Acessando detalhes do primeiro vídeo (se houver)
                        var firstVideo = userData.Video[index];
                        Debug.Log("Nome do primeiro vídeo: " + firstVideo.name);
                        Debug.Log("URL do primeiro vídeo: " + firstVideo.url);
                        Debug.Log("Duração do primeiro vídeo: " + firstVideo.time);

                        // Configurar e reproduzir o vídeo
                        videoPlayer.url = firstVideo.url;
                        videoPlayer.Play();
                    }
                    else
                    {
                        Debug.Log("Nenhum vídeo encontrado na resposta.");
                    }

                    // Acessando a lista de luzes (se houver)
                    if (userData.Light != null && userData.Light.Count > 0)
                    {
                        Debug.Log("Nome da primeira luz: " + userData.Light[0].name);
                        Debug.Log("Cor da primeira luz: " + userData.Light[0].color);
                    }
                    else
                    {
                        Debug.Log("Nenhuma luz encontrada na resposta.");
                    }

                    // Acessando a lista de paredes (se houver)
                    if (userData.Wall != null && userData.Wall.Count > 0)
                    {
                        Debug.Log("Nome da primeira parede: " + userData.Wall[0].name);
                        Debug.Log("Cor da primeira parede: " + userData.Wall[0].color);
                    }
                    else
                    {
                        Debug.Log("Nenhuma parede encontrada na resposta.");
                    }
                }
                else
                {
                    Debug.Log("Erro ao interpretar os dados JSON.");
                }
            }
            catch (System.Exception e)
            {
                Debug.Log("Erro ao analisar JSON: " + e.Message);
            }
        }
    }
}
