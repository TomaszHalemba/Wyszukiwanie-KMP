using System;

using System.Windows.Forms;

namespace Ja_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //function that activate after clicking "cpp" button
        //textBoxWhere have text from where file should be located
        //textBoxString have text of pattern
        //partText contains if algorythm need to find full word or not
        private void Run_Click(object sender, EventArgs e)
        {

            if (textBoxWhere.Text.Trim() == "" || textBoxString.Text.Trim() == "")
                timer.Text = "no Input!";
            else
            {
                cppCount.Text = DLLControler.Action_cpp(textBoxWhere.Text, textBoxString.Text, partText.Checked);
                if (DLLControler.error == true)
                    timer.Text = "error reading file!";
                else
                    timer.Text = DLLControler.Time.ToString()+" Ticks";
            }
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
        //function that activate after clicking "asm" button
        //textBoxWhere have text from where file should be located
        //textBoxString have text of pattern
        //partText contains if algorythm need to find full word or not
        private void ASM_Click(object sender, EventArgs e)
        {
         
            if (textBoxWhere.Text.Trim() == "" || textBoxString.Text.Trim() == "")
                timer.Text = "no Input!";
            else
            {
                asmCount.Text = DLLControler.Action_asm(textBoxWhere.Text, textBoxString.Text, partText.Checked);
                if (DLLControler.error == true)
                    timer.Text = "error reading file!";
                else
                    timer.Text = DLLControler.Time.ToString() + " Ticks";

            }
        }
    }
}
