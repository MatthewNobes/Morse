﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //Array for the more code alphabet.
            //Array for the mores code alphabet represented by ASCII, each line is 10 ASCII digits.
            //Characters from 96+ were not needed because no morsecode exists for them.
            //Characters with no morese code below 95 have been left blank.
            string[] Morse =
                {
                    "", "", "", "", "", "", "", "", "", "", //0-9
                    "", "", "", "", "", "", "", "", "", "", //10-19
                    "", "", "", "", "", "", "", "", "", "", //20-29
                    "", "", "  ", "-·-·--", "·-··-·", "", "···-··-", "", "·-···", "·----·", //30-39
                    "-·--·", "-·--·-", "-..-", "·-·-·", "--··--", "-····-", "·-·-·-", "-··-·", "-----", ".----",  //40-49
                    "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "---...", "-.-.-.",  //50-59
                    "", "-...-", "", "..--..", ".--.-.",  ".-", "-...", "-.-.", "-..", ".", //60-69
                    "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", //70-79
                    ".--.", "--.-", ".-.",  "...", "-", "..-", "...-", ".--", "-..-", "-.--", //80-89
                    "--..", "", "", "", "","··--·-",  //90-95
                };

            //
            String Message = "";

            if (rbnEncode.Checked)
            {
                //Repeates for every letter entered.
                foreach (char c in txtInput.Text.ToUpper())
                {
                    //Converts letters to ASCII then takes the first ASCII number away to start from 0.
                    Message = Message + " " + Morse[System.Convert.ToInt32(c)];
                }
            }

            else
            {
                Message = "Sorry, this function is not supported yet.";
            }

            //Output Code
            txtOutput.Text = Message;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switchIt();
        }

        private void switchIt()
        {
            if (rbnEncode.Checked)
            {
                //Swaps the labels around.
                grbInput.Text = "Input Text";
                grbOutput.Text = "Output Morse code";

                //Wipes text boxes
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            else
            {
                //Swaps the labels around.
                grbInput.Text = "Input Morse Code";
                grbOutput.Text = "Output Text";

                //Wipes text boxes
                txtInput.Text = "";
                txtOutput.Text = "";
            }
        }

        private void rbnEncode_CheckedChanged(object sender, EventArgs e)
        {
            switchIt();
        }

        private void rbnDecode_CheckedChanged(object sender, EventArgs e)
        {
            switchIt();
        }
    }
}
