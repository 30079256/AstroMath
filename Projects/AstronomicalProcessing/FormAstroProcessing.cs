using ConsoleAppClient;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

// Student Name: Olga Selezneva
// Student ID: 30079256
// Date: 29/04/2024

// Develop a Windows Forms Application client so users can send raw data to the server and receive processed information. 
namespace AstronomicalProcessing
{
    public partial class FormAstroProcessing : Form
    {
        public FormAstroProcessing()
        {
            InitializeComponent();            
        }
 
        private static readonly ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(
            new NetNamedPipeBinding(),
            new EndpointAddress("net.pipe://localhost/AstroService"));

        // 2.	Create a form with suitable components for UI,
        // a.Series of textboxes for large numeric data,
        // b.A listview/datagrid for display of processed information from the server,
        // c.Button(s) to initiate an event and send/receive data.
        #region Calculate
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string[] calcResults = new string[4];

            if (!string.IsNullOrEmpty(textBoxObservedWavelength.Text) && !string.IsNullOrEmpty(textBoxRestWavelength.Text))
            {
                calcResults[0] = CalculateStarVelocity();
            }
            else
            {
                calcResults[0] = "";
            }

            if (!string.IsNullOrEmpty(textBoxParallaxAngle.Text))
            {
                calcResults[1] = CalculateStarDistance();
            }
            else
            {
                calcResults[1] = "";
            }

            if (!string.IsNullOrEmpty(textBoxTempInCelsius.Text))
            {
                calcResults[2] = CalculateKelvinTemperature();
            }
            else
            {
                calcResults[2] = "";
            }

            if (!string.IsNullOrEmpty(textBoxBlackHoleMass.Text))
            {
                calcResults[3] = CalculateEventHorizon();
            }
            else
            {
                calcResults[3] = "";
            }

            if (!calcResults.All(string.IsNullOrEmpty))
            {
                ListViewItem item = new ListViewItem(calcResults);
                listViewResults.Items.Add(item);
            }

            ClearTextboxInput();
        }
        #endregion

        #region StarVelocity
        private string CalculateStarVelocity()
        {

            IAstroContract pipeProxy = pipeFactory.CreateChannel();
            IClientChannel channel = (IClientChannel)pipeProxy;

            try
            {
                if (double.TryParse(textBoxObservedWavelength.Text, out double obsWavNm) &&
                   double.TryParse(textBoxRestWavelength.Text, out double restWavNm) &&
                   obsWavNm > 0 && restWavNm > 0)
                {
                    return Math.Round(pipeProxy.StarVelocity(obsWavNm, restWavNm)).ToString() + " m/s";
                }
                else
                {                    
                    toolStripStatusLabelFeedback.Text = "Error: Wavelengths should be populated with doubles greater than 0";
                }
            }
            catch (Exception ex)
            {                
                toolStripStatusLabelFeedback.Text = ex.Message;
            }
            finally
            {
                try
                {
                    if (channel.State != CommunicationState.Faulted)
                    {
                        channel.Close();
                    }
                }
                catch (Exception ex)
                {
                    channel.Abort();
                    toolStripStatusLabelFeedback.Text = ex.Message;
                }                
            }
            return "-";
        }
        #endregion

        #region StarDistance
        private string CalculateStarDistance()
        {
            IAstroContract pipeProxy = pipeFactory.CreateChannel();
            IClientChannel channel = (IClientChannel)pipeProxy;

            try
            {
                if (double.TryParse(textBoxParallaxAngle.Text, out double parAngArcs))
                {
                    if (parAngArcs <= 0)
                    {
                        toolStripStatusLabelFeedback.Text = "Error: Parallax angle must be greater than 0";
                        return "-";
                    }

                    return Math.Round(pipeProxy.StarDistance(parAngArcs), 2).ToString() + " parsec";
                }
                else
                {
                    toolStripStatusLabelFeedback.Text = "Error: Invalid parallax angle. Please enter a double";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelFeedback.Text = ex.Message;
            }
            finally
            {
                try
                {
                    if (channel.State != CommunicationState.Faulted)
                    {
                        channel.Close();
                    }
                }
                catch (Exception ex)
                {
                    channel.Abort();
                    toolStripStatusLabelFeedback.Text = ex.Message;
                }
            }
            return "-";
        }
        #endregion

        #region KelvinTemperature
        private string CalculateKelvinTemperature()
        {
            IAstroContract pipeProxy = pipeFactory.CreateChannel();
            IClientChannel channel = (IClientChannel)pipeProxy;

            try
            {
                if (double.TryParse(textBoxTempInCelsius.Text, out double celsTempDeg))
                {
                    if (celsTempDeg <= -273)
                    {
                        toolStripStatusLabelFeedback.Text = "Error: Temperature in Celsius must be greater than -273";
                        return "-";
                    }

                    return pipeProxy.KelvinTemperature(celsTempDeg).ToString() + " degrees K";
                }
                else
                {
                    toolStripStatusLabelFeedback.Text = "Error: Invalid temp in Celsius. Please enter a double";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelFeedback.Text = ex.Message;
            }
            finally
            {
                try
                {
                    if (channel.State != CommunicationState.Faulted)
                    {
                        channel.Close();
                    }
                }
                catch (Exception ex)
                {
                    channel.Abort();
                    toolStripStatusLabelFeedback.Text = ex.Message;
                }
            }
            return "-";
        }
        #endregion

        #region EventHorizon
        private string CalculateEventHorizon()
        {
            IAstroContract pipeProxy = pipeFactory.CreateChannel();
            IClientChannel channel = (IClientChannel)pipeProxy;


            if (Regex.IsMatch(textBoxBlackHoleMass.Text, @"[\d\.]+e\+\d+"))
            {
                try
                {
                    double blackMassKg = double.Parse(textBoxBlackHoleMass.Text);
                    return pipeProxy.EventHorizon(blackMassKg).ToString("0.0e+00").Replace("e+", " x 10^") + " metres";
                }
                catch (Exception ex)
                {
                    toolStripStatusLabelFeedback.Text = ex.Message;
                }
                finally
                {
                    try
                    {
                        if (channel.State != CommunicationState.Faulted)
                        {
                            channel.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        channel.Abort();
                        toolStripStatusLabelFeedback.Text = ex.Message;
                    }
                }
            }
            else
            {
                toolStripStatusLabelFeedback.Text = "Error: Invalid black hole mass. Please enter a double in scientific notation 0.0e+00";
            }
            return "-";
        }
        #endregion

        #region Clear
        private void ClearTextboxInput()
        {
            textBoxObservedWavelength.Clear();
            textBoxRestWavelength.Clear();
            textBoxParallaxAngle.Clear();
            textBoxTempInCelsius.Clear();
            textBoxBlackHoleMass.Clear();
        }
              
        private void textBoxObservedWavelength_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelFeedback.Text = "";
        }
        #endregion

        // 3.	Menu and Button option(s) to change the language and layout for the three different countries.
        #region LanguageCombobox
        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeLanguage(comboBoxLanguage.SelectedItem.ToString());
        }
        #endregion

        #region LanguageButtons
        private void buttonGermanFlag_Click(object sender, EventArgs e)
        {
            ChangeLanguage("Deutsche");
        }

        private void buttonEnglishFlag_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English (UK)");
        }

        private void buttonFrenchFlag_Click(object sender, EventArgs e)
        {
            ChangeLanguage("Française");
        }
        #endregion

        #region LanguageMethod
        private void ChangeLanguage(string language)
        {
            switch (language)
            {
                case "English (UK)":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
                    break;
                case "Française":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                    break;
                case "Deutsche":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");
                    break; 
            }
            Controls.Clear();
            InitializeComponent();
            SetDayNightMode(0);
        }
        #endregion

        // 4.	Menu and Button option(s) to change the form’s style (colours and visual appearance).
        #region DayNightCombobox
        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDayNightMode(comboBoxStyle.SelectedIndex);
        }
        #endregion

        #region DayNightButtons
        private void buttonDayMode_Click(object sender, EventArgs e)
        {
            SetDayNightMode(0);
            comboBoxStyle.Text = buttonDayMode.Text;
        }

        private void buttonNightMode_Click(object sender, EventArgs e)
        {
            SetDayNightMode(1);
            comboBoxStyle.Text = buttonNightMode.Text;
        }
        #endregion

        #region DayNightMethods 
        private void SetDayNightMode(int mode)
        {           
            if (mode == 0)
            {
                this.BackColor = Color.FromArgb(240, 240, 240); 
            }
            else if (mode == 1)
            {
                this.BackColor = Color.FromArgb(45, 45, 48); 
            }

            foreach (Control c in this.Controls)
            {
                ChangeColors(mode, c);

                if (c is GroupBox)
                {
                    foreach (Control child in c.Controls)
                    {
                        ChangeColors(mode, child);
                    }
                }
            }
        }
 
        private void ChangeColors(int mode, Control c)
        {
            if (mode == 0)
            {
                c.ForeColor = SystemColors.WindowText;                
                
                if (c is ListView)
                {
                    c.BackColor = Color.White;
                }
                else if (c is Button)
                {
                    c.BackColor = Color.FromArgb(225, 225, 225);
                }
                else if (c is TextBox || c is ComboBox)
                {
                    c.BackColor = Color.White;
                }
                else
                {
                    c.BackColor = Color.FromArgb(240, 240, 240);
                }
            }
            else if (mode == 1)
            {
                c.BackColor = Color.FromArgb(45, 45, 48);
                c.ForeColor = Color.WhiteSmoke;
            }
        }
        #endregion

        // 5.	Menu and Button option(s) to select a custom background colour from a colour palette (Color Dialogbox)
        #region Background
        private void buttonBackground_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SetDayNightMode(0);
                comboBoxStyle.Text = styleToolStripMenuItem.Text;
                this.BackColor = colorDialog.Color;
                                
                Color textColor = Color.FromArgb((colorDialog.Color.R + 128) % 256, (colorDialog.Color.G + 128) % 256, (colorDialog.Color.B + 128) % 256);
                foreach (Control c in this.Controls)
                {
                    if (c is GroupBox)
                    {
                        c.ForeColor = textColor;
                        c.BackColor = colorDialog.Color;

                        foreach (Control child in c.Controls)
                        {
                            if (child is Label)
                            {
                                child.ForeColor = textColor;
                                child.BackColor = colorDialog.Color;
                            }
                            else if (child is Button)
                            {
                                child.ForeColor = SystemColors.WindowText;
                            }
                        }
                    }
                }
            }            
        }
        #endregion

        // 6.	Menu and Button option(s) to select a custom font and size from a font list (Font Dialogbox)
        #region Font
        private void buttonFont_Click(object sender, EventArgs e)
        { 
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control c in this.Controls)
                {
                    c.Font = fontDialog.Font;

                    if (c.HasChildren)
                    {
                        foreach (Control child in c.Controls) { child.Font = fontDialog.Font; }
                    }
                }
            }
        }
        #endregion

        #region FileMenu
        private void languageToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ChangeLanguage(e.ClickedItem.Text);            
        }

        private void styleToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SetDayNightMode(styleToolStripMenuItem.DropDownItems.IndexOf(e.ClickedItem));
            comboBoxStyle.Text = e.ClickedItem.Text;
        }
        #endregion
    }
}
