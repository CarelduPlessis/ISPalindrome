using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPalindrome
{
    public partial class ISPalindrome : Form
    {
        public ISPalindrome()
        {
            InitializeComponent();
        }

        /*
         What is Palindrome?: 

            Answer: "a word, phrase, or sequence that reads the same backwards as forwards, e.g. madam or nursesrun."

            Resource: Goougle Dictionary
         
         */



        private void btnCheckPalindrome_Click(object sender, EventArgs e)
        {
            lblResults.Text = IsTextPalindrome(tbxUserInput.Text).ToString();
        }


        // Resource: C# Online Compiler (.Net fiddle)
        public static bool IsTextPalindrome(string text)
        {
           // remove white space from string
            var splitted = text.Split(' ');

            string removeWhiteSpace = "";

            foreach (var t in splitted)
            {
                removeWhiteSpace += t;
            }

            // work out palindrome
            bool isTextPalindrome = true;

            char[] letter = removeWhiteSpace.ToCharArray();

            for (int i = 0; i < letter.Length; i++)
            {
                // if letters on both sides of the array, are the same then continue checking letters otherwise return false
                if (letter[i].ToString().ToLower() == letter[letter.Length - (i + 1)].ToString().ToLower())
                {
                    continue;
                }else{
                    isTextPalindrome = false;
                }
                
            }

            return isTextPalindrome;
        }
    }
}
