using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtgToPdf
{
    public class Card
    {
        public string Artist;
        public string AsciiName;
        public string[] Availability;
        public string BorderColor;
        public string[] ColorIdentity;
        public string[] ColorIndicator;
        public string[] Colors;
        public float ConvertedManaCost;
        public int Count;
        public string DuelDeck;
        public int EdhrecRank;
        public float FaceConvertedManaCost;
        public string FaceName;
        public string FlavorName;
        public string FlavorText;
        public ForeignData[] ForeignData;
        public string[] FrameEffect;
        public string FrameVersion;
        public string Hand;
        public bool HasContentWarning;
        public bool HasFoil;
        public bool HasAlternativeDeckLimit;
        public bool HasNonFoil;
        public Identifiers Identifiers;
        public bool IsAlternative;
        public bool IsFoil;
        public bool IsFullArt;
        public bool IsOnlineOnly;
        public bool IsOversized;
        public bool IsPromo;
        public bool IsReprint;
        public bool IsReserved;
        public bool IsStarter;
        public bool IsStorySpotlight;
        public bool IsTextless;
        public bool IsTimeshifted;
        public string[] Keywords;
        public string Layout;
        public LeadershipSkills LeadershipSkills;
        public Legalities Legalities;
        public string Life;
        public string Loyalty;
        public string ManaCost;
        public string Name;
        public string Number;
        public string OriginalText;
        public string OriginalType;
        public string[] OtherFaceId;
        public string Power;
        public string[] Printings;
        public string[] PromoTypes;
        public PurchaseUrls PurchaseUrls;
        public string Rarity;
        public Rulings[] Rulings;
        public string SetCode;
        public string Side;
        public string[] Subtypes;
        public string[] Supertypes;
        public string Text;
        public string Toughness;
        public string Type;
        public string[] Types;
        public string Uuid;
        public string[] Variations;
        public string Watermark;

        public static int CompareByNumber(Card a, Card b)
        {
            int x;
            int y;

            int.TryParse(a.Number, out x);
            int.TryParse(b.Number, out y);

            return x.CompareTo(y);
        }
    }
}
