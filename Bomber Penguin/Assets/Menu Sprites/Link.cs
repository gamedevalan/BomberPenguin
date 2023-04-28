using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour
{

    public void OpenLinkHeatley()
    {
#if !UNITY_EDITOR 
        Debug.Log("P");
		OpenTab("https://www.youtube.com/user/HeatleyBros");
#endif
    }

    public void OpenLinkMyYoutube()
    {
#if !UNITY_EDITOR 
        OpenTab("https://www.youtube.com/channel/UCvhl4lva5m_kgnWMlr05-rw/featured");
#endif
    }

    public void OpenLinkMyInstagram()
    {
#if !UNITY_EDITOR 
        OpenTab("https://www.instagram.com/gamedev_alan/");
#endif
    }

    [DllImport("__Internal")]
    private static extern void OpenTab(string url);

}