using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using iTextSharp.text.html.simpleparser;
using System.Reflection;
using System.Data.Common;

namespace MtgToPdf
{
    public partial class MainForm : Form
    {
        public SetList SetList;
        public Set JsonFile;
        public List<Card> ListOfCards;

        public const string MTGJSON_GENERIC_URL = "https://mtgjson.com/api/v5/";
        public const string SETS_INFO_URL = "https://mtgjson.com/api/v5/SetList.json";

        public const float D_WIDTH = 198.0f;
        public const float D_HEIGHT = 269.0f;

        public const float D_M_LEFT = 2.0f;
        public const float D_M_RIGHT = 0.0f;
        public const float D_M_TOP = 0.0f;
        public const float D_M_BOTTOM = 0.0f;

        public const float D_FONT_SIZE = 12.0f;

        public float PdfWidth = D_WIDTH;
        public float PdfHeight = D_HEIGHT;

        public float PdfMarginLeft = D_M_LEFT;
        public float PdfMarginRight = D_M_RIGHT;
        public float PdfMarginTop = D_M_TOP;
        public float PdfMarginBottom = D_M_BOTTOM;

        public float PdfFontSize = D_FONT_SIZE;

        //DEFAULT

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetList = new SetList();
            JsonFile = new Set();
            ListOfCards = new List<Card>();

            fontSize.Text = D_FONT_SIZE.ToString();

            width.Text = D_WIDTH.ToString();
            height.Text = D_HEIGHT.ToString();

            marginLeft.Text = D_M_LEFT.ToString();
            marginRight.Text = D_M_RIGHT.ToString();
            marginTop.Text = D_M_TOP.ToString();
            marginBottom.Text = D_M_BOTTOM.ToString();

            SetList = DownloadSetList();
            if (SetList == null)
            {
                MessageBox.Show("Impossible to download set list!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SetList.Data == null)
            {
                MessageBox.Show("Impossible to download set list!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < SetList.Data.Length; i++)
            {
                boxSetName.Items.Add(SetList.Data[i].Name);
            }
        }

        //MISCELLANEOUS
        
        private SetList DownloadSetList()
        {
            string jsonUrl = SETS_INFO_URL;

            using (var w = new WebClient())
            {
                var jsonData = string.Empty;
                try
                {
                    jsonData = w.DownloadString(jsonUrl);
                }
                catch (Exception) { }

                if (!string.IsNullOrEmpty(jsonData))
                    return JsonConvert.DeserializeObject<SetList>(jsonData);

                return null;
            }
        }

        private Set DownloadSet(string partialUrl)
        {
            string jsonUrl = String.Format("{0}{1}.json", MTGJSON_GENERIC_URL, partialUrl);

            using (var w = new WebClient())
            {
                var jsonData = string.Empty;
                try
                {
                    jsonData = w.DownloadString(jsonUrl);
                }
                catch (Exception) { }

                if (!string.IsNullOrEmpty(jsonData))
                    return JsonConvert.DeserializeObject<Set>(jsonData);

                return null;
            }
        }

        private void TestCreatePDF()
        {
            using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Rectangle mySize = new iTextSharp.text.Rectangle(PdfWidth, PdfHeight);
                    mySize.BackgroundColor = BaseColor.GRAY;
                    Document doc = new Document(mySize, PdfMarginLeft, PdfMarginRight, PdfMarginTop, PdfMarginBottom);

                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sdf.FileName, FileMode.Create));
                        doc.Open();
                        Paragraph text = new Paragraph("#00 Wildfire");
                        text.Font.Size = PdfFontSize;
                        doc.Add(text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        public bool LoadJson()
        {
            Directory.CreateDirectory(destinationPath.Text + "/" + boxSetName.Text);

            JsonFile = DownloadSet(setCode.Text);
            if (JsonFile == null)
            {
                MessageBox.Show("Error during json download!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string cards = "";
            foreach (Card card in JsonFile.Data.Cards)
            {
                ListOfCards.Add(card);
                cards += card.Number + " " + card.Name + "\n";
            }

            return true;
        }

        public string CreateFolder(string path, string name)
        {
            string newPath;

            if (name == "")
                name = "MtgToPdf";

            if (path == "")
                newPath = name;
            else
                newPath = path + @"\" + name;

            try
            {
                string currentUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                Directory.CreateDirectory(newPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return newPath;
        }

        //PDF

        public void CreateSetPDF(string path)
        {
            if (JsonFile.Data.Cards == null)
            {
                MessageBox.Show("Empty cards list!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (JsonFile.Data.Cards.Length <= 0)
                return;

            foreach (Card card in JsonFile.Data.Cards)
            {
                string text = card.Number + " " + card.Name;
                CreateCardPDF(path, card.Number + " " + card.Name, text);
            }
        }

        public Document CreateCardPDF(string path, string name, string text)
        {
            iTextSharp.text.Rectangle mySize = new iTextSharp.text.Rectangle(PdfWidth, PdfHeight);
            Document doc = new Document(mySize, PdfMarginLeft, PdfMarginRight, PdfMarginTop, PdfMarginBottom);

            try
            {
                string pdfPath = "";

                if (path == "")
                    pdfPath = name + ".pdf";
                else
                    pdfPath = path + @"\" + name + ".pdf";

                PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
                doc.Open();
                Paragraph paragraph = new Paragraph(text);
                paragraph.Font.Size = PdfFontSize;
                doc.Add(paragraph);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                doc.Close();
            }

            return doc;
        }

        public Document CreateUniquePDF(string path, string name)
        {
            if (JsonFile.Data.Cards == null)
            {
                MessageBox.Show("Empty cards list!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (JsonFile.Data.Cards.Length <= 0)
                return null;

            iTextSharp.text.Rectangle mySize = new iTextSharp.text.Rectangle(PdfWidth, PdfHeight);
            Document doc = new Document(mySize, PdfMarginLeft, PdfMarginRight, PdfMarginTop, PdfMarginBottom);

            string pdfPath = "";

            if (path == "")
                pdfPath = name + ".pdf";
            else
                pdfPath = path + @"\0 " + name + ".pdf";

            PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
            doc.Open();

            ListOfCards.Sort(Card.CompareByNumber);

            foreach (Card card in ListOfCards)
            {
                try
                {
                    string text = card.Number + " " + card.Name;
                    Paragraph paragraph = new Paragraph(text);
                    paragraph.Font.Size = PdfFontSize;
                    doc.Add(paragraph);
                    doc.NewPage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            doc.Close();

            return doc;
        }

        public void GetData()
        {
            if (!float.TryParse(fontSize.Text, out PdfFontSize))
            {
                PdfFontSize = D_FONT_SIZE;
                fontSize.Text = PdfFontSize.ToString();
            }

            if (!float.TryParse(width.Text, out PdfWidth))
            {
                PdfWidth = D_WIDTH;
                width.Text = PdfWidth.ToString();
            }
            if (!float.TryParse(height.Text, out PdfHeight))
            {
                PdfHeight = D_HEIGHT;
                height.Text = PdfHeight.ToString();
            }

            if (!float.TryParse(marginLeft.Text, out PdfMarginLeft))
            {
                PdfMarginLeft = D_M_LEFT;
                marginLeft.Text = PdfMarginLeft.ToString();
            }
            if (!float.TryParse(marginRight.Text, out PdfMarginRight))
            {
                PdfMarginRight = D_M_RIGHT;
                marginRight.Text = PdfMarginRight.ToString();
            }
            if (!float.TryParse(marginTop.Text, out PdfMarginTop))
            {
                PdfMarginTop = D_M_TOP;
                marginTop.Text = PdfMarginTop.ToString();
            }
            if (!float.TryParse(marginBottom.Text, out PdfMarginBottom))
            {
                PdfMarginBottom = D_M_BOTTOM;
                marginBottom.Text = PdfMarginBottom.ToString();
            }
        }

        //EVENTS

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!LoadJson())
                return;

            GetData();

            string folderPath = CreateFolder(destinationPath.Text, boxSetName.Text);
            CreateSetPDF(folderPath);
            CreateUniquePDF(folderPath, boxSetName.Text);
            MessageBox.Show("Complete", boxSetName.Text + " To Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void destinationPath_DoubleClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    destinationPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void jsonPath_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Json file|*.json", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    jsonPath.Text = ofd.FileName;
                }
            }
        }

        private void boxSetName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SetList == null)
            {
                MessageBox.Show("Set list missing!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SetList.Data == null)
            {
                MessageBox.Show("Set list missing!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < SetList.Data.Length; i++)
            {
                if (SetList.Data[i].Name == boxSetName.Text)
                {
                    setCode.Text = SetList.Data[i].Code;
                    return;
                }
            }
        }
    }
}
