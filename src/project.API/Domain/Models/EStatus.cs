using System.ComponentModel;

namespace project.API.Domain.Models
{
    public enum EStatus : byte
    {
        [Description("N")]
        New = 1,

        [Description("D")]
        Draft = 2,

        [Description("F")]
        Final = 3

    }
}