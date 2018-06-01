using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    public DataMain mainData;


    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public DataMain GetCurrentRoundData()
    {
        return mainData;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
