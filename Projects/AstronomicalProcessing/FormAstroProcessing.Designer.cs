namespace AstronomicalProcessing
{
    partial class FormAstroProcessing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAstroProcessing));
            this.textBoxObservedWavelength = new System.Windows.Forms.TextBox();
            this.textBoxRestWavelength = new System.Windows.Forms.TextBox();
            this.textBoxParallaxAngle = new System.Windows.Forms.TextBox();
            this.textBoxTempInCelsius = new System.Windows.Forms.TextBox();
            this.labelTempInCelsius = new System.Windows.Forms.Label();
            this.labelParallaxAngle = new System.Windows.Forms.Label();
            this.labelObservedWavelength = new System.Windows.Forms.Label();
            this.labelRestWavelength = new System.Windows.Forms.Label();
            this.labelBlackholeMass = new System.Windows.Forms.Label();
            this.groupBoxStarVelocity = new System.Windows.Forms.GroupBox();
            this.groupBoxStarDistance = new System.Windows.Forms.GroupBox();
            this.groupBoxTempInKelvin = new System.Windows.Forms.GroupBox();
            this.groupBoxEventHorizon = new System.Windows.Forms.GroupBox();
            this.textBoxBlackHoleMass = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.columnHeaderStarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStarDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTempInKelvin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFeedback = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxGuiCustomization = new System.Windows.Forms.GroupBox();
            this.buttonNightMode = new System.Windows.Forms.Button();
            this.buttonDayMode = new System.Windows.Forms.Button();
            this.buttonFrenchFlag = new System.Windows.Forms.Button();
            this.buttonEnglishFlag = new System.Windows.Forms.Button();
            this.buttonGermanFlag = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutscheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishUKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxStarVelocity.SuspendLayout();
            this.groupBoxStarDistance.SuspendLayout();
            this.groupBoxTempInKelvin.SuspendLayout();
            this.groupBoxEventHorizon.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxGuiCustomization.SuspendLayout();
            this.menuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxObservedWavelength
            // 
            resources.ApplyResources(this.textBoxObservedWavelength, "textBoxObservedWavelength");
            this.textBoxObservedWavelength.Name = "textBoxObservedWavelength";
            this.toolTip.SetToolTip(this.textBoxObservedWavelength, resources.GetString("textBoxObservedWavelength.ToolTip"));
            this.textBoxObservedWavelength.Click += new System.EventHandler(this.textBoxObservedWavelength_Click);
            // 
            // textBoxRestWavelength
            // 
            resources.ApplyResources(this.textBoxRestWavelength, "textBoxRestWavelength");
            this.textBoxRestWavelength.Name = "textBoxRestWavelength";
            this.toolTip.SetToolTip(this.textBoxRestWavelength, resources.GetString("textBoxRestWavelength.ToolTip"));
            this.textBoxRestWavelength.Click += new System.EventHandler(this.textBoxObservedWavelength_Click);
            // 
            // textBoxParallaxAngle
            // 
            resources.ApplyResources(this.textBoxParallaxAngle, "textBoxParallaxAngle");
            this.textBoxParallaxAngle.Name = "textBoxParallaxAngle";
            this.toolTip.SetToolTip(this.textBoxParallaxAngle, resources.GetString("textBoxParallaxAngle.ToolTip"));
            this.textBoxParallaxAngle.Click += new System.EventHandler(this.textBoxObservedWavelength_Click);
            // 
            // textBoxTempInCelsius
            // 
            resources.ApplyResources(this.textBoxTempInCelsius, "textBoxTempInCelsius");
            this.textBoxTempInCelsius.Name = "textBoxTempInCelsius";
            this.toolTip.SetToolTip(this.textBoxTempInCelsius, resources.GetString("textBoxTempInCelsius.ToolTip"));
            this.textBoxTempInCelsius.Click += new System.EventHandler(this.textBoxObservedWavelength_Click);
            // 
            // labelTempInCelsius
            // 
            resources.ApplyResources(this.labelTempInCelsius, "labelTempInCelsius");
            this.labelTempInCelsius.Name = "labelTempInCelsius";
            // 
            // labelParallaxAngle
            // 
            resources.ApplyResources(this.labelParallaxAngle, "labelParallaxAngle");
            this.labelParallaxAngle.Name = "labelParallaxAngle";
            // 
            // labelObservedWavelength
            // 
            resources.ApplyResources(this.labelObservedWavelength, "labelObservedWavelength");
            this.labelObservedWavelength.Name = "labelObservedWavelength";
            // 
            // labelRestWavelength
            // 
            resources.ApplyResources(this.labelRestWavelength, "labelRestWavelength");
            this.labelRestWavelength.Name = "labelRestWavelength";
            // 
            // labelBlackholeMass
            // 
            resources.ApplyResources(this.labelBlackholeMass, "labelBlackholeMass");
            this.labelBlackholeMass.Name = "labelBlackholeMass";
            // 
            // groupBoxStarVelocity
            // 
            this.groupBoxStarVelocity.Controls.Add(this.labelObservedWavelength);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxObservedWavelength);
            this.groupBoxStarVelocity.Controls.Add(this.labelRestWavelength);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxRestWavelength);
            resources.ApplyResources(this.groupBoxStarVelocity, "groupBoxStarVelocity");
            this.groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            this.groupBoxStarVelocity.TabStop = false;
            // 
            // groupBoxStarDistance
            // 
            this.groupBoxStarDistance.Controls.Add(this.labelParallaxAngle);
            this.groupBoxStarDistance.Controls.Add(this.textBoxParallaxAngle);
            resources.ApplyResources(this.groupBoxStarDistance, "groupBoxStarDistance");
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.TabStop = false;
            // 
            // groupBoxTempInKelvin
            // 
            this.groupBoxTempInKelvin.Controls.Add(this.labelTempInCelsius);
            this.groupBoxTempInKelvin.Controls.Add(this.textBoxTempInCelsius);
            resources.ApplyResources(this.groupBoxTempInKelvin, "groupBoxTempInKelvin");
            this.groupBoxTempInKelvin.Name = "groupBoxTempInKelvin";
            this.groupBoxTempInKelvin.TabStop = false;
            // 
            // groupBoxEventHorizon
            // 
            this.groupBoxEventHorizon.Controls.Add(this.textBoxBlackHoleMass);
            this.groupBoxEventHorizon.Controls.Add(this.labelBlackholeMass);
            resources.ApplyResources(this.groupBoxEventHorizon, "groupBoxEventHorizon");
            this.groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            this.groupBoxEventHorizon.TabStop = false;
            // 
            // textBoxBlackHoleMass
            // 
            resources.ApplyResources(this.textBoxBlackHoleMass, "textBoxBlackHoleMass");
            this.textBoxBlackHoleMass.Name = "textBoxBlackHoleMass";
            this.toolTip.SetToolTip(this.textBoxBlackHoleMass, resources.GetString("textBoxBlackHoleMass.ToolTip"));
            this.textBoxBlackHoleMass.Click += new System.EventHandler(this.textBoxObservedWavelength_Click);
            // 
            // buttonCalculate
            // 
            resources.ApplyResources(this.buttonCalculate, "buttonCalculate");
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStarVelocity,
            this.columnHeaderStarDistance,
            this.columnHeaderTempInKelvin,
            this.columnHeaderEventHorizon});
            this.listViewResults.HideSelection = false;
            resources.ApplyResources(this.listViewResults, "listViewResults");
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStarVelocity
            // 
            resources.ApplyResources(this.columnHeaderStarVelocity, "columnHeaderStarVelocity");
            // 
            // columnHeaderStarDistance
            // 
            resources.ApplyResources(this.columnHeaderStarDistance, "columnHeaderStarDistance");
            // 
            // columnHeaderTempInKelvin
            // 
            resources.ApplyResources(this.columnHeaderTempInKelvin, "columnHeaderTempInKelvin");
            // 
            // columnHeaderEventHorizon
            // 
            resources.ApplyResources(this.columnHeaderEventHorizon, "columnHeaderEventHorizon");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelFeedback});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabelFeedback
            // 
            this.toolStripStatusLabelFeedback.Name = "toolStripStatusLabelFeedback";
            resources.ApplyResources(this.toolStripStatusLabelFeedback, "toolStripStatusLabelFeedback");
            // 
            // groupBoxGuiCustomization
            // 
            this.groupBoxGuiCustomization.Controls.Add(this.buttonNightMode);
            this.groupBoxGuiCustomization.Controls.Add(this.buttonDayMode);
            this.groupBoxGuiCustomization.Controls.Add(this.buttonFrenchFlag);
            this.groupBoxGuiCustomization.Controls.Add(this.buttonEnglishFlag);
            this.groupBoxGuiCustomization.Controls.Add(this.buttonGermanFlag);
            this.groupBoxGuiCustomization.Controls.Add(this.buttonFont);
            this.groupBoxGuiCustomization.Controls.Add(this.buttonBackground);
            this.groupBoxGuiCustomization.Controls.Add(this.comboBoxStyle);
            this.groupBoxGuiCustomization.Controls.Add(this.comboBoxLanguage);
            resources.ApplyResources(this.groupBoxGuiCustomization, "groupBoxGuiCustomization");
            this.groupBoxGuiCustomization.Name = "groupBoxGuiCustomization";
            this.groupBoxGuiCustomization.TabStop = false;
            // 
            // buttonNightMode
            // 
            resources.ApplyResources(this.buttonNightMode, "buttonNightMode");
            this.buttonNightMode.Name = "buttonNightMode";
            this.buttonNightMode.UseVisualStyleBackColor = true;
            this.buttonNightMode.Click += new System.EventHandler(this.buttonNightMode_Click);
            // 
            // buttonDayMode
            // 
            resources.ApplyResources(this.buttonDayMode, "buttonDayMode");
            this.buttonDayMode.Name = "buttonDayMode";
            this.buttonDayMode.UseVisualStyleBackColor = true;
            this.buttonDayMode.Click += new System.EventHandler(this.buttonDayMode_Click);
            // 
            // buttonFrenchFlag
            // 
            this.buttonFrenchFlag.Image = global::AstronomicalProcessing.Properties.Resources.FranceFlag;
            resources.ApplyResources(this.buttonFrenchFlag, "buttonFrenchFlag");
            this.buttonFrenchFlag.Name = "buttonFrenchFlag";
            this.buttonFrenchFlag.UseVisualStyleBackColor = true;
            this.buttonFrenchFlag.Click += new System.EventHandler(this.buttonFrenchFlag_Click);
            // 
            // buttonEnglishFlag
            // 
            this.buttonEnglishFlag.Image = global::AstronomicalProcessing.Properties.Resources.UKFlag;
            resources.ApplyResources(this.buttonEnglishFlag, "buttonEnglishFlag");
            this.buttonEnglishFlag.Name = "buttonEnglishFlag";
            this.buttonEnglishFlag.UseVisualStyleBackColor = true;
            this.buttonEnglishFlag.Click += new System.EventHandler(this.buttonEnglishFlag_Click);
            // 
            // buttonGermanFlag
            // 
            resources.ApplyResources(this.buttonGermanFlag, "buttonGermanFlag");
            this.buttonGermanFlag.Image = global::AstronomicalProcessing.Properties.Resources.GermanyFlag;
            this.buttonGermanFlag.Name = "buttonGermanFlag";
            this.buttonGermanFlag.UseVisualStyleBackColor = true;
            this.buttonGermanFlag.Click += new System.EventHandler(this.buttonGermanFlag_Click);
            // 
            // buttonFont
            // 
            resources.ApplyResources(this.buttonFont, "buttonFont");
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonBackground
            // 
            resources.ApplyResources(this.buttonBackground, "buttonBackground");
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Items.AddRange(new object[] {
            resources.GetString("comboBoxStyle.Items"),
            resources.GetString("comboBoxStyle.Items1")});
            resources.ApplyResources(this.comboBoxStyle, "comboBoxStyle");
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            resources.GetString("comboBoxLanguage.Items"),
            resources.GetString("comboBoxLanguage.Items1"),
            resources.GetString("comboBoxLanguage.Items2")});
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // menuStripFile
            // 
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStripFile, "menuStripFile");
            this.menuStripFile.Name = "menuStripFile";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.styleToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutscheToolStripMenuItem,
            this.englishUKToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.languageToolStripMenuItem_DropDownItemClicked);
            // 
            // deutscheToolStripMenuItem
            // 
            this.deutscheToolStripMenuItem.Name = "deutscheToolStripMenuItem";
            resources.ApplyResources(this.deutscheToolStripMenuItem, "deutscheToolStripMenuItem");
            // 
            // englishUKToolStripMenuItem
            // 
            this.englishUKToolStripMenuItem.Name = "englishUKToolStripMenuItem";
            resources.ApplyResources(this.englishUKToolStripMenuItem, "englishUKToolStripMenuItem");
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayModeToolStripMenuItem,
            this.nightModeToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            resources.ApplyResources(this.styleToolStripMenuItem, "styleToolStripMenuItem");
            this.styleToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.styleToolStripMenuItem_DropDownItemClicked);
            // 
            // dayModeToolStripMenuItem
            // 
            this.dayModeToolStripMenuItem.Name = "dayModeToolStripMenuItem";
            resources.ApplyResources(this.dayModeToolStripMenuItem, "dayModeToolStripMenuItem");
            // 
            // nightModeToolStripMenuItem
            // 
            this.nightModeToolStripMenuItem.Name = "nightModeToolStripMenuItem";
            resources.ApplyResources(this.nightModeToolStripMenuItem, "nightModeToolStripMenuItem");
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            resources.ApplyResources(this.backgroundToolStripMenuItem, "backgroundToolStripMenuItem");
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            resources.ApplyResources(this.fontToolStripMenuItem, "fontToolStripMenuItem");
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 0;
            this.toolTip.ReshowDelay = 0;
            // 
            // FormAstroProcessing
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxGuiCustomization);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripFile);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxEventHorizon);
            this.Controls.Add(this.groupBoxTempInKelvin);
            this.Controls.Add(this.groupBoxStarDistance);
            this.Controls.Add(this.groupBoxStarVelocity);
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "FormAstroProcessing";
            this.groupBoxStarVelocity.ResumeLayout(false);
            this.groupBoxStarVelocity.PerformLayout();
            this.groupBoxStarDistance.ResumeLayout(false);
            this.groupBoxStarDistance.PerformLayout();
            this.groupBoxTempInKelvin.ResumeLayout(false);
            this.groupBoxTempInKelvin.PerformLayout();
            this.groupBoxEventHorizon.ResumeLayout(false);
            this.groupBoxEventHorizon.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxGuiCustomization.ResumeLayout(false);
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxObservedWavelength;
        private System.Windows.Forms.TextBox textBoxRestWavelength;
        private System.Windows.Forms.TextBox textBoxParallaxAngle;
        private System.Windows.Forms.TextBox textBoxTempInCelsius;
        private System.Windows.Forms.Label labelTempInCelsius;
        private System.Windows.Forms.Label labelParallaxAngle;
        private System.Windows.Forms.Label labelObservedWavelength;
        private System.Windows.Forms.Label labelRestWavelength;
        private System.Windows.Forms.Label labelBlackholeMass;
        private System.Windows.Forms.GroupBox groupBoxStarVelocity;
        private System.Windows.Forms.GroupBox groupBoxStarDistance;
        private System.Windows.Forms.GroupBox groupBoxTempInKelvin;
        private System.Windows.Forms.GroupBox groupBoxEventHorizon;
        private System.Windows.Forms.TextBox textBoxBlackHoleMass;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader columnHeaderStarVelocity;
        private System.Windows.Forms.ColumnHeader columnHeaderStarDistance;
        private System.Windows.Forms.ColumnHeader columnHeaderTempInKelvin;
        private System.Windows.Forms.ColumnHeader columnHeaderEventHorizon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFeedback;
        private System.Windows.Forms.GroupBox groupBoxGuiCustomization;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutscheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishUKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonGermanFlag;
        private System.Windows.Forms.Button buttonFrenchFlag;
        private System.Windows.Forms.Button buttonEnglishFlag;
        private System.Windows.Forms.Button buttonNightMode;
        private System.Windows.Forms.Button buttonDayMode;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

