using UnityEngine;
using UnityEngine.XR;

public class HMD_Manager : MonoBehaviour
{

    [SerializeField] GameObject xrPLayer;
    [SerializeField] GameObject fpsPLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Using Device:" + XRSettings.loadedDeviceName);
        if (XRSettings.isDeviceActive)
        {
            fpsPLayer.SetActive(false);
            xrPLayer.SetActive(true);
        }
        else
        {
            xrPLayer.SetActive(false);
            fpsPLayer.SetActive(true);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
