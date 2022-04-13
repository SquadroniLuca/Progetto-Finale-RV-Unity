using System.Collections.Generic;

namespace Enums
{
    public enum TrashType
    {
        PAPER,
        PLASTIC,
        ORGANIC,
        GLASS,
        TIN,
        NONRECYCLABLE
    }

    public enum AudioClips
    {
        CORRECT,
        WRONG
    }
}
public static class Constants
{
    public static Dictionary<Enums.AudioClips,string> Clips = new Dictionary<Enums.AudioClips, string> {
            {Enums.AudioClips.CORRECT, "correctAction" },
            {Enums.AudioClips.WRONG, "wrongAction" }
        };

}
