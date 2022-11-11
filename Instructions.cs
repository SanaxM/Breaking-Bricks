using System.Windows.Forms;
using System.Drawing;

namespace Breakout
{
    class Instructions
    {
        //global variables 
        private Form mInstructions = new Form();
        private Label mRules = new Label();
        private Label mInstructionsTitle = new Label();

       public Instructions(Form Rules, Label Instructions, Label Title, Music Audio)
        {
            //initialize labels
            mInstructions = Rules;
            mInstructionsTitle = Title;
            mRules = Instructions;

            //customize the screen (form) and then add in the title and explanation
            //I searched up how to create a form in memory, and I used the properties of starting in the center and 
            //disabling maximizing/minimizing
            mInstructions.StartPosition = FormStartPosition.CenterScreen; 
            mInstructions.BackColor = Color.Black;
            mInstructions.Height = 700;
            mInstructions.Width = 1070;
            mInstructions.Text = "Rules";
            mInstructions.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            mInstructions.MaximizeBox = false;

            //create the title
            //I searched up how to add controls (e.g picturebox, label) to a form in memory and I found that 
            //you need to manually add each control to the form
            mInstructions.Controls.Add(mInstructionsTitle);
            mInstructionsTitle.Location = new System.Drawing.Point(329, 10);
            mInstructionsTitle.Text = "Breakout: How to Play";
            mInstructionsTitle.ForeColor = Color.White;
            mInstructionsTitle.Visible = true;

            //create the body explanation
            mInstructions.Controls.Add(mRules);
            mRules.Location = new System.Drawing.Point(50 , 100);
            mRules.TextAlign = ContentAlignment.TopCenter; //I searched up how to get a label to have text in the middle
            mRules.Width = 100;
            mRules.Height = 30;
            mRules.Text = "Welcome to Breakout!" + "\n" +
                          "The objective of the game is to break all the bricks to win." + "\n" +
                          "There are two levels." + "\n" + 
                          "The difficulty increases in both levels the longer you're in the game." + "\n" +
                          "In Level 1, you have 3 lives and 98 bricks to break." + "\n" +
                          "In Level 2, you have 5 lives and 80 bricks to break " + "\n" + 
                          "The twist?" + "\n" +
                          "If you hit the golden paddle moving in the middle, " + "\n" +
                          "you LOSE a life!" + "\n" + 
                          "" + "\n" +
                          "CONTROLS:" + "\n" +
                          "LEFT ARROW KEY: Move the paddle to the left." + "\n" +
                          "RIGHT ARROW KEY: Move the paddle to the right." + "\n" +
                          "Be mindful, good luck, and farewell!";
            mRules.Visible = true;
            
        }

    }
}
