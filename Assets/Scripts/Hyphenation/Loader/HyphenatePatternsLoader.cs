using UnityEngine; 
using System.Collections; 
namespace Hyphenation.Loader
{
    public interface HyphenatePatternsLoader
    {
        string LoadExceptions();
        string LoadPatterns();
    }
}