using System;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace JSONParser1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI events

        private void cmdDeserialise_Click(object sender, EventArgs e)
        {
            //debugOutput(txtInput.Text);
            deserialiseJSON(txtInput.Text);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }

        #endregion

        #region json functions

        private void deserialiseJSON(string strJSON)
        {
            try
            {                
                var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);

                debugOutput("Here's our JSON object: " + jPerson.ToString());

                debugOutput("Here's the First Name: " + jPerson[1].name);
                debugOutput("Here's the First email: " + jPerson[1].email);
                debugOutput("Here's the First nation: " + jPerson[1].nationality);                
            }
            catch(Exception ex)
            {
                debugOutput("We had a problem: " + ex.Message.ToString());
            }
        }

        #endregion

        #region Deubg output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        #endregion
    }
}
