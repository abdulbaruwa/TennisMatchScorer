using System.ComponentModel.DataAnnotations;
using Windows.UI.WebUI;

namespace TennisMatchScorer.ViewModel
{
    public enum FinalSetFormats
    {
        [Description("Normal")] 
        [Display(Name= "Normal")] 
        Normal, 

        [Description("10 Point Championship Tie Break")] 
        [Display(Name = "10 Point Championship Tie Break")] 
        TenPointChampionShipTieBreak
    }
}