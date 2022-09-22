namespace Calculadora
{
    public partial class Main : Form
    {
        private Rectangle textBoxTxtInput;
        private Rectangle buttonMcOriginalReact;
        private Rectangle buttonMrOriginalReact;
        private Rectangle buttonMplusOriginalReact;
        private Rectangle buttonMminusOriginalReact;
        private Rectangle buttonMsOriginalReact;
        private Rectangle buttonMhistOriginalReact;
        private Rectangle buttonPorcentOriginalReact;
        private Rectangle buttonClearOriginalReact;
        private Rectangle buttonClearAllOriginalReact;
        private Rectangle buttonDellOriginalReact;
        private Rectangle buttonAboutXOriginalReact;
        private Rectangle buttonSquareOriginalReact;
        private Rectangle buttonRootOfTwoOriginalReact;
        private Rectangle buttonDivisionOriginalReact;
        private Rectangle button7OriginalReact;
        private Rectangle button8OriginalReact;
        private Rectangle button9OriginalReact;
        private Rectangle buttonXOriginalReact;
        private Rectangle button4OriginalReact;
        private Rectangle button5OriginalReact;
        private Rectangle button6OriginalReact;
        private Rectangle buttonSubtractOriginalReact;
        private Rectangle button1OriginalReact;
        private Rectangle button2OriginalReact;
        private Rectangle button3OriginalReact;
        private Rectangle buttonPlusOriginalReact;
        private Rectangle buttonInvertOriginalReact;
        private Rectangle button0OriginalReact;
        private Rectangle buttonSeparatorOriginalReact;
        private Rectangle buttonEqualOriginalReact;


        private Size formoriginalSize;

        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            formoriginalSize = this.Size;



            textBoxTxtInput = new Rectangle(txt_input.Location.X, txt_input.Location.Y, txt_input.Width, txt_input.Height);
            buttonMcOriginalReact = new Rectangle(btn_MC.Location.X, btn_MC.Location.Y, btn_MC.Width, btn_MC.Height);
            buttonMrOriginalReact = new Rectangle(btn_MR.Location.X, btn_MR.Location.Y, btn_MR.Width, btn_MR.Height);
            buttonMplusOriginalReact = new Rectangle(btn_Mplus.Location.X, btn_Mplus.Location.Y, btn_Mplus.Width, btn_Mplus.Height);
            buttonMminusOriginalReact = new Rectangle(btn_Mminus.Location.X, btn_Mminus.Location.Y, btn_Mminus.Width, btn_Mminus.Height);
            buttonMsOriginalReact = new Rectangle(btn_Ms.Location.X, btn_Ms.Location.Y, btn_Ms.Width, btn_Ms.Height);
            buttonMhistOriginalReact = new Rectangle(btn_hist.Location.X, btn_hist.Location.Y, btn_hist.Width, btn_hist.Height);
            buttonPorcentOriginalReact = new Rectangle(btn_porcent.Location.X, btn_porcent.Location.Y, btn_porcent.Width, btn_porcent.Height);
            buttonClearOriginalReact = new Rectangle(btn_clear.Location.X, btn_clear.Location.Y, btn_clear.Width, btn_clear.Height);
            buttonClearAllOriginalReact = new Rectangle(btn_clearAll.Location.X, btn_clearAll.Location.Y, btn_clearAll.Width, btn_clearAll.Height);
            buttonDellOriginalReact = new Rectangle(btn_ruber.Location.X, btn_ruber.Location.Y, btn_ruber.Width, btn_ruber.Height);
            buttonAboutXOriginalReact = new Rectangle(btn_aboutX.Location.X, btn_aboutX.Location.Y, btn_aboutX.Width, btn_aboutX.Height);
            buttonSquareOriginalReact = new Rectangle(btn_square.Location.X, btn_square.Location.Y, btn_square.Width, btn_square.Height);
            buttonRootOfTwoOriginalReact = new Rectangle(btn_rootOfTwo.Location.X, btn_rootOfTwo.Location.Y, btn_rootOfTwo.Width, btn_rootOfTwo.Height);
            buttonDivisionOriginalReact = new Rectangle(btn_division.Location.X, btn_division.Location.Y, btn_division.Width, btn_division.Height);
            button7OriginalReact = new Rectangle(btn_7.Location.X, btn_7.Location.Y, btn_7.Width, btn_7.Height);
            button8OriginalReact = new Rectangle(btn_8.Location.X, btn_8.Location.Y, btn_8.Width, btn_8.Height);
            button9OriginalReact = new Rectangle(btn_9.Location.X, btn_9.Location.Y, btn_9.Width, btn_9.Height);
            buttonXOriginalReact = new Rectangle(btn_multiply.Location.X, btn_multiply.Location.Y, btn_multiply.Width, btn_multiply.Height);
            button4OriginalReact = new Rectangle(btn_4.Location.X, btn_4.Location.Y, btn_4.Width, btn_4.Height);
            button5OriginalReact = new Rectangle(btn_5.Location.X, btn_5.Location.Y, btn_5.Width, btn_5.Height);
            button6OriginalReact = new Rectangle(btn_6.Location.X, btn_6.Location.Y, btn_6.Width, btn_6.Height);
            buttonSubtractOriginalReact = new Rectangle(btn_subtract.Location.X, btn_subtract.Location.Y, btn_subtract.Width, btn_subtract.Height);
            button1OriginalReact = new Rectangle(btn_1.Location.X, btn_1.Location.Y, btn_1.Width, btn_1.Height);
            button2OriginalReact = new Rectangle(btn_2.Location.X, btn_2.Location.Y, btn_2.Width, btn_2.Height);
            button3OriginalReact = new Rectangle(btn_3.Location.X, btn_3.Location.Y, btn_3.Width, btn_3.Height);
            buttonPlusOriginalReact = new Rectangle(btn_add.Location.X, btn_add.Location.Y, btn_add.Width, btn_add.Height);
            buttonInvertOriginalReact = new Rectangle(btn_invert.Location.X, btn_invert.Location.Y, btn_invert.Width, btn_invert.Height);
            button0OriginalReact = new Rectangle(btn_0.Location.X, btn_0.Location.Y, btn_0.Width, btn_0.Height);
            buttonSeparatorOriginalReact = new Rectangle(btn_separator.Location.X, btn_separator.Location.Y, btn_separator.Width, btn_separator.Height);
            buttonEqualOriginalReact = new Rectangle(btn_equal.Location.X, btn_equal.Location.Y, btn_equal.Width, btn_equal.Height);
        }
        
        private void resizeChildrenControls()
        {

            ResizeControl(textBoxTxtInput, txt_input);
            ResizeControl(buttonMcOriginalReact, btn_MC);
            ResizeControl(buttonMrOriginalReact, btn_MR);
            ResizeControl(buttonMplusOriginalReact, btn_Mplus);
            ResizeControl(buttonMminusOriginalReact, btn_Mminus);
            ResizeControl(buttonMsOriginalReact, btn_Ms);
            ResizeControl(buttonMhistOriginalReact, btn_hist);
            ResizeControl(buttonPorcentOriginalReact, btn_porcent);
            ResizeControl(buttonClearOriginalReact, btn_clear);
            ResizeControl(buttonClearAllOriginalReact, btn_clearAll);
            ResizeControl(buttonDellOriginalReact, btn_ruber);
            ResizeControl(buttonAboutXOriginalReact, btn_aboutX);
            ResizeControl(buttonSquareOriginalReact, btn_square);
            ResizeControl(buttonRootOfTwoOriginalReact, btn_rootOfTwo);
            ResizeControl(buttonDivisionOriginalReact, btn_division);
            ResizeControl(button7OriginalReact, btn_7);
            ResizeControl(button8OriginalReact, btn_8);
            ResizeControl(button9OriginalReact, btn_9);
            ResizeControl(buttonXOriginalReact, btn_multiply);
            ResizeControl(button4OriginalReact, btn_4);
            ResizeControl(button5OriginalReact, btn_5);
            ResizeControl(button6OriginalReact, btn_6);
            ResizeControl(buttonSubtractOriginalReact, btn_subtract);
            ResizeControl(button1OriginalReact, btn_1);
            ResizeControl(button2OriginalReact, btn_2);
            ResizeControl(button3OriginalReact, btn_3);
            ResizeControl(buttonPlusOriginalReact, btn_add);
            ResizeControl(buttonInvertOriginalReact, btn_invert);
            ResizeControl(button0OriginalReact, btn_0);
            ResizeControl(buttonSeparatorOriginalReact, btn_separator);
            ResizeControl(buttonEqualOriginalReact, btn_equal);
        }


        private void ResizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formoriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formoriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
           resizeChildrenControls();
        }





        private void number_click(object sender, EventArgs e)
        {

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}