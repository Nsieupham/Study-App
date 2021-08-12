using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Excercide : MonoBehaviour
{
    [SerializeField] List<Text> datext;
    [SerializeField] List<Text> duphong;
    [SerializeField] Text CH;
    private GameObject NDLoader;
    public string text1;
    public int ar;
    public int u;


    public void Awake()
    {
        NDLoader = GameObject.Find("ND");
        ar = 0;
    }
    private void Start()
    {
        Hien();
        Gan();
        u = NDLoader.GetComponent<ND>().listCH.Count;
    }

    // Lấy ngẫu nhiên đáp án từ list
    public string HienDA()
    {
        string text2 = NDLoader.GetComponent<ND>().listDA
            [
            Random.Range(0, NDLoader.GetComponent<ND>().listDA.Count)
            ];
        return text2;
    }

    // Hiện đáp án ra text
    public void Hien()
    {
        // Hiện câu hỏi
        CH.text = NDLoader.GetComponent<ND>().listCH[ar];

        // Đáp án của câu hỏi
        text1 = NDLoader.GetComponent<ND>().listDA[ar];
        // Lấy ngẫu nhiên vị trí đáp án
        int vitri = Ran(0, 4);
        datext[vitri].text = text1;
        datext.RemoveAt(vitri);

        int vitri1 = Ran(0, 3);
        datext[vitri1].text = HienDA();
        datext.RemoveAt(vitri1);

        int vitri2 = Ran(0, 2);
        datext[vitri2].text = HienDA();
        datext.RemoveAt(vitri2);

        datext[0].text = HienDA();
        datext.RemoveAt(0);
    }
    public void Gan()
    {
        datext.AddRange(duphong);
    }    
    public int Ran(int min, int max)
    {
        int number = Random.Range(min, max);
        return number;
    }    
    public void Restart()
    {
        SceneManager.LoadScene("Start");
    }    
}
