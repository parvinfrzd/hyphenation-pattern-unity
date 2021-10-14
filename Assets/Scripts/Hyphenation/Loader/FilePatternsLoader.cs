using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


namespace Hyphenation.Loader
{
    public class FilePatternsLoader : MonoBehaviour
    {
        private string _exceptionsFilePath;
        private string _patternsFilePath;
        public TextAsset patternFile; 
        public TextAsset exceptionFile; 
        
        void Awake() {
            _exceptionsFilePath = Application.dataPath + "/Resources/hyph-en-us.hyp.txt";
            _patternsFilePath = Application.dataPath + "/Resources/hyph-en-us.pat.txt";
        }

        void Start() {
            patternFile = Resources.Load<TextAsset>("hyph-en-us.pat"); 
            exceptionFile = Resources.Load<TextAsset>("hyph-en-us.hyp");//Resources.Load("./hyph-en-us.hyp") as TextAsset; 
        }

        public string LoadPatterns() => patternFile.ToString();//File.ReadAllText(_patternsFilePath);

        public string LoadExceptions() => exceptionFile.ToString();//_exceptionsFilePath == null ? null : File.ReadAllText(_exceptionsFilePath);

    }
}