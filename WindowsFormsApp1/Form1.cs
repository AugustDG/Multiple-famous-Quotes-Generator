using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public List<Quotes> QuotesList;
    public List<int> QuotesNumbs = new List<int>();

    public Form1()
    {
      InitializeComponent();
    }

    public class Quotes
    {
      public string quoteAuthor { get; set; }
      public string quoteText { get; set; }
    }

    public void LoadJson(object sender, EventArgs e)
    {
      using (StreamReader r = new StreamReader("quotesFile.json"))
      {
        string json = r.ReadToEnd();
        QuotesList = JsonConvert.DeserializeObject<List<Quotes>>(json);
      }
    }

    private void QuoteText_Click(object sender, EventArgs e)
    {
      if (generateButt.Text == "Restart")
      {
        QuotesNumbs.Clear();
        generateButt.Text = "Generate";
      }
      Random random = new Random();
      int rnd = 0;

      while (QuotesNumbs.Exists(item => item == rnd))
      {
        rnd = random.Next(0, QuotesList.Count);
        if (QuotesNumbs.Count == QuotesList.Count - 1)
        {
          QuotesText.Text = "Sorry, no more quotes (you did read all " + QuotesList.Count.ToString() +" of them, right?)";
          generateButt.Text = "Restart";
          continue;
        }
      }

      if (QuotesList[rnd].quoteAuthor != "")
      {
        QuotesText.Text = QuotesList[rnd].quoteText + " -" + QuotesList[rnd].quoteAuthor;
      }else
      {
        QuotesText.Text = QuotesList[rnd].quoteText + " -Unknown";
      }
      QuotesNumbs.Add(rnd);
    }
  }
}
