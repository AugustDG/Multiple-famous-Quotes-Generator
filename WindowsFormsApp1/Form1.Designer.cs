namespace WindowsFormsApp1
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.QuotesText = new System.Windows.Forms.Label();
      this.generateButt = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // QuotesText
      // 
      this.QuotesText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.QuotesText.BackColor = System.Drawing.Color.Transparent;
      this.QuotesText.CausesValidation = false;
      this.QuotesText.Cursor = System.Windows.Forms.Cursors.Default;
      this.QuotesText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.QuotesText.Font = new System.Drawing.Font("Quicksand Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.QuotesText.Location = new System.Drawing.Point(137, 9);
      this.QuotesText.Name = "QuotesText";
      this.QuotesText.Size = new System.Drawing.Size(1443, 435);
      this.QuotesText.TabIndex = 0;
      this.QuotesText.Text = "[Quote] -[Author]";
      this.QuotesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // generateButt
      // 
      this.generateButt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.generateButt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.generateButt.FlatAppearance.BorderSize = 0;
      this.generateButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.generateButt.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.generateButt.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.generateButt.Location = new System.Drawing.Point(8, 9);
      this.generateButt.Name = "generateButt";
      this.generateButt.Size = new System.Drawing.Size(114, 435);
      this.generateButt.TabIndex = 1;
      this.generateButt.Text = "Generate";
      this.generateButt.UseVisualStyleBackColor = false;
      this.generateButt.Click += new System.EventHandler(this.QuoteText_Click);
      // 
      // Form1
      // 
      this.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.BackgroundImage = global::Quotes.Properties.Resources.blue_orange_fog_banner_background_1_;
      this.ClientSize = new System.Drawing.Size(1587, 456);
      this.Controls.Add(this.generateButt);
      this.Controls.Add(this.QuotesText);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quotes";
      this.Load += new System.EventHandler(this.LoadJson);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label QuotesText;
    private System.Windows.Forms.Button generateButt;
  }
}

