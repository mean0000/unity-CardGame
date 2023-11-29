using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class XmlManager : MonoBehaviour
{
    public static XmlManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {
        //CreateXml();
    }


    public void CreateXml()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes"));

        XmlNode root = xmlDoc.CreateNode(XmlNodeType.Element, "UserInfo", string.Empty);
        xmlDoc.AppendChild(root);
        //사용자 임시이름, 메인레벨, 서브레벨, 기억력, 집중력, 순발력, 게임 종료 시간
        XmlNode child = xmlDoc.CreateNode(XmlNodeType.Element, "User", string.Empty);
        root.AppendChild(child);

        /// <----------------------------------------------   유저 정보   ---------------------------------------------->///

        XmlElement name = xmlDoc.CreateElement("Name");
        name.InnerText = ScreenCapture.userName;
        child.AppendChild(name);

        XmlElement main_level = xmlDoc.CreateElement("Main_level");
        main_level.InnerText = LevelManager.mainLevel.ToString();
        Debug.Log("main_level" + main_level);
        child.AppendChild(main_level);

        XmlElement sub_level = xmlDoc.CreateElement("Sub_level");
        sub_level.InnerText = LevelManager.subLevel.ToString();
        child.AppendChild(sub_level);

        /// <----------------------------------------------   쉬움 난이도   ---------------------------------------------->///

        XmlElement memory_score_easy = xmlDoc.CreateElement("Memory_score_easy");
        memory_score_easy.InnerText = ScoreManager.all_Memory_Score_Easy.ToString();
        child.AppendChild(memory_score_easy);

        XmlElement memory_score_normal = xmlDoc.CreateElement("Memory_score_normal");
        memory_score_normal.InnerText = ScoreManager.all_Memory_Score_Normal.ToString();
        child.AppendChild(memory_score_normal);

        XmlElement memory_score_hard = xmlDoc.CreateElement("Memory_score_hard");
        memory_score_hard.InnerText = ScoreManager.all_Memory_Score_Hard.ToString();
        child.AppendChild(memory_score_hard);

        /// <----------------------------------------------   노말 난이도   ---------------------------------------------->///

        XmlElement forcus_score_easy = xmlDoc.CreateElement("Forcus_score_easy");
        forcus_score_easy.InnerText = ScoreManager.all_Forcus_Score_Easy.ToString();
        child.AppendChild(forcus_score_easy);

        XmlElement forcus_score_normal = xmlDoc.CreateElement("Forcus_score_normal");
        forcus_score_normal.InnerText = ScoreManager.all_Forcus_Score_Normal.ToString();
        child.AppendChild(forcus_score_normal);

        XmlElement forcus_score_hard = xmlDoc.CreateElement("Forcus_score_hard");
        forcus_score_hard.InnerText = ScoreManager.all_Forcus_Score_Hard.ToString();
        child.AppendChild(forcus_score_hard);

        /// <----------------------------------------------   어려움 난이도   ---------------------------------------------->///

        XmlElement time_score_easy = xmlDoc.CreateElement("Time_score_easy");
        time_score_easy.InnerText = ScoreManager.all_Time_Score_Easy.ToString();
        child.AppendChild(time_score_easy);

        XmlElement time_score_normal = xmlDoc.CreateElement("Time_score_normal");
        time_score_normal.InnerText = ScoreManager.all_Time_Score_Normal.ToString();
        child.AppendChild(time_score_normal);

        XmlElement time_score_hard = xmlDoc.CreateElement("Time_score_hard");
        time_score_hard.InnerXml = ScoreManager.all_Time_Score_Hard.ToString();
        child.AppendChild(time_score_hard);

        /// <----------------------------------------------   기타   ---------------------------------------------->///

        XmlElement game_off_time = xmlDoc.CreateElement("Game_off_time");
        child.AppendChild(game_off_time);

        xmlDoc.Save("./Assets/Resources/UserInfo.xml");
    }

    public void SaveOverlapXml()
    {
        TextAsset textAsset = (TextAsset)Resources.Load("UserInfo");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(textAsset.text);

        XmlNodeList nodes = xmlDoc.SelectNodes("UserInfo/User");
        XmlNode userInfo = nodes[0];

        userInfo.SelectSingleNode("Name").InnerText = ScreenCapture.userName;
        userInfo.SelectSingleNode("Main_level").InnerText = LevelManager.mainLevel.ToString();
        userInfo.SelectSingleNode("Sub_level").InnerText = LevelManager.subLevel.ToString();

        userInfo.SelectSingleNode("Memory_score_easy").InnerText = ScoreManager.all_Memory_Score_Easy.ToString();
        userInfo.SelectSingleNode("Memory_score_normal").InnerText = ScoreManager.all_Memory_Score_Normal.ToString();
        userInfo.SelectSingleNode("Memory_score_hard").InnerText = ScoreManager.all_Memory_Score_Hard.ToString();

        userInfo.SelectSingleNode("Forcus_score_easy").InnerText = ScoreManager.all_Forcus_Score_Easy.ToString();
        userInfo.SelectSingleNode("Forcus_score_normal").InnerText = ScoreManager.all_Forcus_Score_Normal.ToString();
        userInfo.SelectSingleNode("Forcus_score_hard").InnerText = ScoreManager.all_Forcus_Score_Hard.ToString();

        userInfo.SelectSingleNode("Time_score_easy").InnerText = ScoreManager.all_Time_Score_Easy.ToString();
        userInfo.SelectSingleNode("Time_score_normal").InnerText = ScoreManager.all_Time_Score_Normal.ToString();
        userInfo.SelectSingleNode("Time_score_hard").InnerText = ScoreManager.all_Time_Score_Hard.ToString();

        userInfo.SelectSingleNode("Game_off_time").InnerText = "";
    }


    public void LoadXml()
    {
        TextAsset textAsset = (TextAsset)Resources.Load("UserInfo");
        Debug.Log(textAsset);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(textAsset.text);

        XmlNodeList nodes = xmlDoc.SelectNodes("UserInfo/User");
    }

}
