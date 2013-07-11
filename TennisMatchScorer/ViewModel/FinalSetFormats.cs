using System.ComponentModel.DataAnnotations;
using Windows.UI.WebUI;

namespace TennisMatchScorer.ViewModel
{
    public enum FinalSetFormats
    {
        [Description("Normal")] [Display(Name = "Normal")] Normal,

        [Description("10 Point Championship Tie Break")] [Display(Name = "10 Point Championship Tie Break")] TenPointChampionShipTieBreak
    }


    public enum SetsFormat
    {
        [Description("Short Set to Four")] ShortSetToFour,
        [Description("Normal Set to Six")] LongSetSix

    }

    public enum DueceFormat
    {
        [Description("Normal Dueuce lead by two")]
        Normal,
        [Description("Sudden death Dueuce first to two")]
        SuddenDeath
    }
}