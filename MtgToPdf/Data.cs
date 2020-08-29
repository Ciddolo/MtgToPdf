using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtgToPdf
{
    public class Data
    {
        public int BaseSetSize;
        public string Block;
        public Booster Booster;
        public Card[] Cards;
        public string Code;
        public string CodeV3;
        public bool IsForeignOnly;
        public bool IsFoilOnly;
        public bool IsNonFoilOnly;
        public bool IsOnlineOnly;
        public bool IsPaperOnly;
        public bool IsPartialPreview;
        public string KeyruneCode;
        public string McmName;
        public int McmId;
        public string MtgoCode;
        public string Name;
        public string ParentCode;
        public string ReleaseDate;
        public int TcgplayerGroupId;
        public Tokens[] Tokens;
        public int totalSetSize;
        public Translations Translations;
        public string Type;
    }
}
