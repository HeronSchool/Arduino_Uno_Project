using UnityEngine;
using System.IO.Ports;

public class Connect_Arduino : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM6", 9600);

    public static Connect_Arduino Instance;
    [Header("Data")]
    public string data = "0";
    public float val = 0;

    void OnEnable()
    {
        Instance = this;
    }

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 100;
    }

    void Update()
    {
        if (sp.IsOpen)
        {
            try{
                string data = sp.ReadLine();
                Debug.Log(data);
                val = float.Parse(data.Trim());
            }
            catch(System.Exception e){
                print(e);
            }
        }
    }

    private void OnApplicationQuit(){
        sp.Close();
    }
}
