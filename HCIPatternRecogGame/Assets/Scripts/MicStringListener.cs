using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class MicStringListener : MonoBehaviour
{
    public string[] keywords = new string[] { "test" };

    private KeywordRecognizer keywordRecognizer;
    void Start()
    {
        keywordRecognizer = new KeywordRecognizer(keywords, ConfidenceLevel.Medium);

        keywordRecognizer.OnPhraseRecognized += OnVoiceInputRecognized;

        keywordRecognizer.Start();
        Debug.Log("Voice recognition active.");
    }

    private void OnVoiceInputRecognized(PhraseRecognizedEventArgs args)
    {
        string spokenString = args.text;
        Debug.Log($"Voice input converted to string: {spokenString}");

        if(spokenString == "test")
        {
            Debug.Log("Correct input");
        }
    }

    private void OnApplicationQuit()
    {
        if(keywordRecognizer != null && keywordRecognizer.IsRunning)
        {
            keywordRecognizer.OnPhraseRecognized -= OnVoiceInputRecognized;
            keywordRecognizer.Stop();
        }
    }
}
